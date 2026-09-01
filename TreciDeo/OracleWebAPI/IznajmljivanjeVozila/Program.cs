namespace FluentNHibernateTemplate;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += (sender, e) => ExceptionHandler.HandleWinForms(e.Exception);
        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            if (e.ExceptionObject is Exception ex)
            {
                ExceptionHandler.HandleWinForms(ex);
            }
        };

        Application.Run(new MainForm());
    }
}
