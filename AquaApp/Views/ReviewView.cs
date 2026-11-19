using AquaApp.Controllers;
using AquaApp.Models;

namespace AquaApp.Views
{
    /// <summary>
    /// Review one project: read it, open its documents, add / edit / delete comments,
    /// request more information, and (manager or admin) approve or reject it.
    /// </summary>
    public partial class ReviewView : Form
    {
        private readonly ProjectController _projects = new ProjectController();
        private readonly ReviewController _review = new ReviewController();
        private readonly int _projectId;
        private Project _project;

        public ReviewView(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
        }

        private ReviewComment SelectedComment => dgvComments.CurrentRow?.DataBoundItem as ReviewComment;

        private void ReviewView_Load(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void LoadProject()
        {
            _project = _projects.GetProject(_projectId);
            if (_project == null)
            {
                Ui.Error("This project no longer exists.");
                Enabled = false;
                return;
            }

            lblHeading.Text = "Review project " + _project.ReferenceNo;
            lblRefValue.Text = _project.ReferenceNo;
            lblTitleValue.Text = _project.Title;
            lblOrgValue.Text = _project.OrganizationName;
            lblStatusValue.Text = _project.Status;
            lblStatusValue.ForeColor = ProjectDetailsView.StatusColor(_project.Status);
            lblReviewerValue.Text = _project.ReviewerName ?? "Not assigned";
            txtDescription.Text = _project.Description;

            dgvDocuments.DataSource = _projects.GetDocuments(_projectId);
            LoadComments();
        }

        private void LoadComments()
        {
            dgvComments.DataSource = _review.GetComments(_projectId);
            dgvComments.ClearSelection();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            bool canReview = _review.CanReview(_project);
            bool canDecide = _review.CanDecide(_project);
            ReviewComment selected = dgvComments.SelectedRows.Count > 0 ? SelectedComment : null;

            btnAddComment.Enabled = canReview;
            btnEditComment.Enabled = _review.CanChangeComment(selected);
            btnDeleteComment.Enabled = _review.CanChangeComment(selected);
            btnRequestInfo.Enabled = canReview && _project.Status == ProjectStatus.UnderReview;
            txtReason.Enabled = canDecide;
            btnApprove.Enabled = canDecide;
            btnReject.Enabled = canDecide;
        }

        // ---------- Documents ----------

        private void dgvDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnOpenFile_Click(sender, e);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Ui.Ok(_projects.OpenDocument(dgvDocuments.CurrentRow?.DataBoundItem as ProjectDocument));
        }

        // ---------- Comments ----------

        private void dgvComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReviewComment comment = SelectedComment;
            if (_review.CanChangeComment(comment)) txtComment.Text = comment.Text;
            UpdateButtons();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (!Ui.Ok(_review.AddComment(_projectId, txtComment.Text))) return;
            txtComment.Clear();
            LoadComments();
        }

        private void btnEditComment_Click(object sender, EventArgs e)
        {
            ReviewComment comment = SelectedComment;
            if (comment == null) return;
            if (!Ui.Ok(_review.UpdateComment(comment.CommentId, txtComment.Text))) return;
            txtComment.Clear();
            LoadComments();
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            ReviewComment comment = SelectedComment;
            if (comment == null || !Ui.Confirm("Delete this comment?")) return;
            if (!Ui.Ok(_review.DeleteComment(comment.CommentId))) return;
            txtComment.Clear();
            LoadComments();
        }

        // ---------- Review actions ----------

        private void btnRequestInfo_Click(object sender, EventArgs e)
        {
            if (!Ui.Confirm("Send this request to the organization? The project status becomes Information Requested.")) return;
            if (!Ui.Ok(_review.RequestInformation(_projectId, txtComment.Text))) return;
            txtComment.Clear();
            Ui.Info("The request was sent to the organization.");
            LoadProject();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!Ui.Confirm("Approve this project?")) return;
            if (!Ui.Ok(_review.Approve(_projectId, txtReason.Text))) return;
            txtReason.Clear();
            Ui.Info("The project was approved.");
            LoadProject();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (!Ui.Confirm("Reject this project?")) return;
            if (!Ui.Ok(_review.Reject(_projectId, txtReason.Text))) return;
            txtReason.Clear();
            Ui.Info("The project was rejected.");
            LoadProject();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
