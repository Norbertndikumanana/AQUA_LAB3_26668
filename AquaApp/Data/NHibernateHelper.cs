using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using Npgsql;

namespace AquaApp.Data
{
    /// <summary>
    /// Builds the NHibernate session factory once, creates the tables automatically
    /// when they do not exist, and opens sessions for the repositories.
    /// </summary>
    public static class NHibernateHelper
    {
        private static ISessionFactory _factory;

        public static void Initialize()
        {
            if (_factory != null) return;

            var configuration = new Configuration();
            configuration.DataBaseIntegration(db =>
            {
                db.Dialect<PostgreSQL83Dialect>();
                db.Driver<NpgsqlDriver>();
                db.ConnectionString = DbConfig.ConnectionString;
                db.LogSqlInConsole = false;
            });

            var mapper = new ModelMapper();
            mapper.AddMapping<UserMap>();
            mapper.AddMapping<CategoryMap>();
            mapper.AddMapping<ProjectMap>();
            mapper.AddMapping<ProjectDocumentMap>();
            mapper.AddMapping<ReviewCommentMap>();
            configuration.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

            // Create all tables, keys and foreign keys the first time the app runs.
            if (!TablesExist())
            {
                new SchemaExport(configuration).Create(false, true);
            }

            _factory = configuration.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            if (_factory == null) Initialize();
            return _factory.OpenSession();
        }

        /// <summary>Runs a read-only piece of work in its own session.</summary>
        public static T Read<T>(Func<ISession, T> work)
        {
            using ISession session = OpenSession();
            return work(session);
        }

        /// <summary>Runs a change (insert, update, delete) in a session and a transaction.</summary>
        public static void Write(Action<ISession> work)
        {
            using ISession session = OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            work(session);
            transaction.Commit();
        }

        private static bool TablesExist()
        {
            using var connection = new NpgsqlConnection(DbConfig.ConnectionString);
            connection.Open();
            using var command = new NpgsqlCommand(
                "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'public' AND table_name = 'users'",
                connection);
            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }
    }
}
