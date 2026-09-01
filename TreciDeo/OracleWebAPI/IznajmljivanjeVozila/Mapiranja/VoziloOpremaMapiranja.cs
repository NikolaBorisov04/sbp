using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class VoziloOpremaMapiranja : ClassMap<VoziloOprema>
{
    public VoziloOpremaMapiranja()
    {
        Table("VOZILOOPREMA");

        CompositeId()
            .KeyReference(x => x.Vozilo, "VOZILO_ID")
            .KeyReference(x => x.Oprema, "OPREMA_ID");

        Map(x => x.IsDodatna, "IS_DODATNA")
            .Not.Nullable();
    }
}