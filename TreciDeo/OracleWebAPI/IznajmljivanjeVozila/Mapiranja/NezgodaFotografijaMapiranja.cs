using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class NezgodaFotografijaMapiranja
    : ClassMap<NezgodaFotografija>
{
    public NezgodaFotografijaMapiranja()
    {
        Table("NEZGODAFOTOGRAFIJA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        References(x => x.NezgodaSteta)
            .Column("NEZGODA_STETA_ID")
            .Not.Nullable();

        Map(x => x.FotografijaUrl, "FOTOGRAFIJA_URL")
            .Not.Nullable()
            .Length(500);
    }
}
