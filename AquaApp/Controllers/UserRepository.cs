using AquaApp.Models;
using NHibernate.Linq;

namespace AquaApp.Controllers
{
    public class UserRepository
    {
        // ---------- Read ----------

        public User GetById(int id)
        {
            return NHibernateHelper.Read(s => s.Get<User>(id));
        }

        public User GetByEmail(string email)
        {
            string value = (email ?? "").Trim().ToLower();
            return NHibernateHelper.Read(s => s.Query<User>().FirstOrDefault(u => u.Email.ToLower() == value));
        }

        public List<User> Search(string text)
        {
            string t = (text ?? "").Trim().ToLower();
            return NHibernateHelper.Read(s =>
            {
                IQueryable<User> query = s.Query<User>();
                if (t != "")
                {
                    query = query.Where(u => u.FullName.ToLower().Contains(t)
                                          || u.Email.ToLower().Contains(t)
                                          || u.OrganizationName.ToLower().Contains(t)
                                          || u.Role.ToLower().Contains(t));
                }
                return query.OrderBy(u => u.FullName).ToList();
            });
        }

        public List<User> GetActiveByRole(string role)
        {
            return NHibernateHelper.Read(s =>
                s.Query<User>().Where(u => u.Role == role && u.IsActive).OrderBy(u => u.FullName).ToList());
        }

        public bool EmailExists(string email, int excludeUserId)
        {
            string value = (email ?? "").Trim().ToLower();
            return NHibernateHelper.Read(s =>
                s.Query<User>().Any(u => u.Email.ToLower() == value && u.UserId != excludeUserId));
        }

        /// <summary>True when the user owns projects, reviews projects or wrote comments.</summary>
        public bool HasActivity(int userId)
        {
            return NHibernateHelper.Read(s =>
                s.Query<Project>().Any(p => p.Organization.UserId == userId || p.Reviewer.UserId == userId)
                || s.Query<ReviewComment>().Any(c => c.Author.UserId == userId));
        }

        // ---------- Create ----------

        public int Add(User user)
        {
            user.CreatedAt = DateTime.Now;
            NHibernateHelper.Write(s => s.Save(user));
            return user.UserId;
        }

        // ---------- Update ----------

        /// <summary>Updates the details. The password is not changed here (see UpdatePassword).</summary>
        public void Update(User user)
        {
            NHibernateHelper.Write(s =>
            {
                User saved = s.Get<User>(user.UserId);
                saved.FullName = user.FullName;
                saved.Email = user.Email;
                saved.Role = user.Role;
                saved.OrganizationName = user.OrganizationName;
                saved.Phone = user.Phone;
                saved.IsActive = user.IsActive;
            });
        }

        public void UpdatePassword(int userId, string passwordHash)
        {
            NHibernateHelper.Write(s => s.Get<User>(userId).PasswordHash = passwordHash);
        }

        // ---------- Delete ----------

        public void Delete(int userId)
        {
            NHibernateHelper.Write(s => s.Delete(s.Get<User>(userId)));
        }
    }
}
