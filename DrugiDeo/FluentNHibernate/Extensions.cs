namespace FluentNHibernateTemplate;

public static class Extensions
{
    /// <summary>
    /// Formats nested exception messages so Oracle/NHibernate errors are easier to read.
    /// </summary>
    public static string FormatExceptionMessage(this Exception ex)
    {
        StringBuilder sb = new();
        Exception? current = ex;
        int indent = 0;

        while (current != null)
        {
            if (indent > 0)
                sb.Append($"{'-'.Repeat(indent)}> ");

            sb.AppendLine(current.Message);
            indent += 2;
            current = current.InnerException;
        }

        return sb.ToString();
    }

    public static string Repeat(this char c, int count)
    {
        return new string(c, count);
    }
}
