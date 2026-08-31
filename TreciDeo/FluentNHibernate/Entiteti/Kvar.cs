namespace FluentNHibernateTemplate.Entiteti;

public class Kvar
{
    public virtual int Id { get; set; }

    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual PrijavioKvar Prijavio { get; set; } = null!;

    public virtual DateTime DatumPrijave { get; set; }

    public virtual string OpisProblema { get; set; } = null!;

    public virtual string ProcenaOzbiljnosti { get; set; } = null!;

    public virtual string Status { get; set; } = null!;

    public virtual DateTime? DatumOtklanjanja { get; set; }
}
