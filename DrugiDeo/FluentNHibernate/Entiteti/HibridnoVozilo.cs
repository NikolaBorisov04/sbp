namespace FluentNHibernateTemplate.Entiteti;

public class HibridnoVozilo : Vozilo
{
    public virtual decimal KapacitetBaterije { get; set; }

    public virtual required string TipHibridnogPogona { get; set; }
}