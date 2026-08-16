using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class TipServisaMapiranja : ClassMap<TipServisa>
{
    public TipServisaMapiranja()
    {
        Table("TIPSERVISA");

        Id(x => x.Id, "ID")
            .GeneratedBy.Identity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(50);
    }
}