using System.Diagnostics;
using AquaApp.Data;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Controllers
{
    /// <summary>
    /// Project submission, editing, resubmission, listing, archiving and deletion.
    /// Methods that change data return an error message, or null when everything worked.
    /// </summary>
    public class ProjectController
    {
        private static readonly string[] AllowedExtensions =
            { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".jpg", ".jpeg", ".png" };
        private const long MaxFileBytes = 10 * 1024 * 1024; // 10 MB

        private readonly ProjectRepository _projects = new ProjectRepository();
        private readonly DocumentRepository _documents = new DocumentRepository();
        private readonly CommentRepository _comments = new CommentRepository();
        private readonly CategoryRepository _categories = new CategoryRepository();

        /// <summary>Folder where uploaded documents are copied, next to the .exe.</summary>
        public static string DocumentsRoot => Path.Combine(AppContext.BaseDirectory, "Documents");

        // ---------- Read ----------

        /// <summary>
        /// Projects the current user may see: an organization sees its own,
        /// a reviewer sees projects assigned to them, managers and admins see all.
        /// status = null or "All" means every status.
        /// </summary>
        public List<Project> GetProjects(string search, string status, bool includeArchived)
        {
            int? orgId = Session.IsOrganization ? Session.CurrentUser.UserId : null;
            int? reviewerId = Session.IsReviewer ? Session.CurrentUser.UserId : null;
            string statusFilter = (status == null || status == "All") ? null : status;
            return _projects.Search(search, statusFilter, includeArchived, orgId, reviewerId);
        }

        public Project GetProject(int projectId) => _projects.GetById(projectId);

        public List<ProjectDocument> GetDocuments(int projectId) => _documents.GetByProject(projectId);

        public List<ReviewComment> GetHistory(int projectId) => _comments.GetByProject(projectId);

        public ReviewComment GetLatestInfoRequest(int projectId) => _comments.GetLatestInfoRequest(projectId);

        public List<Category> GetCategories() => _categories.GetAll();

        /// <summary>Counts per status for the dashboard, limited to what the current user may see.</summary>
        public Dictionary<string, int> GetStatusCounts()
        {
            int? orgId = Session.IsOrganization ? Session.CurrentUser.UserId : null;
            int? reviewerId = Session.IsReviewer ? Session.CurrentUser.UserId : null;
            return _projects.CountByStatus(orgId, reviewerId);
        }

        // ---------- Permission checks (used by the views to enable buttons) ----------

        public bool CanView(Project p)
        {
            if (p == null) return false;
            if (Session.IsManagerOrAdmin) return true;
            if (Session.IsOrganization) return p.OrganizationId == Session.CurrentUser.UserId;
            if (Session.IsReviewer) return p.ReviewerId == Session.CurrentUser.UserId;
            return false;
        }

        public bool CanEdit(Project p)
        {
            return p != null
                && !p.IsArchived
                && Session.IsOrganization
                && p.OrganizationId == Session.CurrentUser.UserId
                && (p.Status == ProjectStatus.Received || p.Status == ProjectStatus.InfoRequested);
        }

        public bool CanDelete(Project p)
        {
            if (p == null) return false;
            if (Session.IsAdmin) return true;
            return Session.IsOrganization
                && p.OrganizationId == Session.CurrentUser.UserId
                && p.Status == ProjectStatus.Received
                && p.ReviewerId == null;
        }

        public bool CanArchive(Project p)
        {
            return p != null
                && Session.IsManagerOrAdmin
                && (p.Status == ProjectStatus.Approved || p.Status == ProjectStatus.Rejected);
        }

        // ---------- Documents ----------

        /// <summary>Checks a file before it is attached. Returns an error message or null.</summary>
        public string ValidateFile(string path)
        {
            if (!File.Exists(path)) return "The file does not exist.";
            string extension = Path.GetExtension(path).ToLowerInvariant();
            if (!AllowedExtensions.Contains(extension))
                return "Only PDF, Word, Excel and image files (JPG, PNG) can be attached.";
            if (new FileInfo(path).Length > MaxFileBytes)
                return "The file is larger than 10 MB.";
            return null;
        }

        public string OpenDocument(ProjectDocument document)
        {
            if (document == null) return "Select a document first.";
            if (!File.Exists(document.FilePath)) return "The file could not be found: " + document.FilePath;
            Process.Start(new ProcessStartInfo(document.FilePath) { UseShellExecute = true });
            return null;
        }

        // ---------- Create and Update ----------

        /// <summary>
        /// Saves a new project (Create) or changes an existing one (Update).
        /// documents = the full list shown in the form (new files have DocumentId 0).
        /// removedDocumentIds = saved documents the user removed.
        /// response = the organization's answer when the project is in "Information Requested".
        /// </summary>
        public string Save(Project project, List<ProjectDocument> documents, List<int> removedDocumentIds, string response)
        {
            // Validation
            if (Validator.IsEmpty(project.Title)) return "Enter the project title.";
            if (project.Title.Trim().Length > 200) return "The title can have at most 200 characters.";
            if (Validator.IsEmpty(project.Description)) return "Enter the project description.";
            if (project.Category == null) return "Choose a category.";
            if (Validator.IsEmpty(project.Location)) return "Enter the project location.";
            if (project.Budget < 0) return "The budget cannot be negative.";
            if (documents == null || documents.Count == 0) return "Attach at least one supporting document.";

            project.Title = project.Title.Trim();
            project.Description = project.Description.Trim();
            project.Location = project.Location.Trim();

            if (project.ProjectId == 0)
            {
                if (!Session.IsOrganization) return "Only organizations can submit projects.";

                // Create
                project.ReferenceNo = _projects.NextReferenceNo(DateTime.Now.Year);
                project.Status = ProjectStatus.Received;
                project.Organization = Session.CurrentUser;
                project.ProjectId = _projects.Add(project);
            }
            else
            {
                Project saved = _projects.GetById(project.ProjectId);
                if (!CanEdit(saved)) return "This project can no longer be edited.";

                bool isResubmission = saved.Status == ProjectStatus.InfoRequested;
                if (isResubmission && Validator.IsEmpty(response))
                    return "Write your response to the reviewer's request before resubmitting.";

                // Update
                project.ReferenceNo = saved.ReferenceNo;
                _projects.UpdateDetails(project);

                foreach (int documentId in removedDocumentIds ?? new List<int>())
                {
                    ProjectDocument old = _documents.GetById(documentId);
                    if (old == null || old.ProjectId != project.ProjectId) continue;
                    _documents.Delete(documentId);
                    TryDeleteFile(old.FilePath);
                }

                if (isResubmission)
                {
                    // The old comments stay, so the review history is kept.
                    _comments.Add(project.ProjectId, Session.CurrentUser.UserId, CommentTypes.Response, response.Trim());
                    _projects.UpdateStatus(project.ProjectId, ProjectStatus.UnderReview);
                }
            }

            // Copy the newly attached files and save them in project_documents.
            foreach (ProjectDocument document in documents.Where(d => d.IsNew))
            {
                string storedPath = CopyToDocumentsFolder(document.FilePath, project.ReferenceNo);
                _documents.Add(project.ProjectId, document.FileName, storedPath);
            }

            return null;
        }

        public string Archive(int projectId)
        {
            Project p = _projects.GetById(projectId);
            if (!CanArchive(p)) return "Only approved or rejected projects can be archived, by a manager or administrator.";
            if (p.IsArchived) return "This project is already archived.";
            _projects.SetArchived(projectId, true);
            return null;
        }

        public string Restore(int projectId)
        {
            Project p = _projects.GetById(projectId);
            if (p == null || !Session.IsManagerOrAdmin) return "Only a manager or administrator can restore projects.";
            if (!p.IsArchived) return "This project is not archived.";
            _projects.SetArchived(projectId, false);
            return null;
        }

        // ---------- Delete ----------

        public string Delete(int projectId)
        {
            Project p = _projects.GetById(projectId);
            if (p == null) return "The project no longer exists.";
            if (!CanDelete(p))
                return "You can delete a project only while it is Received and no reviewer is assigned.";

            List<ProjectDocument> files = _documents.GetByProject(projectId);
            _projects.Delete(projectId); // also deletes its documents and comments
            foreach (ProjectDocument file in files)
            {
                TryDeleteFile(file.FilePath);
            }
            return null;
        }

        // ---------- File helpers ----------

        private static string CopyToDocumentsFolder(string sourcePath, string referenceNo)
        {
            string folder = Path.Combine(DocumentsRoot, referenceNo);
            Directory.CreateDirectory(folder);

            string fileName = Path.GetFileName(sourcePath);
            string target = Path.Combine(folder, fileName);
            if (File.Exists(target))
            {
                target = Path.Combine(folder, DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + fileName);
            }
            File.Copy(sourcePath, target);
            return target;
        }

        private static void TryDeleteFile(string path)
        {
            try
            {
                if (File.Exists(path)) File.Delete(path);
            }
            catch (IOException)
            {
                // The file is open somewhere else; the database row is already gone, so ignore it.
            }
        }
    }
}
