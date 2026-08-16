namespace FluentNHibernateTemplate.Entiteti;

public class PunjenjeTocenje
{
    public virtual int Id { get; protected set; }

    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual DateTime DatumVreme { get; set; }

    public virtual required string Lokacija { get; set; }

    public virtual decimal Kolicina { get; set; }

    public virtual decimal Cena { get; set; }

    public virtual required string NacinEvidentiranja { get; set; }

    public virtual required string Evidentirao { get; set; }
}