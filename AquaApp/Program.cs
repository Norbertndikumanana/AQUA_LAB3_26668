using AquaApp.Controllers;
using AquaApp.Views;

namespace AquaApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Any unexpected error is shown in a message box instead of closing the app.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) =>
                MessageBox.Show("Something went wrong:\n\n" + e.Exception.Message, "AQUA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Creates the auca1 database, the tables (NHibernate) and the test accounts if they are missing.
            string dbError = DatabaseInitializer.Initialize();
            if (dbError != null)
            {
                MessageBox.Show(
                    "Cannot connect to the PostgreSQL database.\n\n" +
                    "1. Check that PostgreSQL is running.\n" +
                    "2. Check the host, user name and password in dbsettings.local.json (or the AQUA_DB_* variables).\n\n" +
                    "Details: " + dbError,
                    "AQUA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Login -> Main window. Logout returns to the login screen.
            while (true)
            {
                using (var login = new LoginView())
                {
                    if (login.ShowDialog() != DialogResult.OK) return;
                }

                using (var main = new MainView())
                {
                    main.ShowDialog();
                    if (!main.LoggedOut) return;
                }
            }
        }
    }
}
