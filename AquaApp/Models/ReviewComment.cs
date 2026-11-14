using System.ComponentModel;

namespace AquaApp.Models
{
    /// <summary>
    /// A comment, information request, response or decision on a project.
    /// Mapped to "review_comments" by ReviewCommentMap.
    /// </summary>
    public class ReviewComment
    {
        [Browsable(false)]
        public virtual int CommentId { get; set; }

        [DisplayName("Date")]
        public virtual DateTime CreatedAt { get; set; }

        [DisplayName("By")]
        public virtual string AuthorName => Author?.FullName;

        public virtual string Type { get; set; }

        [DisplayName("Comment")]
        public virtual string Text { get; set; }

        [Browsable(false)]
        public virtual Project Project { get; set; }

        [Browsable(false)]
        public virtual User Author { get; set; }

        [Browsable(false)]
        public virtual int ProjectId => Project?.ProjectId ?? 0;

        [Browsable(false)]
        public virtual int UserId => Author?.UserId ?? 0;
    }
}
