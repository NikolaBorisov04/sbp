namespace FluentNHibernateTemplate.Entiteti;

public class Oprema
{
    public virtual int Id { get; protected set; }

    public virtual required string Naziv { get; set; }

    public virtual string? Opis { get; set; }
}