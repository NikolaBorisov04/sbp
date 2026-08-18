using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate.Mapiranja
{
    class DogadjajiUVoznjiMapiranja : ClassMap<DogadjajUVoznji>
    {
        public DogadjajiUVoznjiMapiranja()
        {
            Table("DOGADJAJVOZNJE");

            Id(x => x.Id, "ID").GeneratedBy.Identity();

            Map(x => x.Tip, "TIP_DOGADJAJA");
            Map(x => x.Vreme, "VREME_DOGADJAJA");
            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Opis, "OPIS");

            References(x => x.Voznja).Column("VOZNJA_ID").Not.Nullable();
        }
    }
}
