namespace FluentNHibernateTemplate.Entiteti;

public class TipKoriscenja
{
    public virtual int Id { get; protected set; }

    public virtual required string Naziv { get; set; }
}