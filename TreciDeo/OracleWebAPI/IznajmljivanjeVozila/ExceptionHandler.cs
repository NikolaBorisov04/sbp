using System;
using System.Windows.Forms;

namespace FluentNHibernateTemplate;

public static class ExceptionHandler
{
    public static void HandleWinForms(Exception ex)
    {
        string message = ex.Message;
        if (ex.InnerException != null)
        {
            message += $"\nDetalji: {ex.InnerException.Message}";
        }

        MessageBox.Show(message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
