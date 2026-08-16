namespace FluentNHibernateTemplate.Entiteti;

public class VoziloOprema
{
    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual Oprema Oprema { get; set; } = null!;

    public virtual bool IsDodatna { get; set; }
}