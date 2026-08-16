namespace FluentNHibernateTemplate.Entiteti;

public class KlasicnoVozilo : Vozilo
{
    public virtual required string TipGoriva { get; set; }

    public virtual decimal ZapreminaRezervoara { get; set; }

    public virtual decimal ProsecnaPotrosnja { get; set; }
}