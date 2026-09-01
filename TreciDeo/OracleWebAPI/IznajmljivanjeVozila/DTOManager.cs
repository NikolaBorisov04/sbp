using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate
{
    public class DTOManager
    {
        #region Rezervacije
        public static List<RezervacijaPregled> vratiSveRezervacije()
        {
            List<RezervacijaPregled> rezervacije = new List<RezervacijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Rezervacija> sveRezervacije = from o in s.Query<Rezervacija>()
                                                         select o;

                foreach (Rezervacija v in sveRezervacije)
                {
                    int vozacId = v.Vozac != null ? v.Vozac.Id : -1;

                    if (v is SluzbenaVoznja sv)
                    {
                        rezervacije.Add(new SluzbenaVoznjaPregled(
                                sv.Id, sv.VremePocetka, sv.VremeZavrsetka,
                                sv.LokacijaPreuzimanja, sv.LokacijaVracanja,
                                sv.Tip, sv.Status, sv.Korisnik.Id, sv.Korisnik.ToString(), sv.Vozilo.Id, sv.Vozilo.ToString(), vozacId, (vozacId != -1) ? sv.Vozac.ToString() : "",
                                sv.Razlog, sv.OvlascenoLice
                            ));
                    }
                    else
                    {
                        rezervacije.Add(new RezervacijaPregled(
                                v.Id, v.VremePocetka, v.VremeZavrsetka,
                                v.LokacijaPreuzimanja, v.LokacijaVracanja,
                                v.Tip, v.Status, v.Korisnik.Id, v.Korisnik.ToString(), v.Vozilo.Id, v.Vozilo.ToString(), vozacId, (vozacId != -1) ? v.Vozac.ToString() : ""
                            ));
                    }
                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju rezervacija", ex);
            }

            return rezervacije;
        }

        public static RezervacijaPregled vratiRezervaciju(int id)
        {
            RezervacijaPregled rp = new RezervacijaPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija r = s.Load<Rezervacija>(id);
                int vozacId = r.Vozac != null ? r.Vozac.Id : -1;
                if (r is SluzbenaVoznja sv)
                {
                    rp = new SluzbenaVoznjaPregled(
                        sv.Id, sv.VremePocetka, sv.VremeZavrsetka,
                        sv.LokacijaPreuzimanja, sv.LokacijaVracanja,
                        sv.Tip, sv.Status, sv.Korisnik.Id, sv.Korisnik.ToString(), sv.Vozilo.Id, sv.Vozilo.ToString(), vozacId,(vozacId != -1) ? sv.Vozac.ToString() : "",
                        sv.Razlog, sv.OvlascenoLice
                    );
                }
                else
                {
                    rp = new RezervacijaPregled(
                        r.Id, r.VremePocetka, r.VremeZavrsetka,
                        r.LokacijaPreuzimanja, r.LokacijaVracanja,
                        r.Tip, r.Status, r.Korisnik.Id, r.Korisnik.ToString(), r.Vozilo.Id, r.Vozilo.ToString(), vozacId, (vozacId != -1) ? r.Vozac.ToString() : ""
                    );
                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju rezervacije", ex);
            }

            return rp;
        }

        public static RezervacijaPregled dodajRezervaciju(RezervacijaPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Korisnik korisnik = s.Load<Korisnik>(v.KorisnikId);
                Vozilo vozilo = s.Load<Vozilo>(v.VoziloId);

                FizickoLice vozac = null;
                if (v.VozacId != 0)
                {
                    vozac = s.Load<FizickoLice>(v.VozacId);
                }
                Rezervacija r = new Rezervacija
                {
                    VremePocetka = v.VremePocetka,
                    VremeZavrsetka = v.VremeZavrsetka,
                    LokacijaPreuzimanja = v.LokacijaPreuzimanja,
                    LokacijaVracanja = v.LokacijaVracanja,
                    Tip = v.Tip,
                    Status = v.Status,
                    Korisnik = korisnik,
                    Vozilo = vozilo,
                    Vozac = vozac
                };

                s.Save(r);
                s.Flush();
                s.Close();
                return v;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri kreiranju rezervacije", ex);
            }
        }
        public static RezervacijaPregled azurirajRezervaciju(RezervacijaPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija r = s.Load<Rezervacija>(v.Id);

                r.VremePocetka = v.VremePocetka;
                r.VremeZavrsetka = v.VremeZavrsetka;
                r.LokacijaPreuzimanja = v.LokacijaPreuzimanja;
                r.LokacijaVracanja = v.LokacijaVracanja;
                r.Tip = v.Tip;
                r.Status = v.Status;

                r.Korisnik = s.Load<Korisnik>(v.KorisnikId);
                r.Vozilo = s.Load<Vozilo>(v.VoziloId);
                r.Vozac = (v.VozacId != 0) ? s.Load<FizickoLice>(v.VozacId) : null;

                s.Update(r);
                s.Flush();
                s.Close();
                return v;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju rezervacije", ex);
            }
        }
        public static void obrisiRezervaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rezervacija r = s.Get<Rezervacija>(id);
                if (r != null)
                {
                    s.Delete(r);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju rezervacije", ex);
            }
        }
        public static List<RezervacijaPregled> vratiRezervacijeBezVoznje()
        {
            List<RezervacijaPregled> rezervacije = new List<RezervacijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<int> rezSaVoznjom = s.Query<Voznja>()
                          .Where(v => v.Rezervacija != null)
                          .Select(v => v.Rezervacija.Id)
                          .ToList();

                IEnumerable<Rezervacija> sveRezervacije = from o in s.Query<Rezervacija>()
                                                          where !rezSaVoznjom.Contains(o.Id)
                                                          select o;

                foreach (Rezervacija v in sveRezervacije)
                {
                    rezervacije.Add(new RezervacijaPregled(
                        v.Id,
                        v.VremePocetka,
                        v.VremeZavrsetka,
                        v.LokacijaPreuzimanja,
                        v.LokacijaVracanja,
                        v.Tip,
                        v.Status,
                        v.Korisnik.Id,
                        v.Korisnik.ToString(),
                        v.Vozilo.Id,
                        v.Vozilo.ToString(),
                        (v.Vozac != null) ? v.Vozac.Id : 0,
                        (v.Vozac != null) ? v.Vozac.ToString() : ""
                    ));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju rezervacija", ex);
            }

            return rezervacije;
        }
        #endregion

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
                    voznje.Add(new VoznjaPregled(
                        v.Id, 
                        v.VremePocetka, 
                        v.VremeZavrsetka, 
                        v.PredjenaKilometraza, 
                        v.TrajanjeMinuti, 
                        v.PocetniNivo, 
                        v.KrajnjiNivo, 
                        v.PocetnaLokacija, 
                        v.KrajnjaLokacija, 
                        v.Cena, 
                        v.Naknade,
                        v.Rezervacija.Id
                     ));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju vožnja", ex);
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
                vb = new VoznjaPregled(v.Id, v.VremePocetka, v.VremeZavrsetka, v.PredjenaKilometraza, v.TrajanjeMinuti, v.PocetniNivo, v.KrajnjiNivo, v.PocetnaLokacija, v.KrajnjaLokacija, v.Cena, v.Naknade, v.Rezervacija.Id);

                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju vožnje", ex);
            }

            return vb;
        }

        public static VoznjaPregled dodajVoznju(VoznjaPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rezervacija rezervacija = s.Get<Rezervacija>(v.RezervacijaId);

                Voznja voznja = new Voznja
                {
                    VremePocetka = v.VremePocetka,
                    VremeZavrsetka = v.VremeZavrsetka,
                    PredjenaKilometraza = v.PredjenaKilometraza,
                    TrajanjeMinuti = v.TrajanjeMinuti,
                    PocetniNivo = v.PocetniNivo,
                    KrajnjiNivo = v.KrajnjiNivo,
                    PocetnaLokacija = v.PocetnaLokacija,
                    KrajnjaLokacija = v.KrajnjaLokacija,
                    Cena = v.Cena,
                    Naknade = v.Naknade,
                    Rezervacija = rezervacija
                };

                s.Save(voznja);
                s.Flush();
                s.Close();
                return v;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri kreiranju vožnje", ex);
            }
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
                return v;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju vožnje", ex);
            }
        }

        public static void obrisiVoznju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Voznja v = s.Get<Voznja>(id);
                if (v != null)
                {
                    s.Delete(v);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju vožnje", ex);
            }
        }
        #endregion

        #region SluzbeneVoznje
        public static SluzbenaVoznjaPregled dodajSluzbenuVoznju(SluzbenaVoznjaPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Korisnik korisnik = s.Load<Korisnik>(v.KorisnikId);
                Vozilo vozilo = s.Load<Vozilo>(v.VoziloId);

                FizickoLice vozac = null;
                if (v.VozacId != 0)
                {
                    vozac = s.Load<FizickoLice>(v.VozacId);
                }
                SluzbenaVoznja sv = new SluzbenaVoznja
                {
                    VremePocetka = v.VremePocetka,
                    VremeZavrsetka = v.VremeZavrsetka,
                    LokacijaPreuzimanja = v.LokacijaPreuzimanja,
                    LokacijaVracanja = v.LokacijaVracanja,
                    Tip = v.Tip,
                    Status = v.Status,
                    Korisnik = korisnik,
                    Vozilo = vozilo,
                    Vozac = vozac,
                    Razlog = v.Razlog,
                    OvlascenoLice = v.OvlascenoLice
                };

                s.Save(sv);
                s.Flush();
                s.Close();
                return v;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri kreiranju službene vožnje", ex);
            }
        }
        public static SluzbenaVoznjaPregled azurirajSluzbenuVoznju(SluzbenaVoznjaPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SluzbenaVoznja r = s.Load<SluzbenaVoznja>(v.Id);

                r.VremePocetka = v.VremePocetka;
                r.VremeZavrsetka = v.VremeZavrsetka;
                r.LokacijaPreuzimanja = v.LokacijaPreuzimanja;
                r.LokacijaVracanja = v.LokacijaVracanja;
                r.Tip = v.Tip;
                r.Status = v.Status;

                r.Korisnik = s.Load<Korisnik>(v.KorisnikId);
                r.Vozilo = s.Load<Vozilo>(v.VoziloId);
                r.Vozac = (v.VozacId != 0) ? s.Load<FizickoLice>(v.VozacId) : null;
                r.Razlog = v.Razlog;
                r.OvlascenoLice = v.OvlascenoLice;

                s.Update(r);
                s.Flush();
                s.Close();
                return v;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju službene vožnje", ex);
            }
        }
        #endregion

        #region Dogadjaji
        public static List<DogadjajUVoznjiPregled> vratiDogadjajeZaVoznju(int id)
        {
            List<DogadjajUVoznjiPregled> dogadjaji = new List<DogadjajUVoznjiPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<DogadjajUVoznji> rezultati = from d in s.Query<DogadjajUVoznji>()
                                                         where d.Voznja.Id == id
                                                         select d;

                foreach (DogadjajUVoznji d in rezultati)
                {
                    dogadjaji.Add(new DogadjajUVoznjiPregled(d.Id, d.Tip, d.Vreme, d.Lokacija, d.Opis));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju događaja", ex);
            }

            return dogadjaji;
        }

        public static DogadjajUVoznjiPregled vratiDogadjaj(int id)
        {
            DogadjajUVoznjiPregled d = new DogadjajUVoznjiPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                DogadjajUVoznji v = s.Load<DogadjajUVoznji>(id);
                d = new DogadjajUVoznjiPregled(v.Id, v.Tip, v.Vreme, v.Lokacija, v.Opis);

                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju događaja", ex);
            }

            return d;
        }

        public static DogadjajUVoznjiPregled dodajDogadjaj(DogadjajUVoznjiPregled d, VoznjaPregled voznja)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Voznja v = s.Load<Voznja>(voznja.Id);

                DogadjajUVoznji dogadjaj = new DogadjajUVoznji
                {
                    Tip = d.Tip,
                    Vreme = d.Vreme,
                    Lokacija = d.Lokacija,
                    Opis = d.Opis,
                    Voznja = v
                };

                s.Save(dogadjaj);
                s.Flush();
                s.Close();
                return d;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri kreiranju događaja", ex);
            }
        }
        public static DogadjajUVoznjiPregled azurirajDogadjaj(DogadjajUVoznjiPregled d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DogadjajUVoznji dogadjaj = s.Load<DogadjajUVoznji>(d.Id);
                dogadjaj.Tip = d.Tip;
                dogadjaj.Vreme = d.Vreme;
                dogadjaj.Lokacija = d.Lokacija;
                dogadjaj.Opis = d.Opis;

                s.Update(dogadjaj);
                s.Flush();
                s.Close();
                return d;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju događaja", ex);
            }
        }

        public static void obrisiDogadjaj(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DogadjajUVoznji dogadjaj = s.Get<DogadjajUVoznji>(id);
                if (dogadjaj != null)
                {
                    s.Delete(dogadjaj);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju događaja", ex);
            }
        }
        #endregion

        #region Katalozi

        public static List<TipPogonaPregled> vratiSveTipovePogona()
        {
            List<TipPogonaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<TipPogona>().ToList();
                foreach (var t in list)
                    rez.Add(new TipPogonaPregled(t.Id, t.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static List<TipKoriscenjaPregled> vratiSveTipoveKoriscenja()
        {
            List<TipKoriscenjaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<TipKoriscenja>().ToList();
                foreach (var t in list)
                    rez.Add(new TipKoriscenjaPregled(t.Id, t.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static List<TipServisaPregled> vratiSveTipoveServisa()
        {
            List<TipServisaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<TipServisa>().ToList();
                foreach (var t in list)
                    rez.Add(new TipServisaPregled(t.Id, t.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static List<PrijavioKvarPregled> vratiSvePrijavioKvar()
        {
            List<PrijavioKvarPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<PrijavioKvar>().ToList();
                foreach (var t in list)
                    rez.Add(new PrijavioKvarPregled(t.Id, t.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static List<TipOdgovornostiPregled> vratiSveTipoveOdgovornosti()
        {
            List<TipOdgovornostiPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<TipOdgovornosti>().ToList();
                foreach (var t in list)
                    rez.Add(new TipOdgovornostiPregled(t.Id, t.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        #endregion

        #region Vozila

        public static List<VoziloPregled> vratiSvaVozila()
        {
            List<VoziloPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var vozila = s.Query<Vozilo>().ToList();

                foreach (var v in vozila)
                {
                    rez.Add(new VoziloPregled(
                        v.Id,
                        v.RegistarskaOznaka,
                        v.Vin,
                        v.Marka,
                        v.Model,
                        v.GodinaProizvodnje,
                        v.DatumNabavke,
                        v.Status,
                        v.BrojSedista,
                        v.TipPogona?.Naziv ?? string.Empty,
                        v.TipKoriscenja?.Naziv ?? string.Empty
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju vozila", ex);
            }
            return rez;
        }

        public static VoziloBasic? vratiVozilo(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                Vozilo? v = s.Get<Vozilo>(id);
                if (v == null) return null;

                VoziloBasic vb = new()
                {
                    Id = v.Id,
                    RegistarskaOznaka = v.RegistarskaOznaka,
                    Vin = v.Vin,
                    Marka = v.Marka,
                    Model = v.Model,
                    GodinaProizvodnje = v.GodinaProizvodnje,
                    DatumNabavke = v.DatumNabavke,
                    Status = v.Status,
                    BrojSedista = v.BrojSedista,
                    StanjeEnterijera = v.StanjeEnterijera,
                    StanjeEksterijera = v.StanjeEksterijera,
                    OgranicenjaKoriscenja = v.OgranicenjaKoriscenja,
                    TipKoriscenjaId = v.TipKoriscenja?.Id ?? 0,
                    TipKoriscenjaNaziv = v.TipKoriscenja?.Naziv ?? string.Empty,
                    TipPogonaId = v.TipPogona?.Id ?? 0,
                    TipPogonaNaziv = v.TipPogona?.Naziv ?? string.Empty
                };

                if (v is ElektricnoVozilo ev)
                {
                    vb.KapacitetBaterije = ev.KapacitetBaterije;
                    vb.TrenutniNivoNapunjenosti = ev.TrenutniNivoNapunjenosti;
                    vb.Autonomija = ev.Autonomija;
                    vb.TipPunjenja = ev.TipPunjenja;
                    vb.BrojCiklusaPunjenja = ev.BrojCiklusaPunjenja;
                }
                else if (v is HibridnoVozilo hv)
                {
                    vb.KapacitetBaterije = hv.KapacitetBaterije;
                    vb.TipHibridnogPogona = hv.TipHibridnogPogona;
                }
                else if (v is KlasicnoVozilo kv)
                {
                    vb.TipGoriva = kv.TipGoriva;
                    vb.ZapreminaRezervoara = kv.ZapreminaRezervoara;
                    vb.ProsecnaPotrosnja = kv.ProsecnaPotrosnja;
                }

                return vb;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajVozilo(VoziloBasic vb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                TipPogona? tp = s.Get<TipPogona>(vb.TipPogonaId);
                if (tp == null) return false;

                string nazivPogona = tp.Naziv.ToLowerInvariant();
                Vozilo v;
                if (nazivPogona.Contains("elektri") || nazivPogona.Contains("el"))
                {
                    v = new ElektricnoVozilo
                    {
                        KapacitetBaterije = vb.KapacitetBaterije,
                        TrenutniNivoNapunjenosti = vb.TrenutniNivoNapunjenosti,
                        Autonomija = vb.Autonomija,
                        TipPunjenja = vb.TipPunjenja,
                        BrojCiklusaPunjenja = vb.BrojCiklusaPunjenja
                    };
                }
                else if (nazivPogona.Contains("hibrid") || nazivPogona.Contains("hib"))
                {
                    v = new HibridnoVozilo
                    {
                        KapacitetBaterije = vb.KapacitetBaterije,
                        TipHibridnogPogona = vb.TipHibridnogPogona
                    };
                }
                else if (nazivPogona.Contains("klasi") || nazivPogona.Contains("klas"))
                {
                    v = new KlasicnoVozilo
                    {
                        TipGoriva = vb.TipGoriva,
                        ZapreminaRezervoara = vb.ZapreminaRezervoara,
                        ProsecnaPotrosnja = vb.ProsecnaPotrosnja
                    };
                }
                else
                {
                    v = new Vozilo();
                }

                v.RegistarskaOznaka = vb.RegistarskaOznaka;
                v.Vin = vb.Vin;
                v.Marka = vb.Marka;
                v.Model = vb.Model;
                v.GodinaProizvodnje = vb.GodinaProizvodnje;
                v.DatumNabavke = vb.DatumNabavke;
                v.Status = vb.Status;
                v.BrojSedista = vb.BrojSedista;
                v.StanjeEnterijera = vb.StanjeEnterijera;
                v.StanjeEksterijera = vb.StanjeEksterijera;
                v.OgranicenjaKoriscenja = vb.OgranicenjaKoriscenja;

                if (vb.TipKoriscenjaId > 0)
                    v.TipKoriscenja = s.Load<TipKoriscenja>(vb.TipKoriscenjaId);

                if (vb.TipPogonaId > 0)
                    v.TipPogona = s.Load<TipPogona>(vb.TipPogonaId);

                s.Save(v);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodavanju vozila", ex);
            }
        }

        public static bool azurirajVozilo(VoziloBasic vb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Vozilo? v = s.Get<Vozilo>(vb.Id);
                if (v == null) return false;

                v.RegistarskaOznaka = vb.RegistarskaOznaka;
                v.Vin = vb.Vin;
                v.Marka = vb.Marka;
                v.Model = vb.Model;
                v.GodinaProizvodnje = vb.GodinaProizvodnje;
                v.DatumNabavke = vb.DatumNabavke;
                v.Status = vb.Status;
                v.BrojSedista = vb.BrojSedista;
                v.StanjeEnterijera = vb.StanjeEnterijera;
                v.StanjeEksterijera = vb.StanjeEksterijera;
                v.OgranicenjaKoriscenja = vb.OgranicenjaKoriscenja;

                if (vb.TipKoriscenjaId > 0)
                    v.TipKoriscenja = s.Load<TipKoriscenja>(vb.TipKoriscenjaId);

                if (vb.TipPogonaId > 0)
                    v.TipPogona = s.Load<TipPogona>(vb.TipPogonaId);

                if (v is ElektricnoVozilo ev)
                {
                    ev.KapacitetBaterije = vb.KapacitetBaterije;
                    ev.TrenutniNivoNapunjenosti = vb.TrenutniNivoNapunjenosti;
                    ev.Autonomija = vb.Autonomija;
                    ev.TipPunjenja = vb.TipPunjenja;
                    ev.BrojCiklusaPunjenja = vb.BrojCiklusaPunjenja;
                }
                else if (v is HibridnoVozilo hv)
                {
                    hv.KapacitetBaterije = vb.KapacitetBaterije;
                    hv.TipHibridnogPogona = vb.TipHibridnogPogona;
                }
                else if (v is KlasicnoVozilo kv)
                {
                    kv.TipGoriva = vb.TipGoriva;
                    kv.ZapreminaRezervoara = vb.ZapreminaRezervoara;
                    kv.ProsecnaPotrosnja = vb.ProsecnaPotrosnja;
                }

                s.Update(v);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju vozila", ex);
            }
        }

        public static bool obrisiVozilo(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Vozilo? v = s.Get<Vozilo>(id);
                if (v != null)
                {
                    s.Delete(v);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju vozila", ex);
            }
        }

        #endregion

        #region Oprema

        public static List<OpremaPregled> vratiSvuOpremu()
        {
            List<OpremaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<Oprema>().ToList();
                foreach (var o in list)
                    rez.Add(new OpremaPregled(o.Id, o.Naziv, o.Opis));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static bool dodajOpremu(OpremaPregled op)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Oprema o = new()
                {
                    Naziv = op.Naziv,
                    Opis = op.Opis
                };
                s.Save(o);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool azurirajOpremu(OpremaPregled op)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Oprema? o = s.Get<Oprema>(op.Id);
                if (o == null) return false;

                o.Naziv = op.Naziv;
                o.Opis = op.Opis;

                s.Update(o);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool obrisiOpremu(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Oprema? o = s.Get<Oprema>(id);
                if (o != null)
                {
                    s.Delete(o);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static List<VoziloOpremaPregled> vratiOpremuZaVozilo(int voziloId)
        {
            List<VoziloOpremaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<VoziloOprema>()
                            .Where(vo => vo.Vozilo.Id == voziloId)
                            .ToList();

                foreach (var vo in list)
                {
                    rez.Add(new VoziloOpremaPregled(
                        vo.Vozilo.Id,
                        $"{vo.Vozilo.Marka} {vo.Vozilo.Model} ({vo.Vozilo.RegistarskaOznaka})",
                        vo.Oprema.Id,
                        vo.Oprema.Naziv,
                        vo.Oprema.Opis,
                        vo.IsDodatna
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static bool dodajOpremuVozilu(int voziloId, int opremaId, bool isDodatna)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Vozilo? v = s.Get<Vozilo>(voziloId);
                Oprema? o = s.Get<Oprema>(opremaId);

                if (v == null || o == null) return false;

                VoziloOprema vo = new()
                {
                    Vozilo = v,
                    Oprema = o,
                    IsDodatna = isDodatna
                };

                s.Save(vo);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodeli opreme vozilu", ex);
            }
        }

        public static bool obrisiOpremuSaVozila(int voziloId, int opremaId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var vo = s.Query<VoziloOprema>()
                          .FirstOrDefault(x => x.Vozilo.Id == voziloId && x.Oprema.Id == opremaId);

                if (vo != null)
                {
                    s.Delete(vo);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        #endregion

        #region Korisnici

        public static List<TipKorisnikaPregled> vratiSveTipoveKorisnika()
        {
            List<TipKorisnikaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<TipKorisnika>().ToList();
                foreach (var t in list)
                    rez.Add(new TipKorisnikaPregled(t.Id, t.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static List<UlogaPregled> vratiSveUloge()
        {
            List<UlogaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<Uloga>().ToList();
                foreach (var u in list)
                    rez.Add(new UlogaPregled(u.Id, u.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static List<KorisnikPregled> vratiSveKorisnike()
        {
            List<KorisnikPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var korisnici = s.Query<Korisnik>().ToList();

                foreach (var k in korisnici)
                {
                    string prikaz;
                    if (k is FizickoLice fl)
                        prikaz = $"{fl.Ime} {fl.Prezime}";
                    else if (k is PravnoLice pl)
                        prikaz = pl.Naziv;
                    else
                        prikaz = $"Korisnik #{k.Id}";

                    rez.Add(new KorisnikPregled(
                        k.Id,
                        prikaz,
                        k.EmailAdresa,
                        k.StatusNaloga,
                        k.TipKorisnika?.Naziv ?? string.Empty,
                        k.DatumRegistracije
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju korisnika", ex);
            }
            return rez;
        }

        public static List<KorisnikPregled> vratiSvaFizickaLica()
        {
            List<KorisnikPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var fizickaLica = s.Query<FizickoLice>().ToList();

                foreach (var fl in fizickaLica)
                {
                    rez.Add(new KorisnikPregled(
                        fl.Id,
                        $"{fl.Ime} {fl.Prezime}",
                        fl.EmailAdresa,
                        fl.StatusNaloga,
                        fl.TipKorisnika?.Naziv ?? string.Empty,
                        fl.DatumRegistracije
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju fizičkih lica", ex);
            }
            return rez;
        }

        public static KorisnikBasic? vratiKorisnika(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                Korisnik? k = s.Get<Korisnik>(id);
                if (k == null) return null;

                KorisnikBasic kb = new()
                {
                    Id = k.Id,
                    Adresa = k.Adresa,
                    EmailAdresa = k.EmailAdresa,
                    DatumRegistracije = k.DatumRegistracije,
                    StatusNaloga = k.StatusNaloga,
                    NacinVerifikacije = k.NacinVerifikacije,
                    TipKorisnikaId = k.TipKorisnika?.Id ?? 0,
                    TipKorisnikaNaziv = k.TipKorisnika?.Naziv ?? string.Empty
                };

                if (k is FizickoLice fl)
                {
                    kb.Jmbg = fl.Jmbg;
                    kb.Ime = fl.Ime;
                    kb.Prezime = fl.Prezime;
                    kb.BrojVozackeDozvole = fl.BrojVozackeDozvole;
                    kb.KategorijeDozvole = fl.KategorijeDozvole;
                    kb.DatumIzdavanjaDozvole = fl.DatumIzdavanjaDozvole;
                    kb.DatumIstekaDozvole = fl.DatumIstekaDozvole;
                }
                else if (k is PravnoLice pl)
                {
                    kb.Naziv = pl.Naziv;
                    kb.Pib = pl.Pib;
                    kb.MaticniBroj = pl.MaticniBroj;
                    kb.Sediste = pl.Sediste;
                    kb.KontaktOsoba = pl.KontaktOsoba;
                    kb.UgovoreniUsloviKoriscenja = pl.UgovoreniUsloviKoriscenja;
                }

                return kb;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajKorisnika(KorisnikBasic kb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                TipKorisnika? tk = s.Get<TipKorisnika>(kb.TipKorisnikaId);
                if (tk == null) return false;

                string nazivTipa = tk.Naziv.ToLowerInvariant();
                Korisnik k;

                if (nazivTipa.Contains("fizic") || nazivTipa.Contains("fizič"))
                {
                    k = new FizickoLice
                    {
                        Jmbg = kb.Jmbg,
                        Ime = kb.Ime,
                        Prezime = kb.Prezime,
                        BrojVozackeDozvole = kb.BrojVozackeDozvole,
                        KategorijeDozvole = kb.KategorijeDozvole,
                        DatumIzdavanjaDozvole = kb.DatumIzdavanjaDozvole,
                        DatumIstekaDozvole = kb.DatumIstekaDozvole
                    };
                }
                else if (nazivTipa.Contains("pravn"))
                {
                    k = new PravnoLice
                    {
                        Naziv = kb.Naziv,
                        Pib = kb.Pib,
                        MaticniBroj = kb.MaticniBroj,
                        Sediste = kb.Sediste,
                        KontaktOsoba = kb.KontaktOsoba,
                        UgovoreniUsloviKoriscenja = kb.UgovoreniUsloviKoriscenja
                    };
                }
                else
                {
                    k = new Korisnik();
                }

                k.Adresa = kb.Adresa;
                k.EmailAdresa = kb.EmailAdresa;
                k.DatumRegistracije = kb.DatumRegistracije;
                k.StatusNaloga = kb.StatusNaloga;
                k.NacinVerifikacije = kb.NacinVerifikacije;
                k.TipKorisnika = tk;

                s.Save(k);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodavanju korisnika", ex);
            }
        }

        public static bool azurirajKorisnika(KorisnikBasic kb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Korisnik? k = s.Get<Korisnik>(kb.Id);
                if (k == null) return false;

                k.Adresa = kb.Adresa;
                k.EmailAdresa = kb.EmailAdresa;
                k.DatumRegistracije = kb.DatumRegistracije;
                k.StatusNaloga = kb.StatusNaloga;
                k.NacinVerifikacije = kb.NacinVerifikacije;

                if (kb.TipKorisnikaId > 0 && (k.TipKorisnika == null || k.TipKorisnika.Id != kb.TipKorisnikaId))
                    k.TipKorisnika = s.Load<TipKorisnika>(kb.TipKorisnikaId);

                if (k is FizickoLice fl)
                {
                    fl.Jmbg = kb.Jmbg;
                    fl.Ime = kb.Ime;
                    fl.Prezime = kb.Prezime;
                    fl.BrojVozackeDozvole = kb.BrojVozackeDozvole;
                    fl.KategorijeDozvole = kb.KategorijeDozvole;
                    fl.DatumIzdavanjaDozvole = kb.DatumIzdavanjaDozvole;
                    fl.DatumIstekaDozvole = kb.DatumIstekaDozvole;
                }
                else if (k is PravnoLice pl)
                {
                    pl.Naziv = kb.Naziv;
                    pl.Pib = kb.Pib;
                    pl.MaticniBroj = kb.MaticniBroj;
                    pl.Sediste = kb.Sediste;
                    pl.KontaktOsoba = kb.KontaktOsoba;
                    pl.UgovoreniUsloviKoriscenja = kb.UgovoreniUsloviKoriscenja;
                }

                s.Update(k);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju korisnika", ex);
            }
        }

        public static bool obrisiKorisnika(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Korisnik? k = s.Get<Korisnik>(id);
                if (k != null)
                {
                    s.Delete(k);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju korisnika", ex);
            }
        }

        #endregion

        #region DodatniPodaciKorisnika

        public static List<TelefonPregled> vratiTelefoneKorisnika(int korisnikId)
        {
            List<TelefonPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<TelefonKorisnika>()
                            .Where(t => t.Korisnik.Id == korisnikId)
                            .ToList();
                foreach (var t in list)
                    rez.Add(new TelefonPregled(t.Id, t.BrojTelefona));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static bool dodajTelefonKorisniku(int korisnikId, string brojTelefona)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Korisnik? k = s.Get<Korisnik>(korisnikId);
                if (k == null) return false;

                TelefonKorisnika t = new()
                {
                    Korisnik = k,
                    BrojTelefona = brojTelefona
                };

                s.Save(t);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodavanju telefona", ex);
            }
        }

        public static bool obrisiTelefonKorisnika(int telefonId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var t = s.Get<TelefonKorisnika>(telefonId);
                if (t != null)
                {
                    s.Delete(t);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static List<VerifikacijaPregled> vratiVerifikacijeKorisnika(int korisnikId)
        {
            List<VerifikacijaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<VerifikacijaKorisnika>()
                            .Where(v => v.Korisnik.Id == korisnikId)
                            .ToList();
                foreach (var v in list)
                    rez.Add(new VerifikacijaPregled(v.Id, v.DatumVerifikacije, v.Verifikator, v.Rezultat, v.Ogranicenja));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static bool dodajVerifikacijuKorisniku(int korisnikId, DateTime datum, string verifikator, string rezultat, string? ogranicenja)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Korisnik? k = s.Get<Korisnik>(korisnikId);
                if (k == null) return false;

                VerifikacijaKorisnika v = new()
                {
                    Korisnik = k,
                    DatumVerifikacije = datum,
                    Verifikator = verifikator,
                    Rezultat = rezultat,
                    Ogranicenja = ogranicenja
                };

                s.Save(v);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodavanju verifikacije", ex);
            }
        }

        public static bool obrisiVerifikacijuKorisnika(int verifikacijaId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var v = s.Get<VerifikacijaKorisnika>(verifikacijaId);
                if (v != null)
                {
                    s.Delete(v);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static List<NacinPlacanjaPregled> vratiNacinePlacanjaKorisnika(int korisnikId)
        {
            List<NacinPlacanjaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<NacinPlacanja>()
                            .Where(n => n.Korisnik.Id == korisnikId)
                            .ToList();
                foreach (var n in list)
                    rez.Add(new NacinPlacanjaPregled(n.Id, n.TipPlacanja, n.Status, n.DatumDodavanja, n.Ogranicenja));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static bool dodajNacinPlacanjaKorisniku(int korisnikId, string tip, string status, DateTime datumDodavanja, string? ogranicenja)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Korisnik? k = s.Get<Korisnik>(korisnikId);
                if (k == null) return false;

                NacinPlacanja n = new()
                {
                    Korisnik = k,
                    TipPlacanja = tip,
                    Status = status,
                    DatumDodavanja = datumDodavanja,
                    Ogranicenja = ogranicenja
                };

                s.Save(n);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodavanju načina plaćanja", ex);
            }
        }

        public static bool obrisiNacinPlacanjaKorisnika(int nacinId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var n = s.Get<NacinPlacanja>(nacinId);
                if (n != null)
                {
                    s.Delete(n);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        #endregion

        #region UlogeKorisnika

        public static bool dodajUlogu(UlogaPregled up)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Uloga u = new()
                {
                    Naziv = up.Naziv
                };
                s.Save(u);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool azurirajUlogu(UlogaPregled up)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Uloga? u = s.Get<Uloga>(up.Id);
                if (u == null) return false;

                u.Naziv = up.Naziv;

                s.Update(u);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool obrisiUlogu(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Uloga? u = s.Get<Uloga>(id);
                if (u != null)
                {
                    s.Delete(u);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static List<UlogaPregled> vratiUlogeZaKorisnika(int korisnikId)
        {
            List<UlogaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var list = s.Query<KorisnikUloga>()
                            .Where(ku => ku.Korisnik.Id == korisnikId)
                            .ToList();

                foreach (var ku in list)
                    rez.Add(new UlogaPregled(ku.Uloga.Id, ku.Uloga.Naziv));
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static bool dodajUloguKorisniku(int korisnikId, int ulogaId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Korisnik? k = s.Get<Korisnik>(korisnikId);
                Uloga? u = s.Get<Uloga>(ulogaId);

                if (k == null || u == null) return false;

                bool vecPostoji = s.Query<KorisnikUloga>()
                                    .Any(x => x.Korisnik.Id == korisnikId && x.Uloga.Id == ulogaId);
                if (vecPostoji) return false;

                KorisnikUloga ku = new()
                {
                    Korisnik = k,
                    Uloga = u
                };

                s.Save(ku);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodeli uloge korisniku", ex);
            }
        }

        public static bool obrisiUloguSaKorisnika(int korisnikId, int ulogaId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var ku = s.Query<KorisnikUloga>()
                          .FirstOrDefault(x => x.Korisnik.Id == korisnikId && x.Uloga.Id == ulogaId);

                if (ku != null)
                {
                    s.Delete(ku);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        #endregion

        #region PunjenjeTocenje

        public static List<PunjenjeTocenjePregled> vratiSvaPunjenjaTocenja(int? voziloId = null)
        {
            List<PunjenjeTocenjePregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var q = s.Query<PunjenjeTocenje>();
                if (voziloId.HasValue && voziloId.Value > 0)
                    q = q.Where(x => x.Vozilo.Id == voziloId.Value);

                var list = q.ToList();
                foreach (var p in list)
                {
                    rez.Add(new PunjenjeTocenjePregled(
                        p.Id,
                        p.Vozilo.Id,
                        $"{p.Vozilo.Marka} {p.Vozilo.Model} ({p.Vozilo.RegistarskaOznaka})",
                        p.DatumVreme,
                        p.Lokacija,
                        p.Kolicina,
                        p.Cena,
                        p.NacinEvidentiranja,
                        p.Evidentirao
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static PunjenjeTocenjeBasic? vratiPunjenjeTocenje(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var p = s.Get<PunjenjeTocenje>(id);
                if (p == null) return null;

                return new PunjenjeTocenjeBasic
                {
                    Id = p.Id,
                    VoziloId = p.Vozilo.Id,
                    DatumVreme = p.DatumVreme,
                    Lokacija = p.Lokacija,
                    Kolicina = p.Kolicina,
                    Cena = p.Cena,
                    NacinEvidentiranja = p.NacinEvidentiranja,
                    Evidentirao = p.Evidentirao
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajPunjenjeTocenje(PunjenjeTocenjeBasic pb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Vozilo? v = s.Get<Vozilo>(pb.VoziloId);
                if (v == null) return false;

                PunjenjeTocenje p = new()
                {
                    Vozilo = v,
                    DatumVreme = pb.DatumVreme,
                    Lokacija = pb.Lokacija,
                    Kolicina = pb.Kolicina,
                    Cena = pb.Cena,
                    NacinEvidentiranja = pb.NacinEvidentiranja,
                    Evidentirao = pb.Evidentirao
                };

                s.Save(p);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodavanju punjenja/točenja", ex);
            }
        }

        public static bool azurirajPunjenjeTocenje(PunjenjeTocenjeBasic pb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                PunjenjeTocenje? p = s.Get<PunjenjeTocenje>(pb.Id);
                if (p == null) return false;

                if (pb.VoziloId > 0 && p.Vozilo.Id != pb.VoziloId)
                    p.Vozilo = s.Load<Vozilo>(pb.VoziloId);

                p.DatumVreme = pb.DatumVreme;
                p.Lokacija = pb.Lokacija;
                p.Kolicina = pb.Kolicina;
                p.Cena = pb.Cena;
                p.NacinEvidentiranja = pb.NacinEvidentiranja;
                p.Evidentirao = pb.Evidentirao;

                s.Update(p);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju punjenja/točenja", ex);
            }
        }

        public static bool obrisiPunjenjeTocenje(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var p = s.Get<PunjenjeTocenje>(id);
                if (p != null)
                {
                    s.Delete(p);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        #endregion

        #region Servisi

        public static List<ServisPregled> vratiSveServise(int? voziloId = null)
        {
            List<ServisPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var q = s.Query<Servis>();
                if (voziloId.HasValue && voziloId.Value > 0)
                    q = q.Where(x => x.Vozilo.Id == voziloId.Value);

                var list = q.ToList();
                foreach (var srv in list)
                {
                    rez.Add(new ServisPregled(
                        srv.Id,
                        srv.Vozilo.Id,
                        $"{srv.Vozilo.Marka} {srv.Vozilo.Model} ({srv.Vozilo.RegistarskaOznaka})",
                        srv.TipServisa?.Naziv ?? string.Empty,
                        srv.ServisniCentar,
                        srv.DatumPrijema,
                        srv.DatumZavrsetka,
                        srv.Troskovi,
                        srv.Status
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static ServisBasic? vratiServis(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var srv = s.Get<Servis>(id);
                if (srv == null) return null;

                return new ServisBasic
                {
                    Id = srv.Id,
                    VoziloId = srv.Vozilo.Id,
                    TipServisaId = srv.TipServisa?.Id ?? 0,
                    ServisniCentar = srv.ServisniCentar,
                    DatumPrijema = srv.DatumPrijema,
                    DatumZavrsetka = srv.DatumZavrsetka,
                    OpisRadova = srv.OpisRadova,
                    ZamenjeniDelovi = srv.ZamenjeniDelovi,
                    Troskovi = srv.Troskovi,
                    Status = srv.Status
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajServis(ServisBasic sb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Vozilo? v = s.Get<Vozilo>(sb.VoziloId);
                TipServisa? ts = s.Get<TipServisa>(sb.TipServisaId);

                if (v == null || ts == null) return false;

                Servis srv = new()
                {
                    Vozilo = v,
                    TipServisa = ts,
                    ServisniCentar = sb.ServisniCentar,
                    DatumPrijema = sb.DatumPrijema,
                    DatumZavrsetka = sb.DatumZavrsetka,
                    OpisRadova = sb.OpisRadova,
                    ZamenjeniDelovi = sb.ZamenjeniDelovi,
                    Troskovi = sb.Troskovi,
                    Status = sb.Status
                };

                s.Save(srv);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri evidentiranju servisa", ex);
            }
        }

        public static bool azurirajServis(ServisBasic sb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Servis? srv = s.Get<Servis>(sb.Id);
                if (srv == null) return false;

                if (sb.VoziloId > 0 && srv.Vozilo.Id != sb.VoziloId)
                    srv.Vozilo = s.Load<Vozilo>(sb.VoziloId);

                if (sb.TipServisaId > 0 && srv.TipServisa.Id != sb.TipServisaId)
                    srv.TipServisa = s.Load<TipServisa>(sb.TipServisaId);

                srv.ServisniCentar = sb.ServisniCentar;
                srv.DatumPrijema = sb.DatumPrijema;
                srv.DatumZavrsetka = sb.DatumZavrsetka;
                srv.OpisRadova = sb.OpisRadova;
                srv.ZamenjeniDelovi = sb.ZamenjeniDelovi;
                srv.Troskovi = sb.Troskovi;
                srv.Status = sb.Status;

                s.Update(srv);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju servisa", ex);
            }
        }

        public static bool obrisiServis(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var srv = s.Get<Servis>(id);
                if (srv != null)
                {
                    s.Delete(srv);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        #endregion

        #region Kvarovi

        public static List<KvarPregled> vratiSveKvarove(int? voziloId = null)
        {
            List<KvarPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var q = s.Query<Kvar>();
                if (voziloId.HasValue && voziloId.Value > 0)
                    q = q.Where(x => x.Vozilo.Id == voziloId.Value);

                var list = q.ToList();
                foreach (var k in list)
                {
                    rez.Add(new KvarPregled(
                        k.Id,
                        k.Vozilo.Id,
                        $"{k.Vozilo.Marka} {k.Vozilo.Model} ({k.Vozilo.RegistarskaOznaka})",
                        k.Prijavio?.Naziv ?? string.Empty,
                        k.DatumPrijave,
                        k.OpisProblema,
                        k.ProcenaOzbiljnosti,
                        k.Status,
                        k.DatumOtklanjanja
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static KvarBasic? vratiKvar(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var k = s.Get<Kvar>(id);
                if (k == null) return null;

                return new KvarBasic
                {
                    Id = k.Id,
                    VoziloId = k.Vozilo.Id,
                    PrijavioId = k.Prijavio?.Id ?? 0,
                    DatumPrijave = k.DatumPrijave,
                    OpisProblema = k.OpisProblema,
                    ProcenaOzbiljnosti = k.ProcenaOzbiljnosti,
                    Status = k.Status,
                    DatumOtklanjanja = k.DatumOtklanjanja
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajKvar(KvarBasic kb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Vozilo? v = s.Get<Vozilo>(kb.VoziloId);
                PrijavioKvar? pk = s.Get<PrijavioKvar>(kb.PrijavioId);

                if (v == null || pk == null) return false;

                Kvar k = new()
                {
                    Vozilo = v,
                    Prijavio = pk,
                    DatumPrijave = kb.DatumPrijave,
                    OpisProblema = kb.OpisProblema,
                    ProcenaOzbiljnosti = kb.ProcenaOzbiljnosti,
                    Status = kb.Status,
                    DatumOtklanjanja = kb.DatumOtklanjanja
                };

                s.Save(k);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri prijavi kvara", ex);
            }
        }

        public static bool azurirajKvar(KvarBasic kb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Kvar? k = s.Get<Kvar>(kb.Id);
                if (k == null) return false;

                if (kb.VoziloId > 0 && k.Vozilo.Id != kb.VoziloId)
                    k.Vozilo = s.Load<Vozilo>(kb.VoziloId);

                if (kb.PrijavioId > 0 && k.Prijavio.Id != kb.PrijavioId)
                    k.Prijavio = s.Load<PrijavioKvar>(kb.PrijavioId);

                k.DatumPrijave = kb.DatumPrijave;
                k.OpisProblema = kb.OpisProblema;
                k.ProcenaOzbiljnosti = kb.ProcenaOzbiljnosti;
                k.Status = kb.Status;
                k.DatumOtklanjanja = kb.DatumOtklanjanja;

                s.Update(k);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju kvara", ex);
            }
        }

        public static bool obrisiKvar(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var k = s.Get<Kvar>(id);
                if (k != null)
                {
                    s.Delete(k);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        #endregion

        #region NezgodeStete

        public static List<NezgodaStetaPregled> vratiSveNezgodeStete(int? voziloId = null)
        {
            List<NezgodaStetaPregled> rez = new();
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var q = s.Query<NezgodaSteta>();
                if (voziloId.HasValue && voziloId.Value > 0)
                    q = q.Where(x => x.Vozilo.Id == voziloId.Value);

                var list = q.ToList();
                foreach (var n in list)
                {
                    rez.Add(new NezgodaStetaPregled(
                        n.Id,
                        n.Vozilo.Id,
                        $"{n.Vozilo.Marka} {n.Vozilo.Model} ({n.Vozilo.RegistarskaOznaka})",
                        n.Odgovornost?.Naziv ?? string.Empty,
                        n.ProcenaStete,
                        n.Fotografije.Count,
                        n.OsiguravajuceKuce.Count,
                        n.Zapisnici.Count
                    ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
            return rez;
        }

        public static NezgodaStetaBasic? vratiNezgoduStetu(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                var n = s.Get<NezgodaSteta>(id);
                if (n == null) return null;

                NezgodaStetaBasic nb = new()
                {
                    Id = n.Id,
                    VoziloId = n.Vozilo.Id,
                    OdgovornostId = n.Odgovornost?.Id ?? 0,
                    ProcenaStete = n.ProcenaStete
                };

                foreach (var f in n.Fotografije)
                    nb.Fotografije.Add(new NezgodaFotografijaPregled(f.Id, f.FotografijaUrl));

                foreach (var k in n.OsiguravajuceKuce)
                    nb.OsiguravajuceKuce.Add(new NezgodaOsiguravajucaKucaPregled(k.Id, k.OsiguravajucaKuca));

                foreach (var z in n.Zapisnici)
                    nb.Zapisnici.Add(new NezgodaZapisnikPregled(z.Id, z.ZapisnikUrl));

                return nb;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajNezgoduStetu(NezgodaStetaBasic nb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                Vozilo? v = s.Get<Vozilo>(nb.VoziloId);
                TipOdgovornosti? o = s.Get<TipOdgovornosti>(nb.OdgovornostId);

                if (v == null || o == null) return false;

                NezgodaSteta n = new()
                {
                    Vozilo = v,
                    Odgovornost = o,
                    ProcenaStete = nb.ProcenaStete
                };

                s.Save(n);

                foreach (var f in nb.Fotografije)
                {
                    s.Save(new NezgodaFotografija
                    {
                        NezgodaSteta = n,
                        FotografijaUrl = f.Url
                    });
                }

                foreach (var k in nb.OsiguravajuceKuce)
                {
                    s.Save(new NezgodaOsiguravajucaKuca
                    {
                        NezgodaSteta = n,
                        OsiguravajucaKuca = k.OsiguravajucaKuca
                    });
                }

                foreach (var z in nb.Zapisnici)
                {
                    s.Save(new NezgodaZapisnik
                    {
                        NezgodaSteta = n,
                        ZapisnikUrl = z.Url
                    });
                }

                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri unosu nezgode/štete", ex);
            }
        }

        public static bool azurirajNezgoduStetu(NezgodaStetaBasic nb)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                NezgodaSteta? n = s.Get<NezgodaSteta>(nb.Id);
                if (n == null) return false;

                if (nb.VoziloId > 0 && n.Vozilo.Id != nb.VoziloId)
                    n.Vozilo = s.Load<Vozilo>(nb.VoziloId);

                if (nb.OdgovornostId > 0 && n.Odgovornost.Id != nb.OdgovornostId)
                    n.Odgovornost = s.Load<TipOdgovornosti>(nb.OdgovornostId);

                n.ProcenaStete = nb.ProcenaStete;

                s.Update(n);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri ažuriranju nezgode/štete", ex);
            }
        }

        public static bool obrisiNezgoduStetu(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();

                var n = s.Get<NezgodaSteta>(id);
                if (n != null)
                {
                    s.Delete(n);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajFotografijuStete(int nezgodaId, string url)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();
                var n = s.Get<NezgodaSteta>(nezgodaId);
                if (n == null) return false;

                s.Save(new NezgodaFotografija { NezgodaSteta = n, FotografijaUrl = url });
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool obrisiFotografijuStete(int fotoId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();
                var f = s.Get<NezgodaFotografija>(fotoId);
                if (f != null)
                {
                    s.Delete(f);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajOsiguravajucuKucuStete(int nezgodaId, string kuca)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();
                var n = s.Get<NezgodaSteta>(nezgodaId);
                if (n == null) return false;

                s.Save(new NezgodaOsiguravajucaKuca { NezgodaSteta = n, OsiguravajucaKuca = kuca });
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool obrisiOsiguravajucuKucuStete(int kucaId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();
                var k = s.Get<NezgodaOsiguravajucaKuca>(kucaId);
                if (k != null)
                {
                    s.Delete(k);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool dodajZapisnikStete(int nezgodaId, string url)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();
                var n = s.Get<NezgodaSteta>(nezgodaId);
                if (n == null) return false;

                s.Save(new NezgodaZapisnik { NezgodaSteta = n, ZapisnikUrl = url });
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        public static bool obrisiZapisnikStete(int zapisnikId)
        {
            try
            {
                using ISession s = DataLayer.GetSession()!;
                using var tx = s.BeginTransaction();
                var z = s.Get<NezgodaZapisnik>(zapisnikId);
                if (z != null)
                {
                    s.Delete(z);
                    tx.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška", ex);
            }
        }

        #endregion
    }
}
