using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class ElektricnoVoziloMapiranja : SubclassMap<ElektricnoVozilo>
{
    public ElektricnoVoziloMapiranja()
    {
        Table("ELEKTRICNOVOZILO");

        KeyColumn("VOZILO_ID");

        Map(x => x.KapacitetBaterije, "KAPACITET_BATERIJE")
            .Not.Nullable();

        Map(x => x.TrenutniNivoNapunjenosti, "TRENUTNI_NIVO_NAPUNJENOSTI")
            .Not.Nullable();

        Map(x => x.Autonomija, "AUTONOMIJA")
            .Not.Nullable();

        Map(x => x.TipPunjenja, "TIP_PUNJENJA")
            .Not.Nullable()
            .Length(50);

        Map(x => x.BrojCiklusaPunjenja, "BROJ_CIKLUSA_PUNJENJA")
            .Not.Nullable();
    }
}