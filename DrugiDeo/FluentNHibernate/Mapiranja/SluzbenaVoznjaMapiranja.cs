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

            KeyColumn("rezervacija_id");

            Map(x => x.Razlog, "razlog_voznje").Not.Nullable();
            Map(x => x.OvlascenoLice, "ovlasceno_lice").Not.Nullable();
        }
    }
}
