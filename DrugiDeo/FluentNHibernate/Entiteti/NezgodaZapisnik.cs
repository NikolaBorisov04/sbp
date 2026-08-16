namespace FluentNHibernateTemplate.Entiteti;

public class NezgodaZapisnik
{
    public virtual int Id { get; protected set; }

    public virtual NezgodaSteta NezgodaSteta { get; set; } = null!;

    public virtual required string ZapisnikUrl { get; set; }
}