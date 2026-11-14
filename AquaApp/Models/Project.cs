using System.ComponentModel;

namespace AquaApp.Models
{
    /// <summary>
    /// One water-resource project. Mapped to the "projects" table by ProjectMap.
    /// The visible properties are, in order, the columns shown in the project grids.
    /// </summary>
    public class Project
    {
        [Browsable(false)]
        public virtual int ProjectId { get; set; }

        [DisplayName("Reference")]
        public virtual string ReferenceNo { get; set; }

        public virtual string Title { get; set; }

        [DisplayName("Category")]
        public virtual string CategoryName => Category?.Name;

        [DisplayName("Organization")]
        public virtual string OrganizationName =>
            Organization == null ? null : (Organization.OrganizationName ?? Organization.FullName);

        public virtual string Status { get; set; }

        [DisplayName("Reviewer")]
        public virtual string ReviewerName => Reviewer?.FullName;

        [DisplayName("Submitted")]
        public virtual DateTime SubmittedAt { get; set; }

        [DisplayName("Archived")]
        public virtual bool IsArchived { get; set; }

        // ---- Not shown in grids ----

        [Browsable(false)]
        public virtual string Description { get; set; }

        [Browsable(false)]
        public virtual string Location { get; set; }

        [Browsable(false)]
        public virtual decimal Budget { get; set; }

        [Browsable(false)]
        public virtual string DecisionReason { get; set; }

        [Browsable(false)]
        public virtual DateTime UpdatedAt { get; set; }

        // ---- Relationships (many-to-one, foreign keys in the database) ----

        [Browsable(false)]
        public virtual Category Category { get; set; }

        [Browsable(false)]
        public virtual User Organization { get; set; }

        [Browsable(false)]
        public virtual User Reviewer { get; set; }

        // ---- Shortcuts used by the controllers (not stored) ----

        [Browsable(false)]
        public virtual int CategoryId => Category?.CategoryId ?? 0;

        [Browsable(false)]
        public virtual int OrganizationId => Organization?.UserId ?? 0;

        [Browsable(false)]
        public virtual int? ReviewerId => Reviewer?.UserId;
    }
}
