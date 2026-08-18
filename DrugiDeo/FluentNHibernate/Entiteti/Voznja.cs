using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateTemplate.Entiteti
{
    public class Voznja
    {
        public virtual int Id { get; set; }
        public virtual DateTime VremePocetka { get; set; }
        public virtual DateTime VremeZavrsetka { get; set; }
        public virtual double PredjenaKilometraza { get; set; }
        public virtual int TrajanjeMinuti { get; set; }
        public virtual double PocetniNivo { get; set; }
        public virtual double KrajnjiNivo { get; set; }
        public virtual string PocetnaLokacija { get; set; }
        public virtual string KrajnjaLokacija { get; set; }
        public virtual double Cena { get; set; }
        public virtual double Naknade { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }

        public virtual IList<DogadjajUVoznji> Dogadjaji { get; set; }

        public Voznja()
        {
            Dogadjaji = new List<DogadjajUVoznji>();
        }
    }
}
