using AquaApp.Controllers;
using AquaApp.Models;

namespace AquaApp.Views
{
    public partial class ProjectListView : Form
    {
        private readonly ProjectController _projects = new ProjectController();
        private readonly ReviewController _review = new ReviewController();

        public ProjectListView()
        {
            InitializeComponent();
        }

        private Project SelectedProject => dgvProjects.CurrentRow?.DataBoundItem as Project;

        private void ProjectListView_Load(object sender, EventArgs e)
        {
            // Show only the buttons this role may use.
            btnNew.Visible = Session.IsOrganization;
            btnEdit.Visible = Session.IsOrganization;
            btnReview.Visible = !Session.IsOrganization;
            btnArchive.Visible = Session.IsManagerOrAdmin;
            btnRestore.Visible = Session.IsManagerOrAdmin;
            btnDelete.Visible = Session.IsOrganization || Session.IsAdmin;

            if (Session.IsOrganization) lblHeading.Text = "My projects";
            if (Session.IsReviewer) lblHeading.Text = "Projects assigned to me";

            cboStatus.SelectedIndex = 0;
            LoadProjects();
        }

        private void LoadProjects()
        {
            string status = cboStatus.SelectedItem?.ToString();
            dgvProjects.DataSource = _projects.GetProjects(txtSearch.Text, status, chkShowArchived.Checked);
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            Project p = SelectedProject;
            btnEdit.Enabled = _projects.CanEdit(p);
            btnView.Enabled = p != null;
            btnReview.Enabled = _review.CanReview(p);
            btnArchive.Enabled = _projects.CanArchive(p) && !p.IsArchived;
            btnRestore.Enabled = p != null && p.IsArchived && Session.IsManagerOrAdmin;
            btnDelete.Enabled = _projects.CanDelete(p);
        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateButtons();
        }

        private void dgvProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnView_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboStatus.SelectedIndex = 0;
            chkShowArchived.Checked = false;
            LoadProjects();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using var form = new ProjectFormView(0);
            if (form.ShowDialog(this) == DialogResult.OK) LoadProjects();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (!_projects.CanEdit(p))
            {
                Ui.Error("You can edit a project only while it is Received or Information Requested.");
                return;
            }
            using var form = new ProjectFormView(p.ProjectId);
            if (form.ShowDialog(this) == DialogResult.OK) LoadProjects();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (p == null) return;
            using var details = new ProjectDetailsView(p.ProjectId);
            details.ShowDialog(this);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (!_review.CanReview(p))
            {
                Ui.Error("You cannot review this project.");
                return;
            }
            using var review = new ReviewView(p.ProjectId);
            review.ShowDialog(this);
            LoadProjects();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (p == null || !Ui.Confirm($"Archive project {p.ReferenceNo}? It stays available for reference.")) return;
            if (Ui.Ok(_projects.Archive(p.ProjectId))) LoadProjects();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (p == null) return;
            if (Ui.Ok(_projects.Restore(p.ProjectId))) LoadProjects();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Project p = SelectedProject;
            if (p == null) return;
            if (!Ui.Confirm($"Delete project {p.ReferenceNo} and all its documents? This cannot be undone.")) return;
            if (Ui.Ok(_projects.Delete(p.ProjectId))) LoadProjects();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
