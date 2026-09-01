namespace FluentNHibernateTemplate.Entiteti;

public class VerifikacijaKorisnika
{
    public virtual int Id { get; set; }
    public virtual DateTime DatumVerifikacije { get; set; }
    public virtual string Verifikator { get; set; } = null!;
    public virtual string Rezultat { get; set; } = null!;
    public virtual string? Ogranicenja { get; set; }
    public virtual Korisnik Korisnik { get; set; } = null!;
}