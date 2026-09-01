namespace FluentNHibernateTemplate.Entiteti;

public class TipKorisnika
{
    public virtual int Id { get; set; }
    public virtual string Naziv { get; set; } = null!; // 'Fizicko lice', 'Pravno lice'
}