using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class TipPogonaMapiranja : ClassMap<TipPogona>
{
    public TipPogonaMapiranja()
    {
        Table("TIPPOGONA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(50);
    }
}
