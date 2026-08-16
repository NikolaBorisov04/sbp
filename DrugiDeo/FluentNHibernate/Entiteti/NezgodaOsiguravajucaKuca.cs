namespace FluentNHibernateTemplate.Entiteti;

public class NezgodaOsiguravajucaKuca
{
    public virtual int Id { get; protected set; }

    public virtual NezgodaSteta NezgodaSteta { get; set; } = null!;

    public virtual required string OsiguravajucaKuca { get; set; }
}