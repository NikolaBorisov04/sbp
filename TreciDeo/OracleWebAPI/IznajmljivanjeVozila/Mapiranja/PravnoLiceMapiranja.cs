using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class PravnoLiceMapiranja : SubclassMap<PravnoLice>
{
    public PravnoLiceMapiranja()
    {
        Table("PRAVNOLICE");

        KeyColumn("KORISNIK_ID");

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(100);

        Map(x => x.Pib, "PIB")
            .Not.Nullable()
            .Length(9);

        Map(x => x.MaticniBroj, "MATICNI_BROJ")
            .Not.Nullable()
            .Length(8);

        Map(x => x.Sediste, "SEDISTE")
            .Not.Nullable()
            .Length(200);

        Map(x => x.KontaktOsoba, "KONTAKT_OSOBA")
            .Not.Nullable()
            .Length(100);

        Map(x => x.UgovoreniUsloviKoriscenja, "UGOVORENI_USLOVI_KORISCENJA")
            .Length(2000);
    }
}