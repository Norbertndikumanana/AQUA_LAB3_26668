using AquaApp.Data;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Controllers
{
    /// <summary>Full CRUD on project categories (Admin only).</summary>
    public class CategoryController
    {
        private readonly CategoryRepository _categories = new CategoryRepository();

        public List<Category> GetAll() => _categories.GetAll();

        public string Add(string name, string description)
        {
            if (!Session.IsAdmin) return "Only an administrator can add categories.";
            string error = Validate(name, 0);
            if (error != null) return error;

            _categories.Add(new Category { Name = name.Trim(), Description = description?.Trim() });
            return null;
        }

        public string Update(int categoryId, string name, string description)
        {
            if (!Session.IsAdmin) return "Only an administrator can change categories.";
            if (categoryId == 0) return "Select a category in the list first.";
            string error = Validate(name, categoryId);
            if (error != null) return error;

            _categories.Update(new Category { CategoryId = categoryId, Name = name.Trim(), Description = description?.Trim() });
            return null;
        }

        public string Delete(int categoryId)
        {
            if (!Session.IsAdmin) return "Only an administrator can delete categories.";
            if (categoryId == 0) return "Select a category in the list first.";
            if (_categories.IsInUse(categoryId)) return "This category is used by projects, so it cannot be deleted.";

            _categories.Delete(categoryId);
            return null;
        }

        private string Validate(string name, int categoryId)
        {
            if (Validator.IsEmpty(name)) return "Enter the category name.";
            if (_categories.NameExists(name.Trim(), categoryId)) return "A category with this name already exists.";
            return null;
        }
    }
}
