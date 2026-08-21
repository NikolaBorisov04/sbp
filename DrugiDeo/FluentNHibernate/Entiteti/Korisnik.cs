namespace FluentNHibernateTemplate.Entiteti;

public class Korisnik
{
    public virtual int Id { get; set; }
    public virtual string Adresa { get; set; } = null!;
    public virtual string EmailAdresa { get; set; } = null!;
    public virtual DateTime DatumRegistracije { get; set; }
    public virtual string StatusNaloga { get; set; } = null!;
    public virtual string NacinVerifikacije { get; set; } = null!;
    public virtual TipKorisnika TipKorisnika { get; set; } = null!;

    public virtual IList<TelefonKorisnika> Telefoni { get; set; } = new List<TelefonKorisnika>();
    public virtual IList<VerifikacijaKorisnika> Verifikacije { get; set; } = new List<VerifikacijaKorisnika>();
    public virtual IList<NacinPlacanja> NaciniPlacanja { get; set; } = new List<NacinPlacanja>();
    public virtual IList<KorisnikUloga> KorisnikUloge { get; set; } = new List<KorisnikUloga>();
}