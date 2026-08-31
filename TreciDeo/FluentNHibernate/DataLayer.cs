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
            DotNetEnv.Env.Load();

            string? connectionString =
                Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            /*MessageBox.Show(
                connectionString ?? "CONNECTION STRING JE NULL",
                "Connection string"
            );*/

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
            MessageBox.Show(
                ex.ToString(),
                "Greska"
            );

            return null;
        }
    }
}
