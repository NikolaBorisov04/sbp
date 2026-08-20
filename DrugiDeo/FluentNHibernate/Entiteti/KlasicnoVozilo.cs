namespace FluentNHibernateTemplate.Entiteti;

public class KlasicnoVozilo : Vozilo
{
    public virtual string TipGoriva { get; set; } = null!;

    public virtual decimal ZapreminaRezervoara { get; set; }

    public virtual decimal ProsecnaPotrosnja { get; set; }
}
