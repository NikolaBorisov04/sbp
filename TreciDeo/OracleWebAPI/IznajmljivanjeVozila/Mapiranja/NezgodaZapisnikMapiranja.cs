using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class NezgodaZapisnikMapiranja
    : ClassMap<NezgodaZapisnik>
{
    public NezgodaZapisnikMapiranja()
    {
        Table("NEZGODAZAPISNIK");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        References(x => x.NezgodaSteta)
            .Column("NEZGODA_STETA_ID")
            .Not.Nullable();

        Map(x => x.ZapisnikUrl, "ZAPISNIK_URL")
            .Not.Nullable()
            .Length(500);
    }
}
