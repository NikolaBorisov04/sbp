namespace FluentNHibernateTemplate.Entiteti;

public class Kvar
{
    public virtual int Id { get; protected set; }

    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual PrijavioKvar Prijavio { get; set; } = null!;

    public virtual DateTime DatumPrijave { get; set; }

    public virtual required string OpisProblema { get; set; }

    public virtual required string ProcenaOzbiljnosti { get; set; }

    public virtual required string Status { get; set; }

    public virtual DateTime? DatumOtklanjanja { get; set; }
}