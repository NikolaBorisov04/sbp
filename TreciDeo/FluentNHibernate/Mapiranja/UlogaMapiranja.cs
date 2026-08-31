using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class UlogaMapiranja : ClassMap<Uloga>
{
    public UlogaMapiranja()
    {
        Table("ULOGA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(50);
    }
}