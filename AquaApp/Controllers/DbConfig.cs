using System.Text.Json;

namespace AquaApp.Controllers
{
    /// <summary>
    /// PostgreSQL connection settings. Nothing secret is stored in the source code.
    /// Values are read, in this order, from:
    ///   1. environment variables (AQUA_DB_HOST, AQUA_DB_PORT, AQUA_DB_NAME, AQUA_DB_USER, AQUA_DB_PASSWORD)
    ///   2. the local file dbsettings.local.json (ignored by git; copy dbsettings.example.json)
    ///   3. defaults for everything except the password
    /// </summary>
    public static class DbConfig
    {
        private const string LocalFile = "dbsettings.local.json";

        private static readonly Dictionary<string, string> FileValues = LoadFile();

        public static string Host => Get("AQUA_DB_HOST", "Host", "localhost");
        public static int Port => int.TryParse(Get("AQUA_DB_PORT", "Port", "5432"), out int p) ? p : 5432;
        public static string Database => Get("AQUA_DB_NAME", "Database", "auca1");
        public static string Username => Get("AQUA_DB_USER", "Username", "postgres");
        public static string Password => Get("AQUA_DB_PASSWORD", "Password", null)
            ?? throw new InvalidOperationException(
                "The database password is not set. Set the AQUA_DB_PASSWORD environment variable, " +
                "or copy dbsettings.example.json to dbsettings.local.json and fill in your password.");

        public static string ConnectionString =>
            $"Host={Host};Port={Port};Database={Database};Username={Username};Password={Password}";

        private static string Get(string envName, string fileKey, string fallback)
        {
            string env = Environment.GetEnvironmentVariable(envName);
            if (!string.IsNullOrEmpty(env)) return env;
            if (FileValues.TryGetValue(fileKey, out string value) && !string.IsNullOrEmpty(value)) return value;
            return fallback;
        }

        private static Dictionary<string, string> LoadFile()
        {
            var values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            string path = Path.Combine(AppContext.BaseDirectory, LocalFile);
            if (!File.Exists(path)) return values;

            using var doc = JsonDocument.Parse(File.ReadAllText(path));
            foreach (var property in doc.RootElement.EnumerateObject())
                values[property.Name] = property.Value.ToString();
            return values;
        }
    }
}
