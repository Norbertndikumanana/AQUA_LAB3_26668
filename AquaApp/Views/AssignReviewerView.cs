using AquaApp.Controllers;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Views
{
    /// <summary>Manager / Admin: assign, reassign or remove the reviewer of a project.</summary>
    public partial class AssignReviewerView : Form
    {
        private readonly ReviewController _review = new ReviewController();
        private List<User> _reviewers = new List<User>();

        public AssignReviewerView()
        {
            InitializeComponent();
        }

        private Project SelectedProject => dgvProjects.CurrentRow?.DataBoundItem as Project;

        private void AssignReviewerView_Load(object sender, EventArgs e)
        {
            if (!Session.IsManagerOrAdmin)
            {
                Ui.Error("Only a manager or administrator can assign reviewers.");
                Enabled = false;
                return;
            }

            _reviewers = _review.GetReviewers();
            cboReviewer.DataSource = _reviewers;
            if (_reviewers.Count == 0)
                Ui.Info("There are no active reviewers yet. An administrator can add one in Users.");

            LoadProjects();
        }

        private void LoadProjects()
        {
            dgvProjects.DataSource = _review.GetAssignableProjects();
            ShowSelectedReviewer();
        }

        private void ShowSelectedReviewer()
        {
            Project p = SelectedProject;
            if (p?.ReviewerId != null)
            {
                User current = _reviewers.FirstOrDefault(r => r.UserId == p.ReviewerId);
                if (current != null) cboReviewer.SelectedItem = current;
            }
            btnRemoveReviewer.Enabled = p?.ReviewerId != null;
        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowSelectedReviewer();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (p == null)
            {
                Ui.Error("Select a project first.");
                return;
            }
            if (!Ui.Ok(_review.AssignReviewer(p.ProjectId, cboReviewer.SelectedItem as User))) return;
            Ui.Info($"Project {p.ReferenceNo} is now assigned to {cboReviewer.Text}.");
            LoadProjects();
        }

        private void btnRemoveReviewer_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (p == null || !Ui.Confirm($"Remove the reviewer from {p.ReferenceNo}?")) return;
            if (Ui.Ok(_review.RemoveReviewer(p.ProjectId))) LoadProjects();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
