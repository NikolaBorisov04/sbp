namespace FluentNHibernateTemplate.Entiteti;

public class NacinPlacanja
{
    public virtual int Id { get; set; }
    public virtual string TipPlacanja { get; set; } = null!;
    public virtual string Status { get; set; } = null!;
    public virtual DateTime DatumDodavanja { get; set; }
    public virtual string? Ogranicenja { get; set; }
    public virtual Korisnik Korisnik { get; set; } = null!;
}