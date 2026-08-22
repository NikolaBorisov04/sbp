using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateTemplate.Entiteti
{
    public class Rezervacija
    {
        public virtual int Id { get; set; }
        public virtual DateTime VremePocetka { get; set; }
        public virtual DateTime VremeZavrsetka { get; set; }
        public virtual string LokacijaPreuzimanja { get; set; }
        public virtual string LokacijaVracanja { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Status { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual FizickoLice Vozac { get; set; }
        public virtual Vozilo Vozilo { get; set; }

    }
}
