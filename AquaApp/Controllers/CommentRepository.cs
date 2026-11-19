using AquaApp.Models;
using NHibernate.Linq;

namespace AquaApp.Controllers
{
    public class CommentRepository
    {
        public List<ReviewComment> GetByProject(int projectId)
        {
            return NHibernateHelper.Read(s =>
                s.Query<ReviewComment>()
                 .Where(c => c.Project.ProjectId == projectId)
                 .OrderBy(c => c.CreatedAt)
                 .Fetch(c => c.Author)
                 .ToList());
        }

        public ReviewComment GetById(int commentId)
        {
            return NHibernateHelper.Read(s => s.Get<ReviewComment>(commentId));
        }

        /// <summary>The newest "Info Request" comment on a project, or null.</summary>
        public ReviewComment GetLatestInfoRequest(int projectId)
        {
            return NHibernateHelper.Read(s =>
                s.Query<ReviewComment>()
                 .Where(c => c.Project.ProjectId == projectId && c.Type == CommentTypes.InfoRequest)
                 .OrderByDescending(c => c.CreatedAt)
                 .Fetch(c => c.Author)
                 .ToList()
                 .FirstOrDefault());
        }

        public void Add(int projectId, int userId, string type, string text)
        {
            NHibernateHelper.Write(s => s.Save(new ReviewComment
            {
                Project = s.Get<Project>(projectId),
                Author = s.Get<User>(userId),
                Type = type,
                Text = text,
                CreatedAt = DateTime.Now
            }));
        }

        public void UpdateText(int commentId, string text)
        {
            NHibernateHelper.Write(s => s.Get<ReviewComment>(commentId).Text = text);
        }

        public void Delete(int commentId)
        {
            NHibernateHelper.Write(s => s.Delete(s.Get<ReviewComment>(commentId)));
        }
    }
}
