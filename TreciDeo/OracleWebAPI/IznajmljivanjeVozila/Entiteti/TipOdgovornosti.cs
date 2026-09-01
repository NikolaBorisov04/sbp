namespace FluentNHibernateTemplate.Entiteti;

public class TipOdgovornosti
{
    public virtual int Id { get; set; }

    public virtual string Naziv { get; set; } = null!;
}
