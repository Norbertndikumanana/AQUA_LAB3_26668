using AquaApp.Controllers;
using AquaApp.Models;

namespace AquaApp.Views
{
    public partial class MainView : Form
    {
        private readonly ProjectController _projects = new ProjectController();
        private readonly AuthController _auth = new AuthController();

        /// <summary>True when the user pressed Logout (Program then shows the login screen again).</summary>
        public bool LoggedOut { get; private set; }

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // Show only the menu items this role may use.
            btnNewProject.Visible = Session.IsOrganization;
            btnAssign.Visible = Session.IsManagerOrAdmin;
            btnUsers.Visible = Session.IsAdmin;
            btnCategories.Visible = Session.IsAdmin;

            ShowWelcome();
            LoadDashboard();
        }

        private void ShowWelcome()
        {
            User me = Session.CurrentUser;
            lblWelcome.Text = "Welcome, " + me.FullName;
            lblRole.Text = me.Role == Roles.Organization
                ? "Organization: " + me.OrganizationName
                : "Role: " + me.Role;
        }

        private void LoadDashboard()
        {
            Dictionary<string, int> counts = _projects.GetStatusCounts();
            lblReceived.Text = counts[ProjectStatus.Received].ToString();
            lblUnderReview.Text = counts[ProjectStatus.UnderReview].ToString();
            lblInfoRequested.Text = counts[ProjectStatus.InfoRequested].ToString();
            lblApproved.Text = counts[ProjectStatus.Approved].ToString();
            lblRejected.Text = counts[ProjectStatus.Rejected].ToString();

            dgvRecent.DataSource = _projects.GetProjects(null, null, false).Take(15).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void dgvRecent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRecent.Rows[e.RowIndex].DataBoundItem is Project project)
            {
                using var details = new ProjectDetailsView(project.ProjectId);
                details.ShowDialog(this);
                LoadDashboard();
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            using var view = new ProjectListView();
            view.ShowDialog(this);
            LoadDashboard();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            using var view = new ProjectFormView(0);
            view.ShowDialog(this);
            LoadDashboard();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            using var view = new AssignReviewerView();
            view.ShowDialog(this);
            LoadDashboard();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            using var view = new UsersView();
            view.ShowDialog(this);
            LoadDashboard();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            using var view = new CategoriesView();
            view.ShowDialog(this);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            using var view = new ProfileView();
            view.ShowDialog(this);
            ShowWelcome();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (!Ui.Confirm("Do you want to log out?")) return;
            _auth.Logout();
            LoggedOut = true;
            Close();
        }
    }
}
