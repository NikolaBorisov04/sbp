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

            Map(x => x.VremePocetka, "STVARNO_VREME_POCETKA").Not.Nullable();
            Map(x => x.VremeZavrsetka, "STVARNO_VREME_ZAVRSETKA").Not.Nullable();
            Map(x => x.PredjenaKilometraza, "PREDJENA_KILOMETRAZA").Not.Nullable();
            Map(x => x.TrajanjeMinuti, "TRAJANJE_MINUTI").Not.Nullable();
            Map(x => x.PocetniNivo, "POCETNI_NIVO_GORIVA_BATERIJE").Not.Nullable();
            Map(x => x.KrajnjiNivo, "ZAVRSNI_NIVO_GORIVA_BATERIJE").Not.Nullable();
            Map(x => x.PocetnaLokacija, "POCETNA_LOKACIJA").Not.Nullable();
            Map(x => x.KrajnjaLokacija, "ZAVRSNA_LOKACIJA").Not.Nullable();
            Map(x => x.Cena, "OBRACUNATA_CENA").Not.Nullable();
            Map(x => x.Naknade, "DODATNE_NAKNADE").Not.Nullable();

            References(x => x.Rezervacija).Column("REZERVACIJA_ID").Not.Nullable();
            HasMany(x => x.Dogadjaji).KeyColumn("VOZNJA_ID").Cascade.All().Inverse();
        }
    }
}
