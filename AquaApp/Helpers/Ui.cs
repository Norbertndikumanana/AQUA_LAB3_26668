namespace AquaApp.Helpers
{
    /// <summary>Short helpers for message boxes, used by every view.</summary>
    public static class Ui
    {
        public static void Info(string message)
        {
            MessageBox.Show(message, "AQUA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string message)
        {
            MessageBox.Show(message, "AQUA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirm(string question)
        {
            return MessageBox.Show(question, "AQUA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Shows the error if there is one. Returns true when there was no error.</summary>
        public static bool Ok(string error)
        {
            if (error == null) return true;
            Error(error);
            return false;
        }
    }
}
