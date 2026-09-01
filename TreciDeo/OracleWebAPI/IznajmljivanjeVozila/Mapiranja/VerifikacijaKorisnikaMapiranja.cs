using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class VerifikacijaKorisnikaMapiranja : ClassMap<VerifikacijaKorisnika>
{
    public VerifikacijaKorisnikaMapiranja()
    {
        Table("VERIFIKACIJAKORISNIKA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.DatumVerifikacije, "DATUM_VERIFIKACIJE")
            .Not.Nullable();

        Map(x => x.Verifikator, "VERIFIKATOR")
            .Not.Nullable()
            .Length(100);

        Map(x => x.Rezultat, "REZULTAT")
            .Not.Nullable()
            .Length(100);

        Map(x => x.Ogranicenja, "OGRANICENJA")
            .Length(1000);

        References(x => x.Korisnik)
            .Column("KORISNIK_ID")
            .Not.Nullable();
    }
}