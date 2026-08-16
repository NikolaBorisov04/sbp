namespace FluentNHibernateTemplate.Entiteti;

public class TipServisa
{
    public virtual int Id { get; protected set; }

    public virtual required string Naziv { get; set; }
}