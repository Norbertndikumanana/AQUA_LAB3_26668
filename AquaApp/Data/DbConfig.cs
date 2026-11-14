namespace AquaApp.Data
{
    /// <summary>PostgreSQL connection settings. Change them here if your server is different.</summary>
    public static class DbConfig
    {
        public const string Host = "localhost";
        public const int Port = 5432;
        public const string Database = "auca1";
        public const string Username = "postgres";
        public const string Password = "p@ssword2025";

        public static string ConnectionString =>
            $"Host={Host};Port={Port};Database={Database};Username={Username};Password={Password}";
    }
}
