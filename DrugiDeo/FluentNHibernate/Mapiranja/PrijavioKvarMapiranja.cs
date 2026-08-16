using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class PrijavioKvarMapiranja : ClassMap<PrijavioKvar>
{
    public PrijavioKvarMapiranja()
    {
        Table("PRIJAVIOKVAR");

        Id(x => x.Id, "ID")
            .GeneratedBy.Identity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(50);
    }
}