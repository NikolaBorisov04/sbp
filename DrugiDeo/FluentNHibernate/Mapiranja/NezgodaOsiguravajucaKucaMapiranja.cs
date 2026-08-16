using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class NezgodaOsiguravajucaKucaMapiranja
    : ClassMap<NezgodaOsiguravajucaKuca>
{
    public NezgodaOsiguravajucaKucaMapiranja()
    {
        Table("NEZGODAOSIGURAVAJUCAKUCA");

        Id(x => x.Id, "ID")
            .GeneratedBy.Identity();

        References(x => x.NezgodaSteta)
            .Column("NEZGODA_STETA_ID")
            .Not.Nullable();

        Map(x => x.OsiguravajucaKuca, "OSIGURAVAJUCA_KUCA")
            .Not.Nullable()
            .Length(100);
    }
}