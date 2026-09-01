namespace FluentNHibernateTemplate.Entiteti;

public class NezgodaZapisnik
{
    public virtual int Id { get; set; }

    public virtual NezgodaSteta NezgodaSteta { get; set; } = null!;

    public virtual string ZapisnikUrl { get; set; } = null!;
}
