using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateTemplate.Entiteti
{
    public class SluzbenaVoznja : Rezervacija
    {
        public virtual string Razlog { get; set; }
        public virtual string OvlascenoLice { get; set; }
    }
}
