using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class KvarMapiranja : ClassMap<Kvar>
{
    public KvarMapiranja()
    {
        Table("KVAR");

        Id(x => x.Id, "ID")
            .GeneratedBy.Identity();

        References(x => x.Vozilo)
            .Column("VOZILO_ID")
            .Not.Nullable();

        References(x => x.Prijavio)
            .Column("PRIJAVIO_ID")
            .Not.Nullable();

        Map(x => x.DatumPrijave, "DATUM_PRIJAVE")
            .Not.Nullable();

        Map(x => x.OpisProblema, "OPIS_PROBLEMA")
            .Not.Nullable()
            .Length(2000);

        Map(x => x.ProcenaOzbiljnosti, "PROCENA_OZBILJNOSTI")
            .Not.Nullable()
            .Length(50);

        Map(x => x.Status, "STATUS")
            .Not.Nullable()
            .Length(50);

        Map(x => x.DatumOtklanjanja, "DATUM_OTKLANJANJA");
    }
}