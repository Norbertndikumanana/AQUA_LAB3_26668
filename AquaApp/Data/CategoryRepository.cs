using AquaApp.Models;
using NHibernate.Linq;

namespace AquaApp.Data
{
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            return NHibernateHelper.Read(s => s.Query<Category>().OrderBy(c => c.Name).ToList());
        }

        public bool NameExists(string name, int excludeId)
        {
            string value = (name ?? "").Trim().ToLower();
            return NHibernateHelper.Read(s =>
                s.Query<Category>().Any(c => c.Name.ToLower() == value && c.CategoryId != excludeId));
        }

        public bool IsInUse(int categoryId)
        {
            return NHibernateHelper.Read(s => s.Query<Project>().Any(p => p.Category.CategoryId == categoryId));
        }

        public void Add(Category category)
        {
            NHibernateHelper.Write(s => s.Save(category));
        }

        public void Update(Category category)
        {
            NHibernateHelper.Write(s =>
            {
                Category saved = s.Get<Category>(category.CategoryId);
                saved.Name = category.Name;
                saved.Description = category.Description;
            });
        }

        public void Delete(int categoryId)
        {
            NHibernateHelper.Write(s => s.Delete(s.Get<Category>(categoryId)));
        }
    }
}
