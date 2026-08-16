using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja;

public class KlasicnoVoziloMapiranja : SubclassMap<KlasicnoVozilo>
{
    public KlasicnoVoziloMapiranja()
    {
        Table("KLASICNOVOZILO");

        KeyColumn("VOZILO_ID");

        Map(x => x.TipGoriva, "TIP_GORIVA")
            .Not.Nullable()
            .Length(50);

        Map(x => x.ZapreminaRezervoara, "ZAPREMINA_REZERVOARA")
            .Not.Nullable();

        Map(x => x.ProsecnaPotrosnja, "PROSECNA_POTROSNJA")
            .Not.Nullable();
    }
}