using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class OpremaMapiranja : ClassMap<Oprema>
{
    public OpremaMapiranja()
    {
        Table("OPREMA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(100);

        Map(x => x.Opis, "OPIS")
            .Length(1000);

        HasMany(x => x.Vozila).KeyColumn("OPREMA_ID").LazyLoad().Cascade.All().Inverse();
    }
}
