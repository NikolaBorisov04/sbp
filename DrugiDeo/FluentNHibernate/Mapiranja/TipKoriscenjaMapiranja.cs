using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class TipKoriscenjaMapiranja : ClassMap<TipKoriscenja>
{
    public TipKoriscenjaMapiranja()
    {
        Table("TIPKORISCENJA");

        Id(x => x.Id, "ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv, "NAZIV")
            .Not.Nullable()
            .Length(50);
    }
}
