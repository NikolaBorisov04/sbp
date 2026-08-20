using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class PunjenjeTocenjeMapiranja : ClassMap<PunjenjeTocenje>
{
    public PunjenjeTocenjeMapiranja()
    {
        Table("PUNJENJETOCENJE");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        References(x => x.Vozilo)
            .Column("VOZILO_ID")
            .Not.Nullable();

        Map(x => x.DatumVreme, "DATUM_VREME")
            .Not.Nullable();

        Map(x => x.Lokacija, "LOKACIJA")
            .Not.Nullable()
            .Length(200);

        Map(x => x.Kolicina, "KOLICINA")
            .Not.Nullable();

        Map(x => x.Cena, "CENA")
            .Not.Nullable();

        Map(x => x.NacinEvidentiranja, "NACIN_EVIDENTIRANJA")
            .Not.Nullable()
            .Length(100);

        Map(x => x.Evidentirao, "EVIDENTIRAO")
            .Not.Nullable()
            .Length(100);
    }
}
