using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class HibridnoVoziloMapiranja : SubclassMap<HibridnoVozilo>
{
    public HibridnoVoziloMapiranja()
    {
        Table("HIBRIDNOVOZILO");

        KeyColumn("VOZILO_ID");

        Map(x => x.KapacitetBaterije, "KAPACITET_BATERIJE")
            .Not.Nullable();

        Map(x => x.TipHibridnogPogona, "TIP_HIBRIDNOG_POGONA")
            .Not.Nullable()
            .Length(50);
    }
}