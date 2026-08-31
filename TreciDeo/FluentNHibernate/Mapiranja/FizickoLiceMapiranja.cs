using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class FizickoLiceMapiranja : SubclassMap<FizickoLice>
{
    public FizickoLiceMapiranja()
    {
        Table("FIZICKOLICE");

        KeyColumn("KORISNIK_ID");

        Map(x => x.Jmbg, "JMBG")
            .Not.Nullable()
            .Length(13);

        Map(x => x.Ime, "IME")
            .Not.Nullable()
            .Length(50);

        Map(x => x.Prezime, "PREZIME")
            .Not.Nullable()
            .Length(50);

        Map(x => x.BrojVozackeDozvole, "BROJ_VOZACKE_DOZVOLE")
            .Not.Nullable()
            .Length(30);

        Map(x => x.KategorijeDozvole, "KATEGORIJE_DOZVOLE")
            .Not.Nullable()
            .Length(50);

        Map(x => x.DatumIzdavanjaDozvole, "DATUM_IZDAVANJA_DOZVOLE")
            .Not.Nullable();

        Map(x => x.DatumIstekaDozvole, "DATUM_ISTEKA_DOZVOLE")
            .Not.Nullable();
    }
}