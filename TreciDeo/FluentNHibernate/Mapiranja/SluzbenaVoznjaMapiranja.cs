using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja
{
    class SluzbenaVoznjaMapiranja : SubclassMap<SluzbenaVoznja>
    {
        public SluzbenaVoznjaMapiranja()
        {
            Table("SluzbenaVoznjaDetalji");

            KeyColumn("REZERVACIJA_ID");

            Map(x => x.Razlog, "RAZLOG_VOZNJE").Not.Nullable();
            Map(x => x.OvlascenoLice, "OVLASCENO_LICE").Not.Nullable();
        }
    }
}
