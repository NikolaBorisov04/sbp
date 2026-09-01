namespace FluentNHibernateTemplate.Entiteti;

public class ElektricnoVozilo : Vozilo
{
    public virtual decimal KapacitetBaterije { get; set; }

    public virtual decimal TrenutniNivoNapunjenosti { get; set; }

    public virtual int Autonomija { get; set; }

    public virtual string TipPunjenja { get; set; } = null!;

    public virtual int BrojCiklusaPunjenja { get; set; }
}
