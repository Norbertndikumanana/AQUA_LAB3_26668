using AquaApp.Models;

namespace AquaApp
{
    /// <summary>Remembers who is logged in while the app is open.</summary>
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsOrganization => CurrentUser?.Role == Roles.Organization;
        public static bool IsReviewer => CurrentUser?.Role == Roles.Reviewer;
        public static bool IsManager => CurrentUser?.Role == Roles.Manager;
        public static bool IsAdmin => CurrentUser?.Role == Roles.Admin;

        /// <summary>Managers and admins can assign, decide and archive.</summary>
        public static bool IsManagerOrAdmin => IsManager || IsAdmin;

        public static void Logout() => CurrentUser = null;
    }
}
