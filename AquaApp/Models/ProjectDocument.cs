using System.ComponentModel;

namespace AquaApp.Models
{
    /// <summary>A file attached to a project. Mapped to "project_documents" by ProjectDocumentMap.</summary>
    public class ProjectDocument
    {
        [Browsable(false)]
        public virtual int DocumentId { get; set; }

        [DisplayName("File")]
        public virtual string FileName { get; set; }

        [DisplayName("Uploaded")]
        public virtual DateTime UploadedAt { get; set; }

        /// <summary>
        /// For a saved document: where the copy is stored.
        /// For a new document that is not saved yet: the file the user picked.
        /// </summary>
        [Browsable(false)]
        public virtual string FilePath { get; set; }

        [Browsable(false)]
        public virtual Project Project { get; set; }

        [Browsable(false)]
        public virtual int ProjectId => Project?.ProjectId ?? 0;

        [Browsable(false)]
        public virtual bool IsNew => DocumentId == 0;
    }
}
