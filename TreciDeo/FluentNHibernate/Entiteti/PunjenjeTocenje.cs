namespace FluentNHibernateTemplate.Entiteti;

public class PunjenjeTocenje
{
    public virtual int Id { get; set; }

    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual DateTime DatumVreme { get; set; }

    public virtual string Lokacija { get; set; } = null!;

    public virtual decimal Kolicina { get; set; }

    public virtual decimal Cena { get; set; }

    public virtual string NacinEvidentiranja { get; set; } = null!;

    public virtual string Evidentirao { get; set; } = null!;
}
