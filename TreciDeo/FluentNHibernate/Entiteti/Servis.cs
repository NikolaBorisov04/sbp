namespace FluentNHibernateTemplate.Entiteti;

public class Servis
{
    public virtual int Id { get; set; }

    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual TipServisa TipServisa { get; set; } = null!;

    public virtual string ServisniCentar { get; set; } = null!;

    public virtual DateTime DatumPrijema { get; set; }

    public virtual DateTime? DatumZavrsetka { get; set; }

    public virtual string? OpisRadova { get; set; }

    public virtual string? ZamenjeniDelovi { get; set; }

    public virtual decimal Troskovi { get; set; }

    public virtual string Status { get; set; } = null!;
}
