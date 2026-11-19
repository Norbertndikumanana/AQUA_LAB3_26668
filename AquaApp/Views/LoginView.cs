using AquaApp.Controllers;

namespace AquaApp.Views
{
    public partial class LoginView : Form
    {
        private readonly AuthController _auth = new AuthController();

        public LoginView()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string error = _auth.Login(txtEmail.Text, txtPassword.Text);
            if (!Ui.Ok(error))
            {
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using var register = new RegisterView();
            if (register.ShowDialog(this) == DialogResult.OK)
            {
                txtEmail.Text = register.RegisteredEmail;
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
