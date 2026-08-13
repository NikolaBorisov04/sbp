namespace FluentNHibernateTemplate;

/// <summary>
/// Central place for creating NHibernate sessions.
/// Keep database configuration here; forms should not create their own SessionFactory.
/// </summary>
public static class DataLayer
{
    private static ISessionFactory? factory;
    private static readonly object lockObj = new();

    /// <summary>
    /// Gets a new NHibernate session. The SessionFactory is created only once.
    /// </summary>
    public static ISession? GetSession()
    {
        if (factory == null)
        {
            lock (lockObj)
            {
                if (factory == null)
                {
                    factory = CreateSessionFactory();
                }
            }
        }

        return factory?.OpenSession();
    }

    private static ISessionFactory? CreateSessionFactory()
    {
        try
        {
            var settings = ConfigurationManager.ConnectionStrings["OracleCS"];

            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
                throw new InvalidOperationException(
                    "Connection string 'OracleCS' nije pronađen u App.config fajlu.");

            var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c => c.Is(settings.ConnectionString));

            return Fluently.Configure()
                .Database(cfg)
                // MappingAssemblyMarker is intentionally empty. All project-specific
                // mappings will be discovered from this assembly automatically.
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MappingAssemblyMarker>())
                .BuildSessionFactory();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.FormatExceptionMessage(),
                "Greška pri povezivanju sa bazom",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return null;
        }
    }
}
