using System.ComponentModel;

namespace AquaApp.Models
{
    /// <summary>A project category. Mapped to the "categories" table by CategoryMap.</summary>
    public class Category
    {
        [DisplayName("ID")]
        public virtual int CategoryId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        // Shown in combo boxes.
        public override string ToString() => Name;
    }
}
