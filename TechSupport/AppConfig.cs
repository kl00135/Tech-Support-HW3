namespace TechSupport
{
    /// <summary>
    /// Stores app-wide config values. Gives all forms access to ConnectionString.
    /// </summary>
    public static class AppConfig
    {
        public const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSupport;Integrated Security=True";
    }
}
