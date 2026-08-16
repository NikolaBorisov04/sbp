namespace FluentNHibernateTemplate.Entiteti;

public class TipOdgovornosti
{
    public virtual int Id { get; protected set; }

    public virtual required string Naziv { get; set; }
}