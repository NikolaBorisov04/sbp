namespace FluentNHibernateTemplate.Entiteti;

public class NezgodaFotografija
{
    public virtual int Id { get; set; }

    public virtual NezgodaSteta NezgodaSteta { get; set; } = null!;

    public virtual string FotografijaUrl { get; set; } = null!;
}
