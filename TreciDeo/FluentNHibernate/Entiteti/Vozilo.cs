namespace FluentNHibernateTemplate.Entiteti;

public class Vozilo
{
    public virtual int Id { get; set; }
    public virtual string RegistarskaOznaka { get; set; } = null!;
    public virtual string Vin { get; set; } = null!;
    public virtual string Marka { get; set; } = null!;
    public virtual string Model { get; set; } = null!;
    public virtual int GodinaProizvodnje { get; set; }
    public virtual DateTime DatumNabavke { get; set; }
    public virtual string Status { get; set; } = null!;
    public virtual int BrojSedista { get; set; }
    public virtual string? StanjeEnterijera { get; set; }
    public virtual string? StanjeEksterijera { get; set; }
    public virtual string? OgranicenjaKoriscenja { get; set; }
    public virtual TipKoriscenja? TipKoriscenja { get; set; }
    public virtual TipPogona? TipPogona { get; set; }

    public virtual IList<Servis> Servisi { get; set; } = new List<Servis>();
    public virtual IList<Kvar> Kvarovi { get; set; } = new List<Kvar>();
    public virtual IList<PunjenjeTocenje> PunjenjaTocenja { get; set; } = new List<PunjenjeTocenje>();
    public virtual IList<NezgodaSteta> NezgodeStete { get; set; } = new List<NezgodaSteta>();
    public virtual IList<VoziloOprema> DodeljenaOprema { get; set; } = new List<VoziloOprema>();
}
