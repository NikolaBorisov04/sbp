using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class TelefonKorisnikaMapiranja : ClassMap<TelefonKorisnika>
{
    public TelefonKorisnikaMapiranja()
    {
        Table("TELEFONKORISNIKA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.BrojTelefona, "BROJ_TELEFONA")
            .Not.Nullable()
            .Length(30);

        References(x => x.Korisnik)
            .Column("KORISNIK_ID")
            .Not.Nullable();
    }
}