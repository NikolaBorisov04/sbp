namespace FluentNHibernateTemplate.Entiteti;

public class HibridnoVozilo : Vozilo
{
    public virtual decimal KapacitetBaterije { get; set; }

    public virtual string TipHibridnogPogona { get; set; } = null!;
}
