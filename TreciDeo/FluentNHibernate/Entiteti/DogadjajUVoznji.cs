using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateTemplate.Entiteti
{
    public class DogadjajUVoznji
    {
        public virtual int Id { get; set; }
        public virtual string Tip { get; set; }
        public virtual DateTime Vreme { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string Opis { get; set; }
        public virtual Voznja Voznja { get; set; }
    }
}
