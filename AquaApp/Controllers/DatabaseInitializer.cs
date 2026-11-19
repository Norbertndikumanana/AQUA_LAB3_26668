using AquaApp.Models;
using NHibernate.Linq;
using Npgsql;

namespace AquaApp.Controllers
{
    /// <summary>
    /// Runs when the app starts:
    /// 1. creates the PostgreSQL database (auca1) if it does not exist,
    /// 2. lets NHibernate create the tables,
    /// 3. adds the test accounts and categories when the tables are empty.
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>Returns an error message, or null when the database is ready.</summary>
        public static string Initialize()
        {
            try
            {
                EnsureDatabaseExists();
                NHibernateHelper.Initialize();
                Seed();
                return null;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private static void EnsureDatabaseExists()
        {
            // Connect to the default "postgres" database to check for auca1.
            var builder = new NpgsqlConnectionStringBuilder(DbConfig.ConnectionString) { Database = "postgres" };
            using var connection = new NpgsqlConnection(builder.ConnectionString);
            connection.Open();

            using var check = new NpgsqlCommand("SELECT 1 FROM pg_database WHERE datname = @name", connection);
            check.Parameters.AddWithValue("name", DbConfig.Database);
            if (check.ExecuteScalar() != null) return;

            using var create = new NpgsqlCommand($"CREATE DATABASE \"{DbConfig.Database}\"", connection);
            create.ExecuteNonQuery();
        }

        private static void Seed()
        {
            NHibernateHelper.Write(session =>
            {
                if (!session.Query<User>().Any())
                {
                    AddUser(session, "System Administrator", "admin@aqua.test", "Admin@123", Roles.Admin, null, "0780000001");
                    AddUser(session, "Grace Manager", "manager@aqua.test", "Manager@123", Roles.Manager, null, "0780000002");
                    AddUser(session, "Eric Reviewer", "reviewer@aqua.test", "Reviewer@123", Roles.Reviewer, null, "0780000003");
                    AddUser(session, "Alice Uwase", "org@aqua.test", "Org@12345", Roles.Organization,
                            "Kigali Water Builders Ltd", "0780000004");
                }

                if (!session.Query<Category>().Any())
                {
                    AddCategory(session, "Water Supply", "Drinking water supply and distribution");
                    AddCategory(session, "Irrigation", "Irrigation schemes and agricultural water use");
                    AddCategory(session, "Dam and Reservoir", "Dams, reservoirs and water storage");
                    AddCategory(session, "Wastewater", "Wastewater collection and treatment");
                    AddCategory(session, "Catchment Protection", "Erosion control and catchment restoration");
                    AddCategory(session, "Flood Control", "Flood protection and drainage");
                }
            });
        }

        private static void AddUser(NHibernate.ISession session, string name, string email, string password,
                                    string role, string organization, string phone)
        {
            session.Save(new User
            {
                FullName = name,
                Email = email,
                PasswordHash = PasswordHasher.Hash(password),
                Role = role,
                OrganizationName = organization,
                Phone = phone,
                IsActive = true,
                CreatedAt = DateTime.Now
            });
        }

        private static void AddCategory(NHibernate.ISession session, string name, string description)
        {
            session.Save(new Category { Name = name, Description = description });
        }
    }
}
