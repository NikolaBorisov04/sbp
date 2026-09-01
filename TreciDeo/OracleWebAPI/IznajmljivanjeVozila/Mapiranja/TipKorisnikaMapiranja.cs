using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class TipKorisnikaMapiranja : ClassMap<TipKorisnika>
{
    public TipKorisnikaMapiranja()
    {
        Table("TIPKORISNIKA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(50);
    }
}