namespace FluentNHibernateTemplate.Entiteti;

public class PravnoLice : Korisnik
{
    public virtual string Naziv { get; set; } = null!;
    public virtual string Pib { get; set; } = null!;
    public virtual string MaticniBroj { get; set; } = null!;
    public virtual string Sediste { get; set; } = null!;
    public virtual string KontaktOsoba { get; set; } = null!;
    public virtual string? UgovoreniUsloviKoriscenja { get; set; }

    public override string ToString() => $"{Naziv} {Pib}";
}