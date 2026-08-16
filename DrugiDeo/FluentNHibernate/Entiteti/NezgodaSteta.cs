namespace FluentNHibernateTemplate.Entiteti;

public class NezgodaSteta
{
    public virtual int Id { get; protected set; }

    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual TipOdgovornosti Odgovornost { get; set; } = null!;

    public virtual decimal ProcenaStete { get; set; }
}