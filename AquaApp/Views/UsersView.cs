using AquaApp.Controllers;
using AquaApp.Models;

namespace AquaApp.Views
{
    /// <summary>Admin: full CRUD on users.</summary>
    public partial class UsersView : Form
    {
        private readonly UserController _users = new UserController();
        private int _selectedUserId;

        public UsersView()
        {
            InitializeComponent();
        }

        private void UsersView_Load(object sender, EventArgs e)
        {
            if (!Session.IsAdmin)
            {
                Ui.Error("Only an administrator can manage users.");
                Enabled = false;
                return;
            }
            LoadUsers();
            ClearForm();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = _users.GetUsers(txtSearch.Text);
            dgvUsers.ClearSelection();
        }

        private User ReadForm()
        {
            return new User
            {
                UserId = _selectedUserId,
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Role = cboRole.SelectedItem?.ToString(),
                OrganizationName = txtOrganization.Text,
                Phone = txtPhone.Text,
                IsActive = chkActive.Checked
            };
        }

        private void ClearForm()
        {
            _selectedUserId = 0;
            txtFullName.Clear();
            txtEmail.Clear();
            cboRole.SelectedIndex = -1;
            txtOrganization.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            chkActive.Checked = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            dgvUsers.ClearSelection();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUsers.Rows[e.RowIndex].DataBoundItem is not User user) return;

            _selectedUserId = user.UserId;
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
            cboRole.SelectedItem = user.Role;
            txtOrganization.Text = user.OrganizationName;
            txtPhone.Text = user.Phone;
            txtPassword.Clear();
            chkActive.Checked = user.IsActive;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = ReadForm();
            user.UserId = 0;
            if (!Ui.Ok(_users.Add(user, txtPassword.Text))) return;
            Ui.Info("The user was added.");
            LoadUsers();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Ui.Ok(_users.Update(ReadForm(), txtPassword.Text))) return;
            Ui.Info("The user was updated.");
            LoadUsers();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0 || !Ui.Confirm("Delete this user?")) return;
            if (!Ui.Ok(_users.Delete(_selectedUserId))) return;
            LoadUsers();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
