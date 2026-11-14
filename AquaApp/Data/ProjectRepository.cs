using AquaApp.Models;
using NHibernate;
using NHibernate.Linq;

namespace AquaApp.Data
{
    public class ProjectRepository
    {
        /// <summary>Loads the category, organization and reviewer in the same query (SQL JOIN).</summary>
        private static List<Project> ListWithDetails(IQueryable<Project> query)
        {
            return query
                .Fetch(p => p.Category)
                .Fetch(p => p.Organization)
                .Fetch(p => p.Reviewer)
                .ToList();
        }

        // ---------- Read ----------

        public Project GetById(int id)
        {
            return NHibernateHelper.Read(s => s.Get<Project>(id));
        }

        /// <summary>
        /// Search and filter projects. Pass null for a filter you do not need.
        /// organizationId / reviewerId limit the list to one organization or one reviewer.
        /// </summary>
        public List<Project> Search(string text, string status, bool includeArchived, int? organizationId, int? reviewerId)
        {
            return NHibernateHelper.Read(s =>
            {
                IQueryable<Project> query = s.Query<Project>();

                if (!string.IsNullOrWhiteSpace(text))
                {
                    string t = text.Trim().ToLower();
                    query = query.Where(p => p.Title.ToLower().Contains(t) || p.ReferenceNo.ToLower().Contains(t));
                }
                if (!string.IsNullOrWhiteSpace(status))
                {
                    query = query.Where(p => p.Status == status);
                }
                if (!includeArchived)
                {
                    query = query.Where(p => !p.IsArchived);
                }
                if (organizationId.HasValue)
                {
                    int orgId = organizationId.Value;
                    query = query.Where(p => p.Organization.UserId == orgId);
                }
                if (reviewerId.HasValue)
                {
                    int revId = reviewerId.Value;
                    query = query.Where(p => p.Reviewer.UserId == revId);
                }

                return ListWithDetails(query.OrderByDescending(p => p.SubmittedAt));
            });
        }

        /// <summary>Projects a manager can still assign: Received or Under Review, not archived. Unassigned first.</summary>
        public List<Project> GetAssignable()
        {
            List<Project> projects = NHibernateHelper.Read(s => ListWithDetails(
                s.Query<Project>().Where(p => !p.IsArchived
                    && (p.Status == ProjectStatus.Received || p.Status == ProjectStatus.UnderReview))));

            return projects
                .OrderBy(p => p.ReviewerId == null ? 0 : 1)
                .ThenBy(p => p.SubmittedAt)
                .ToList();
        }

        /// <summary>Number of projects per status, optionally for one organization or one reviewer.</summary>
        public Dictionary<string, int> CountByStatus(int? organizationId, int? reviewerId)
        {
            var rows = NHibernateHelper.Read(s =>
            {
                IQueryable<Project> query = s.Query<Project>();
                if (organizationId.HasValue)
                {
                    int orgId = organizationId.Value;
                    query = query.Where(p => p.Organization.UserId == orgId);
                }
                if (reviewerId.HasValue)
                {
                    int revId = reviewerId.Value;
                    query = query.Where(p => p.Reviewer.UserId == revId);
                }
                return query.GroupBy(p => p.Status)
                            .Select(g => new { Status = g.Key, Total = g.Count() })
                            .ToList();
            });

            Dictionary<string, int> counts = ProjectStatus.All.ToDictionary(status => status, status => 0);
            foreach (var row in rows)
            {
                counts[row.Status] = row.Total;
            }
            return counts;
        }

        /// <summary>Next reference number for the year, for example AQUA-2026-0007.</summary>
        public string NextReferenceNo(int year)
        {
            string prefix = $"AQUA-{year}-";
            List<string> existing = NHibernateHelper.Read(s =>
                s.Query<Project>().Where(p => p.ReferenceNo.StartsWith(prefix)).Select(p => p.ReferenceNo).ToList());

            int last = 0;
            foreach (string reference in existing)
            {
                if (int.TryParse(reference.Substring(prefix.Length), out int number) && number > last)
                    last = number;
            }
            return prefix + (last + 1).ToString("D4");
        }

        // ---------- Create ----------

        public int Add(Project project)
        {
            project.SubmittedAt = DateTime.Now;
            project.UpdatedAt = DateTime.Now;
            NHibernateHelper.Write(s => s.Save(project));
            return project.ProjectId;
        }

        // ---------- Update ----------

        public void UpdateDetails(Project project)
        {
            NHibernateHelper.Write(s =>
            {
                Project saved = s.Get<Project>(project.ProjectId);
                saved.Title = project.Title;
                saved.Description = project.Description;
                saved.Category = s.Get<Category>(project.CategoryId);
                saved.Location = project.Location;
                saved.Budget = project.Budget;
                saved.UpdatedAt = DateTime.Now;
            });
        }

        public void UpdateStatus(int projectId, string status)
        {
            Change(projectId, (s, p) => p.Status = status);
        }

        public void SetReviewer(int projectId, int? reviewerId, string status)
        {
            Change(projectId, (s, p) =>
            {
                p.Reviewer = reviewerId.HasValue ? s.Get<User>(reviewerId.Value) : null;
                p.Status = status;
            });
        }

        public void SetDecision(int projectId, string status, string reason)
        {
            Change(projectId, (s, p) =>
            {
                p.Status = status;
                p.DecisionReason = reason;
            });
        }

        public void SetArchived(int projectId, bool archived)
        {
            Change(projectId, (s, p) => p.IsArchived = archived);
        }

        private static void Change(int projectId, Action<ISession, Project> change)
        {
            NHibernateHelper.Write(s =>
            {
                Project saved = s.Get<Project>(projectId);
                change(s, saved);
                saved.UpdatedAt = DateTime.Now;
            });
        }

        // ---------- Delete ----------

        /// <summary>Deletes the project together with its comments and documents, in one transaction.</summary>
        public void Delete(int projectId)
        {
            NHibernateHelper.Write(s =>
            {
                foreach (ReviewComment comment in s.Query<ReviewComment>().Where(c => c.Project.ProjectId == projectId).ToList())
                    s.Delete(comment);

                foreach (ProjectDocument document in s.Query<ProjectDocument>().Where(d => d.Project.ProjectId == projectId).ToList())
                    s.Delete(document);

                s.Delete(s.Get<Project>(projectId));
            });
        }
    }
}
