namespace FluentNHibernateTemplate.Entiteti;

public class ElektricnoVozilo : Vozilo
{
    public virtual decimal KapacitetBaterije { get; set; }

    public virtual decimal TrenutniNivoNapunjenosti { get; set; }

    public virtual int Autonomija { get; set; }

    public virtual required string TipPunjenja { get; set; }

    public virtual int BrojCiklusaPunjenja { get; set; }
}