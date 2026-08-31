namespace FluentNHibernateTemplate.Entiteti;

public class NezgodaSteta
{
    public virtual int Id { get; set; }

    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual TipOdgovornosti Odgovornost { get; set; } = null!;

    public virtual decimal ProcenaStete { get; set; }

    public virtual IList<NezgodaOsiguravajucaKuca> OsiguravajuceKuce { get; set; } = new List<NezgodaOsiguravajucaKuca>();
    public virtual IList<NezgodaZapisnik> Zapisnici { get; set; } = new List<NezgodaZapisnik>();
    public virtual IList<NezgodaFotografija> Fotografije { get; set; } = new List<NezgodaFotografija>();
}
