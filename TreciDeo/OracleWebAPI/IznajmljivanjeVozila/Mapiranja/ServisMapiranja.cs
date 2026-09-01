using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class ServisMapiranja : ClassMap<Servis>
{
    public ServisMapiranja()
    {
        Table("SERVIS");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        References(x => x.Vozilo)
            .Column("VOZILO_ID")
            .Not.Nullable();

        References(x => x.TipServisa)
            .Column("TIP_SERVISA_ID")
            .Not.Nullable();

        Map(x => x.ServisniCentar, "SERVISNI_CENTAR")
            .Not.Nullable()
            .Length(200);

        Map(x => x.DatumPrijema, "DATUM_PRIJEMA")
            .Not.Nullable();

        Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");

        Map(x => x.OpisRadova, "OPIS_RADOVA")
            .Length(2000);

        Map(x => x.ZamenjeniDelovi, "ZAMENJENI_DELOVI")
            .Length(1000);

        Map(x => x.Troskovi, "TROSKOVI")
            .Not.Nullable();

        Map(x => x.Status, "STATUS")
            .Not.Nullable()
            .Length(50);
    }
}
