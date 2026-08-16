using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class NezgodaStetaMapiranja : ClassMap<NezgodaSteta>
{
    public NezgodaStetaMapiranja()
    {
        Table("NEZGODASTETA");

        Id(x => x.Id, "ID")
            .GeneratedBy.Identity();

        References(x => x.Vozilo)
            .Column("VOZILO_ID")
            .Not.Nullable();

        References(x => x.Odgovornost)
            .Column("ODGOVORNOST_ID")
            .Not.Nullable();

        Map(x => x.ProcenaStete, "PROCENA_STETE")
            .Not.Nullable();
    }
}