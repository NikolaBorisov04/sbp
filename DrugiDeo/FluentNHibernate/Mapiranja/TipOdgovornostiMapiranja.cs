using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class TipOdgovornostiMapiranja : ClassMap<TipOdgovornosti>
{
    public TipOdgovornostiMapiranja()
    {
        Table("TIPODGOVORNOSTI");

        Id(x => x.Id, "ID")
            .GeneratedBy.Identity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(50);
    }
}