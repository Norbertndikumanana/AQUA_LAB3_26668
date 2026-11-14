namespace AquaApp.Models
{
    /// <summary>The four user roles stored in Users.Role.</summary>
    public static class Roles
    {
        public const string Organization = "Organization";
        public const string Reviewer = "Reviewer";
        public const string Manager = "Manager";
        public const string Admin = "Admin";
    }

    /// <summary>The project statuses stored in Projects.Status.</summary>
    public static class ProjectStatus
    {
        public const string Received = "Received";
        public const string UnderReview = "Under Review";
        public const string InfoRequested = "Information Requested";
        public const string Approved = "Approved";
        public const string Rejected = "Rejected";

        public static readonly string[] All =
        {
            Received, UnderReview, InfoRequested, Approved, Rejected
        };
    }

    /// <summary>The comment types stored in ReviewComments.Type.</summary>
    public static class CommentTypes
    {
        public const string Comment = "Comment";
        public const string InfoRequest = "Info Request";
        public const string Response = "Response";
        public const string Decision = "Decision";
    }
}
