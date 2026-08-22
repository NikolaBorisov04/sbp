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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri učitavanju vožnja");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri učitavanju vožnje");
            }

            return vb;
        }

        public static VoznjaPregled dodajVoznju(VoznjaPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
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
                    Naknade = v.Naknade
                };

                s.Save(voznja);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri kreiranju vožnje");
            }

            return v;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri ažuriranju vožnje");
            }

            return v;
        }

        public static void obrisiVoznju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Voznja v = s.Load<Voznja>(id);
                s.Delete(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri brisanju vožnje");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri učitavanju događaja");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri učitavanju događaja");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri kreiranju događaja");
            }

            return d;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri ažuriranju događaja");
            }

            return d;
        }

        public static void obrisiDogadjaj(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DogadjajUVoznji dogadjaj = s.Load<DogadjajUVoznji>(id);

                if (dogadjaj != null)
                {
                    s.Delete(dogadjaj);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri brisanju događaja");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri učitavanju vozila");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return null;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri dodavanju vozila");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri ažuriranju vozila");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri brisanju vozila");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri dodeli opreme vozilu");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return null;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri dodavanju punjenja/točenja");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri ažuriranju punjenja/točenja");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return null;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri evidentiranju servisa");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri ažuriranju servisa");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return null;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri prijavi kvara");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri ažuriranju kvara");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return null;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri unosu nezgode/štete");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška pri ažuriranju nezgode/štete");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
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
                MessageBox.Show(ex.FormatExceptionMessage(), "Greška");
                return false;
            }
        }

        #endregion
    }
}
