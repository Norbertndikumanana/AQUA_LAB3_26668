using AquaApp.Data;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Controllers
{
    /// <summary>Full CRUD on users (Admin only).</summary>
    public class UserController
    {
        private readonly UserRepository _users = new UserRepository();

        public List<User> GetUsers(string search) => _users.Search(search?.Trim());

        public string Add(User user, string password)
        {
            if (!Session.IsAdmin) return "Only an administrator can add users.";
            string error = Validate(user, 0);
            if (error != null) return error;

            string passwordError = Validator.CheckPassword(password, password);
            if (passwordError != null) return passwordError;

            user.PasswordHash = PasswordHasher.Hash(password);
            _users.Add(user);
            return null;
        }

        /// <summary>Updates the user. If newPassword is filled in, the password is reset too.</summary>
        public string Update(User user, string newPassword)
        {
            if (!Session.IsAdmin) return "Only an administrator can change users.";
            if (user.UserId == 0) return "Select a user in the list first.";
            string error = Validate(user, user.UserId);
            if (error != null) return error;

            if (user.UserId == Session.CurrentUser.UserId && (!user.IsActive || user.Role != Roles.Admin))
                return "You cannot deactivate yourself or remove your own Admin role.";

            if (!Validator.IsEmpty(newPassword))
            {
                string passwordError = Validator.CheckPassword(newPassword, newPassword);
                if (passwordError != null) return passwordError;
                _users.UpdatePassword(user.UserId, PasswordHasher.Hash(newPassword));
            }

            _users.Update(user);
            return null;
        }

        public string Delete(int userId)
        {
            if (!Session.IsAdmin) return "Only an administrator can delete users.";
            if (userId == 0) return "Select a user in the list first.";
            if (userId == Session.CurrentUser.UserId) return "You cannot delete your own account.";
            if (_users.HasActivity(userId))
                return "This user has projects or comments, so they cannot be deleted. Untick Active to deactivate them instead.";

            _users.Delete(userId);
            return null;
        }

        private string Validate(User user, int userId)
        {
            if (Validator.IsEmpty(user.FullName)) return "Enter the full name.";
            if (!Validator.IsEmail(user.Email)) return "Enter a valid email address.";
            if (Validator.IsEmpty(user.Role)) return "Choose a role.";
            if (user.Role == Roles.Organization && Validator.IsEmpty(user.OrganizationName))
                return "Enter the organization name for an Organization account.";
            if (!Validator.IsPhone(user.Phone)) return "Enter a valid phone number (9 to 15 digits).";
            if (_users.EmailExists(user.Email.Trim(), userId)) return "Another account already uses this email.";

            user.FullName = user.FullName.Trim();
            user.Email = user.Email.Trim();
            user.OrganizationName = Validator.IsEmpty(user.OrganizationName) ? null : user.OrganizationName.Trim();
            user.Phone = user.Phone?.Trim();
            return null;
        }
    }
}
