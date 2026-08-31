using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class KorisnikMapiranja : ClassMap<Korisnik>
{
    public KorisnikMapiranja()
    {
        Table("KORISNIK");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.Adresa, "ADRESA")
            .Not.Nullable()
            .Length(200);

        Map(x => x.EmailAdresa, "EMAIL_ADRESA")
            .Not.Nullable()
            .Length(100);

        Map(x => x.DatumRegistracije, "DATUM_REGISTRACIJE")
            .Not.Nullable();

        Map(x => x.StatusNaloga, "STATUS_NALOGA")
            .Not.Nullable()
            .Length(50);

        Map(x => x.NacinVerifikacije, "NACIN_VERIFIKACIJE")
            .Not.Nullable()
            .Length(100);

        References(x => x.TipKorisnika)
            .Column("TIP_KORISNIKA_ID")
            .Not.Nullable();

        HasMany(x => x.Telefoni).KeyColumn("KORISNIK_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Verifikacije).KeyColumn("KORISNIK_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.NaciniPlacanja).KeyColumn("KORISNIK_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.KorisnikUloge).KeyColumn("KORISNIK_ID").LazyLoad().Cascade.All().Inverse();
    }
}