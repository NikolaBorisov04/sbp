namespace FluentNHibernateTemplate.Entiteti;

public class NezgodaFotografija
{
    public virtual int Id { get; protected set; }

    public virtual NezgodaSteta NezgodaSteta { get; set; } = null!;

    public virtual required string FotografijaUrl { get; set; }
}