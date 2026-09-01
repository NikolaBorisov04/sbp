using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class VoziloMapiranja : ClassMap<Vozilo>
{
    public VoziloMapiranja()
    {
        Table("VOZILO");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.RegistarskaOznaka, "REGISTARSKA_OZNAKA")
            .Not.Nullable()
            .Length(20);

        Map(x => x.Vin, "VIN")
            .Not.Nullable()
            .Length(17);

        Map(x => x.Marka, "MARKA")
            .Not.Nullable()
            .Length(50);

        Map(x => x.Model, "MODEL")
            .Not.Nullable()
            .Length(50);

        Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE")
            .Not.Nullable();

        Map(x => x.DatumNabavke, "DATUM_NABAVKE")
            .Not.Nullable();

        Map(x => x.Status, "STATUS")
            .Not.Nullable()
            .Length(50);

        Map(x => x.BrojSedista, "BROJ_SEDISTA")
            .Not.Nullable();

        Map(x => x.StanjeEnterijera, "STANJE_ENTERIJERA")
            .Length(1000);

        Map(x => x.StanjeEksterijera, "STANJE_EKSTERIJERA")
            .Length(1000);

        Map(x => x.OgranicenjaKoriscenja, "OGRANICENJA_KORISCENJA")
            .Length(2000);

        References(x => x.TipKoriscenja)
            .Column("TIP_KORISCENJA_ID")
            .Not.Nullable();

        References(x => x.TipPogona)
            .Column("TIP_POGONA_ID")
            .Not.Nullable();

        HasMany(x => x.Servisi).KeyColumn("VOZILO_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Kvarovi).KeyColumn("VOZILO_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.PunjenjaTocenja).KeyColumn("VOZILO_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.NezgodeStete).KeyColumn("VOZILO_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.DodeljenaOprema).KeyColumn("VOZILO_ID").LazyLoad().Cascade.All().Inverse();
    }
}
