using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class NezgodaStetaMapiranja : ClassMap<NezgodaSteta>
{
    public NezgodaStetaMapiranja()
    {
        Table("NEZGODASTETA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        References(x => x.Vozilo)
            .Column("VOZILO_ID")
            .Not.Nullable();

        References(x => x.Odgovornost)
            .Column("ODGOVORNOST_ID")
            .Not.Nullable();

        Map(x => x.ProcenaStete, "PROCENA_STETE")
            .Not.Nullable();

        HasMany(x => x.OsiguravajuceKuce).KeyColumn("NEZGODA_STETA_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Zapisnici).KeyColumn("NEZGODA_STETA_ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Fotografije).KeyColumn("NEZGODA_STETA_ID").LazyLoad().Cascade.All().Inverse();
    }
}
