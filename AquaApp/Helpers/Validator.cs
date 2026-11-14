using System.Text.RegularExpressions;

namespace AquaApp.Helpers
{
    public static class Validator
    {
        public static bool IsEmpty(string value) => string.IsNullOrWhiteSpace(value);

        public static bool IsEmail(string value)
        {
            return !IsEmpty(value) && Regex.IsMatch(value.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsPhone(string value)
        {
            return IsEmpty(value) || Regex.IsMatch(value.Trim(), @"^\+?[0-9 ]{9,15}$");
        }

        /// <summary>Returns an error message, or null when the password is strong enough.</summary>
        public static string CheckPassword(string password, string confirm)
        {
            if (IsEmpty(password)) return "Enter a password.";
            if (password.Length < 8) return "The password must have at least 8 characters.";
            if (!password.Any(char.IsDigit)) return "The password must contain at least one number.";
            if (!password.Any(char.IsLetter)) return "The password must contain at least one letter.";
            if (password != confirm) return "The passwords do not match.";
            return null;
        }
    }
}
