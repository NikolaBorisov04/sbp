using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja
{
    class VoznjaMapiranja : ClassMap<Voznja>
    {
        public VoznjaMapiranja()
        {
            Table("VOZNJA");

            Id(x => x.Id, "ID").GeneratedBy.Identity();

            Map(x => x.VremePocetka, "STVARNO_VREME_POCETKA");
            Map(x => x.VremeZavrsetka, "STVARNO_VREME_ZAVRSETKA");
            Map(x => x.PredjenaKilometraza, "PREDJENA_KILOMETRAZA");
            Map(x => x.TrajanjeMinuti, "TRAJANJE_MINUTI");
            Map(x => x.PocetniNivo, "POCETNI_NIVO_GORIVA_BATERIJE");
            Map(x => x.KrajnjiNivo, "ZAVRSNI_NIVO_GORIVA_BATERIJE");
            Map(x => x.PocetnaLokacija, "POCETNA_LOKACIJA");
            Map(x => x.KrajnjaLokacija, "ZAVRSNA_LOKACIJA");
            Map(x => x.Cena, "OBRACUNATA_CENA");
            Map(x => x.Naknade, "DODATNE_NAKNADE");

            References(x => x.Rezervacija).Column("REZERVACIJA_ID").Not.Nullable();
            HasMany(x => x.Dogadjaji).KeyColumn("VOZNJA_ID").Cascade.All().Inverse();
        }
    }
}
