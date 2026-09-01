using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class KorisnikUlogaMapiranja : ClassMap<KorisnikUloga>
{
    public KorisnikUlogaMapiranja()
    {
        Table("KORISNIKULOGA");

        CompositeId()
            .KeyReference(x => x.Korisnik, "KORISNIK_ID")
            .KeyReference(x => x.Uloga, "ULOGA_ID");
    }
}