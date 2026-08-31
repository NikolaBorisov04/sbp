namespace FluentNHibernateTemplate.Entiteti;

public class FizickoLice : Korisnik
{
    public virtual string Jmbg { get; set; } = null!;
    public virtual string Ime { get; set; } = null!;
    public virtual string Prezime { get; set; } = null!;
    public virtual string BrojVozackeDozvole { get; set; } = null!;
    public virtual string KategorijeDozvole { get; set; } = null!;
    public virtual DateTime DatumIzdavanjaDozvole { get; set; }
    public virtual DateTime DatumIstekaDozvole { get; set; }
}