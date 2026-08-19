using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate
{
    public class DTOManager
    {
        #region Voznje

        public static List<VoznjaPregled> vratiSveVoznje()
        {
            List<VoznjaPregled> voznje = new List<VoznjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Voznja> sveVoznje = from o in s.Query<Entiteti.Voznja>()
                                                         select o;

                foreach (Entiteti.Voznja v in sveVoznje)
                {
                    voznje.Add(new VoznjaPregled(v.Id, v.VremePocetka, v.VremeZavrsetka, v.PredjenaKilometraza, v.TrajanjeMinuti, v.PocetniNivo, v.KrajnjiNivo, v.PocetnaLokacija, v.KrajnjaLokacija, v.Cena, v.Naknade));
                }

                s.Close();
            }
            catch (Exception ex)
            {

            }

            return voznje;
        }

        public static VoznjaPregled vratiVoznju(int id)
        {
            VoznjaPregled vb = new VoznjaPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja v = s.Load<Voznja>(id);
                vb = new VoznjaPregled(v.Id, v.VremePocetka, v.VremeZavrsetka, v.PredjenaKilometraza, v.TrajanjeMinuti, v.PocetniNivo, v.KrajnjiNivo, v.PocetnaLokacija, v.KrajnjaLokacija, v.Cena, v.Naknade);
                
                s.Close();
            }
            catch (Exception ex)
            {

            }

            return vb;
        }

        public static VoznjaPregled azurirajVoznju(VoznjaPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja voznja = s.Load<Voznja>(v.Id);
                voznja.VremePocetka = v.VremePocetka;
                voznja.VremeZavrsetka = v.VremeZavrsetka;
                voznja.PredjenaKilometraza = v.PredjenaKilometraza;
                voznja.TrajanjeMinuti = v.TrajanjeMinuti;
                voznja.PocetniNivo = v.PocetniNivo;
                voznja.KrajnjiNivo = v.KrajnjiNivo;
                voznja.PocetnaLokacija = v.PocetnaLokacija;
                voznja.KrajnjaLokacija = v.KrajnjaLokacija;
                voznja.Cena = v.Cena;
                voznja.Naknade = v.Naknade;

                s.Update(voznja);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {

            }

            return v;
        }
        #endregion
    }
}
