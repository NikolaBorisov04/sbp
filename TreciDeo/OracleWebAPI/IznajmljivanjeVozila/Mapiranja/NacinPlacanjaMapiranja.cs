using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class NacinPlacanjaMapiranja : ClassMap<NacinPlacanja>
{
    public NacinPlacanjaMapiranja()
    {
        Table("NACINPLACANJA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.TipPlacanja, "TIP_PLACANJA")
            .Not.Nullable()
            .Length(50);

        Map(x => x.Status, "STATUS")
            .Not.Nullable()
            .Length(50);

        Map(x => x.DatumDodavanja, "DATUM_DODAVANJA")
            .Not.Nullable();

        Map(x => x.Ogranicenja, "OGRANICENJA")
            .Length(1000);

        References(x => x.Korisnik)
            .Column("KORISNIK_ID")
            .Not.Nullable();
    }
}