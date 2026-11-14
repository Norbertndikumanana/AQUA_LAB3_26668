using AquaApp.Controllers;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Views
{
    /// <summary>The logged-in user updates their own details and password.</summary>
    public partial class ProfileView : Form
    {
        private readonly AuthController _auth = new AuthController();

        public ProfileView()
        {
            InitializeComponent();
        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            User me = Session.CurrentUser;
            txtEmail.Text = me.Email;
            txtFullName.Text = me.FullName;
            txtOrganization.Text = me.OrganizationName;
            txtPhone.Text = me.Phone;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (!Ui.Ok(_auth.UpdateProfile(txtFullName.Text, txtOrganization.Text, txtPhone.Text))) return;
            Ui.Info("Your profile was saved.");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!Ui.Ok(_auth.ChangePassword(txtCurrent.Text, txtNew.Text, txtConfirm.Text))) return;
            txtCurrent.Clear();
            txtNew.Clear();
            txtConfirm.Clear();
            Ui.Info("Your password was changed.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
