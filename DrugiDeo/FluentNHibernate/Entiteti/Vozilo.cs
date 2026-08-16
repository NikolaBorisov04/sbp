namespace FluentNHibernateTemplate.Entiteti;

public class Vozilo
{
    public virtual int Id { get; protected set; }
    public virtual required string RegistarskaOznaka { get; set; }
    public virtual required string Vin { get; set; }
    public virtual required string Marka { get; set; }
    public virtual required string Model { get; set; }
    public virtual int GodinaProizvodnje { get; set; }
    public virtual DateTime DatumNabavke { get; set; }
    public virtual required string Status { get; set; }
    public virtual int BrojSedista { get; set; }
    public virtual string? StanjeEnterijera { get; set; }
    public virtual string? StanjeEksterijera { get; set; }
    public virtual string? OgranicenjaKoriscenja { get; set; }
    public virtual TipKoriscenja? TipKoriscenja { get; set; }
    public virtual TipPogona? TipPogona { get; set; }
}