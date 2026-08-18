using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja
{
    class RezervacijaMapiranja : ClassMap<Rezervacija>
    {
        public RezervacijaMapiranja()
        {
            Table("REZERVACIJA");

            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.VremePocetka, "PLANIRANO_VREME_POCETKA").Not.Nullable();
            Map(x => x.VremeZavrsetka, "PLANIRANO_VREME_ZAVRSETKA").Not.Nullable();
            Map(x => x.LokacijaPreuzimanja, "LOKACIJA_PREUZIMANJA").Not.Nullable();
            Map(x => x.LokacijaVracanja, "PLANIRANA_LOKACIJA_VRACANJA").Not.Nullable();
            Map(x => x.Tip, "TIP_REZERVACIJE").Not.Nullable();
            Map(x => x.Status, "STATUS").Not.Nullable();

            References(x => x.Vozilo).Column("VOZILO_ID").Not.Nullable();
            //References(x => x.Korisnik).Column("KORISNIK_ID").Not.Nullable();
            //References(x => x.Vozac).Column("VOZAC_ID");


        }
    }
}
