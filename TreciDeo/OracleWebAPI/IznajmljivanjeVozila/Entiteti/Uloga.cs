namespace FluentNHibernateTemplate.Entiteti;

public class Uloga
{
    public virtual int Id { get; set; }
    public virtual string Naziv { get; set; } = null!; // 'Privatni korisnik', 'Zaposleni', 'Administrator'
}