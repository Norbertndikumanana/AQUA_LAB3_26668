using AquaApp.Data;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Controllers
{
    /// <summary>
    /// Login, sign up and the logged-in user's own profile.
    /// Methods return an error message, or null when everything worked.
    /// </summary>
    public class AuthController
    {
        private readonly UserRepository _users = new UserRepository();

        public string Login(string email, string password)
        {
            if (Validator.IsEmpty(email) || Validator.IsEmpty(password))
                return "Enter your email and password.";

            User user = _users.GetByEmail(email.Trim());
            if (user == null || !PasswordHasher.Verify(password, user.PasswordHash))
                return "The email or password is incorrect.";

            if (!user.IsActive)
                return "This account is deactivated. Contact the administrator.";

            Session.CurrentUser = user;
            return null;
        }

        /// <summary>Sign up creates an Organization account.</summary>
        public string Register(string fullName, string organizationName, string email, string phone,
                               string password, string confirmPassword)
        {
            if (Validator.IsEmpty(fullName)) return "Enter your full name.";
            if (Validator.IsEmpty(organizationName)) return "Enter the organization name.";
            if (!Validator.IsEmail(email)) return "Enter a valid email address.";
            if (!Validator.IsPhone(phone)) return "Enter a valid phone number (9 to 15 digits).";

            string passwordError = Validator.CheckPassword(password, confirmPassword);
            if (passwordError != null) return passwordError;

            if (_users.EmailExists(email.Trim(), 0))
                return "An account with this email already exists.";

            _users.Add(new User
            {
                FullName = fullName.Trim(),
                OrganizationName = organizationName.Trim(),
                Email = email.Trim(),
                Phone = phone?.Trim(),
                Role = Roles.Organization,
                IsActive = true,
                PasswordHash = PasswordHasher.Hash(password)
            });
            return null;
        }

        public string UpdateProfile(string fullName, string organizationName, string phone)
        {
            User me = Session.CurrentUser;
            if (Validator.IsEmpty(fullName)) return "Enter your full name.";
            if (me.Role == Roles.Organization && Validator.IsEmpty(organizationName))
                return "Enter the organization name.";
            if (!Validator.IsPhone(phone)) return "Enter a valid phone number (9 to 15 digits).";

            me.FullName = fullName.Trim();
            me.OrganizationName = Validator.IsEmpty(organizationName) ? null : organizationName.Trim();
            me.Phone = phone?.Trim();
            _users.Update(me);
            return null;
        }

        public string ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            User me = _users.GetById(Session.CurrentUser.UserId);
            if (!PasswordHasher.Verify(currentPassword, me.PasswordHash))
                return "The current password is incorrect.";

            string passwordError = Validator.CheckPassword(newPassword, confirmPassword);
            if (passwordError != null) return passwordError;

            string hash = PasswordHasher.Hash(newPassword);
            _users.UpdatePassword(me.UserId, hash);
            Session.CurrentUser.PasswordHash = hash;
            return null;
        }

        public void Logout() => Session.Logout();
    }
}
