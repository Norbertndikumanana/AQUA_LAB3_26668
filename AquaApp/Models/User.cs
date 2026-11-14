using System.ComponentModel;

namespace AquaApp.Models
{
    /// <summary>A user account. Mapped to the "users" table by UserMap.</summary>
    public class User
    {
        [Browsable(false)]
        public virtual int UserId { get; set; }

        [DisplayName("Full name")]
        public virtual string FullName { get; set; }

        public virtual string Email { get; set; }

        public virtual string Role { get; set; }

        [DisplayName("Organization")]
        public virtual string OrganizationName { get; set; }

        public virtual string Phone { get; set; }

        [DisplayName("Active")]
        public virtual bool IsActive { get; set; }

        [DisplayName("Created")]
        public virtual DateTime CreatedAt { get; set; }

        [Browsable(false)]
        public virtual string PasswordHash { get; set; }

        // Shown in combo boxes (for example the reviewer list).
        public override string ToString() => FullName;
    }
}
