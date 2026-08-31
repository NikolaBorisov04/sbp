namespace FluentNHibernateTemplate.Entiteti;

public class TelefonKorisnika
{
    public virtual int Id { get; set; }
    public virtual string BrojTelefona { get; set; } = null!;
    public virtual Korisnik Korisnik { get; set; } = null!;
}