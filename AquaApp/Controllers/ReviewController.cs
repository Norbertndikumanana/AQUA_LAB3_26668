using AquaApp.Data;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Controllers
{
    /// <summary>
    /// Reviewer assignment, review comments, requests for more information,
    /// and the final approve or reject decision.
    /// </summary>
    public class ReviewController
    {
        private readonly ProjectRepository _projects = new ProjectRepository();
        private readonly CommentRepository _comments = new CommentRepository();
        private readonly UserRepository _users = new UserRepository();

        // ---------- Permission checks ----------

        /// <summary>Managers, admins and the assigned reviewer can work on a project that is not archived.</summary>
        public bool CanReview(Project p)
        {
            if (p == null || p.IsArchived) return false;
            if (Session.IsManagerOrAdmin) return true;
            return Session.IsReviewer && p.ReviewerId == Session.CurrentUser.UserId;
        }

        public bool CanDecide(Project p)
        {
            return p != null && !p.IsArchived && Session.IsManagerOrAdmin && p.Status == ProjectStatus.UnderReview;
        }

        public bool CanChangeComment(ReviewComment c)
        {
            return c != null && c.Type == CommentTypes.Comment && c.UserId == Session.CurrentUser.UserId;
        }

        // ---------- Assignment (Manager / Admin) ----------

        public List<Project> GetAssignableProjects() => _projects.GetAssignable();

        public List<User> GetReviewers() => _users.GetActiveByRole(Roles.Reviewer);

        public string AssignReviewer(int projectId, User reviewer)
        {
            if (!Session.IsManagerOrAdmin) return "Only a manager or administrator can assign reviewers.";
            if (reviewer == null) return "Choose a reviewer.";

            Project p = _projects.GetById(projectId);
            if (p == null) return "Select a project first.";
            if (p.IsArchived || (p.Status != ProjectStatus.Received && p.Status != ProjectStatus.UnderReview))
                return "Only projects that are Received or Under Review can be assigned.";

            _projects.SetReviewer(projectId, reviewer.UserId, ProjectStatus.UnderReview);
            _comments.Add(projectId, Session.CurrentUser.UserId, CommentTypes.Comment,
                "Assigned to reviewer " + reviewer.FullName + ".");
            return null;
        }

        public string RemoveReviewer(int projectId)
        {
            if (!Session.IsManagerOrAdmin) return "Only a manager or administrator can remove reviewers.";
            Project p = _projects.GetById(projectId);
            if (p == null) return "Select a project first.";
            if (p.ReviewerId == null) return "This project has no reviewer.";
            if (p.Status != ProjectStatus.UnderReview) return "A reviewer can only be removed while the project is Under Review.";

            _projects.SetReviewer(projectId, null, ProjectStatus.Received);
            return null;
        }

        // ---------- Comments (Create, Read, Update, Delete) ----------

        public List<ReviewComment> GetComments(int projectId) => _comments.GetByProject(projectId);

        public string AddComment(int projectId, string text)
        {
            Project p = _projects.GetById(projectId);
            if (!CanReview(p)) return "You cannot comment on this project.";
            if (Validator.IsEmpty(text)) return "Write a comment first.";

            _comments.Add(projectId, Session.CurrentUser.UserId, CommentTypes.Comment, text.Trim());
            return null;
        }

        public string UpdateComment(int commentId, string text)
        {
            ReviewComment c = _comments.GetById(commentId);
            if (!CanChangeComment(c)) return "You can only edit your own comments.";
            if (Validator.IsEmpty(text)) return "The comment cannot be empty.";

            _comments.UpdateText(commentId, text.Trim());
            return null;
        }

        public string DeleteComment(int commentId)
        {
            ReviewComment c = _comments.GetById(commentId);
            if (!CanChangeComment(c)) return "You can only delete your own comments.";

            _comments.Delete(commentId);
            return null;
        }

        // ---------- Request more information ----------

        public string RequestInformation(int projectId, string message)
        {
            Project p = _projects.GetById(projectId);
            if (!CanReview(p)) return "You cannot review this project.";
            if (p.Status != ProjectStatus.UnderReview)
                return "You can request information only while the project is Under Review.";
            if (Validator.IsEmpty(message)) return "Write what information is missing in the comment box.";

            _comments.Add(projectId, Session.CurrentUser.UserId, CommentTypes.InfoRequest, message.Trim());
            _projects.UpdateStatus(projectId, ProjectStatus.InfoRequested);
            return null;
        }

        // ---------- Decision ----------

        public string Approve(int projectId, string reason) => Decide(projectId, ProjectStatus.Approved, reason);

        public string Reject(int projectId, string reason) => Decide(projectId, ProjectStatus.Rejected, reason);

        private string Decide(int projectId, string newStatus, string reason)
        {
            Project p = _projects.GetById(projectId);
            if (!Session.IsManagerOrAdmin) return "Only a manager or administrator can approve or reject.";
            if (!CanDecide(p)) return "A decision can be made only while the project is Under Review.";
            if (Validator.IsEmpty(reason)) return "Write the reason for your decision.";

            _projects.SetDecision(projectId, newStatus, reason.Trim());
            _comments.Add(projectId, Session.CurrentUser.UserId, CommentTypes.Decision, newStatus + ": " + reason.Trim());
            return null;
        }
    }
}
