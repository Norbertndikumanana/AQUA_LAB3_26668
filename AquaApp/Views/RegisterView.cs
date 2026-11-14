using AquaApp.Controllers;
using AquaApp.Helpers;

namespace AquaApp.Views
{
    public partial class RegisterView : Form
    {
        private readonly AuthController _auth = new AuthController();

        /// <summary>The email of the new account, so the login screen can fill it in.</summary>
        public string RegisteredEmail { get; private set; }

        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string error = _auth.Register(txtFullName.Text, txtOrganization.Text, txtEmail.Text,
                                          txtPhone.Text, txtPassword.Text, txtConfirm.Text);
            if (!Ui.Ok(error)) return;

            Ui.Info("Your account was created. You can now log in.");
            RegisteredEmail = txtEmail.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtOrganization.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            txtFullName.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
