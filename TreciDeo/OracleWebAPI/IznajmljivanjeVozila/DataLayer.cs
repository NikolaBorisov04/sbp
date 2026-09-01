using FluentNHibernateTemplate.Mapiranja;

namespace FluentNHibernateTemplate;

public static class DataLayer
{
    private static ISessionFactory? factory;
    private static readonly object lockObj = new();

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
            string envPath = Path.Combine(AppContext.BaseDirectory, ".env");

            if (File.Exists(envPath))
            {
                DotNetEnv.Env.Load(envPath);
            }
            else
            {
                DotNetEnv.Env.Load();
            }

            string? connectionString =
                Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "DB_CONNECTION_STRING nije podešen. Proveri .env fajl.");
            }

            var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(connectionString);

            return Fluently.Configure()
                .Database(cfg)
                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<VoziloMapiranja>())
                .BuildSessionFactory();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString(), "Greska");
            return null;
        }
    }
}
