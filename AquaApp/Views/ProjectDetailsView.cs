using AquaApp.Controllers;
using AquaApp.Models;

namespace AquaApp.Views
{
    /// <summary>Read-only view of one project: details, documents and review history.</summary>
    public partial class ProjectDetailsView : Form
    {
        private readonly ProjectController _projects = new ProjectController();
        private readonly int _projectId;

        public ProjectDetailsView(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
        }

        private void ProjectDetailsView_Load(object sender, EventArgs e)
        {
            Project p = _projects.GetProject(_projectId);
            if (!_projects.CanView(p))
            {
                Ui.Error("You cannot view this project.");
                grpInfo.Enabled = false;
                grpDocuments.Enabled = false;
                return;
            }

            lblHeading.Text = "Project " + p.ReferenceNo;
            lblRefValue.Text = p.ReferenceNo;
            lblStatusValue.Text = p.Status + (p.IsArchived ? " (archived)" : "");
            lblStatusValue.ForeColor = StatusColor(p.Status);
            lblTitleValue.Text = p.Title;
            lblCategoryValue.Text = p.CategoryName;
            lblBudgetValue.Text = p.Budget.ToString("N0");
            lblLocationValue.Text = p.Location;
            lblOrgValue.Text = p.OrganizationName;
            lblReviewerValue.Text = p.ReviewerName ?? "Not assigned";
            lblSubmittedValue.Text = p.SubmittedAt.ToString("dd MMM yyyy HH:mm");
            txtDescription.Text = p.Description;
            lblDecision.Text = string.IsNullOrEmpty(p.DecisionReason)
                ? "Decision: none yet"
                : $"Decision ({p.Status}): {p.DecisionReason}";

            dgvDocuments.DataSource = _projects.GetDocuments(_projectId);
            dgvHistory.DataSource = _projects.GetHistory(_projectId);
        }

        public static Color StatusColor(string status)
        {
            switch (status)
            {
                case ProjectStatus.Approved: return Color.SeaGreen;
                case ProjectStatus.Rejected: return Color.Firebrick;
                case ProjectStatus.InfoRequested: return Color.DarkOrange;
                case ProjectStatus.UnderReview: return Color.SteelBlue;
                default: return Color.Black;
            }
        }

        private void dgvDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnOpenFile_Click(sender, e);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Ui.Ok(_projects.OpenDocument(dgvDocuments.CurrentRow?.DataBoundItem as ProjectDocument));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
