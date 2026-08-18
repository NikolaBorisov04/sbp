using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate
{
    #region Rezervacije
    public class RezervacijaPregled
    {
        public int Id;
        public DateTime VremePocetka;
        public DateTime VremeZavrsetka;
        public string LokacijaPreuzimanja;
        public string LokacijaVracanja;
        public string Tip;
        public string Status;
        //public Korisnik Korisnik;
        //public FizickoLice Vozac;
        public Vozilo Vozilo; // popraviti da i ovde bude dto

        public RezervacijaPregled() { }

        // popraviti da i u konstruktoru vozilo bude dto
        public RezervacijaPregled(int id, DateTime vremePocetka, DateTime vremeZavrsetka, string lokacijaPreuzimanja, string lokacijaVracanja, string tip, string status, Vozilo vozilo)
        {
            this.Id = id;
            this.VremePocetka = vremePocetka;
            this.VremeZavrsetka = vremeZavrsetka;
            this.LokacijaPreuzimanja = lokacijaPreuzimanja;
            this.LokacijaVracanja = lokacijaVracanja;
            this.Tip = tip;
            this.Status = status;
            this.Vozilo = vozilo;
        }
    }
    #endregion

    #region Voznje

    public class VoznjaPregled
    {
        public int Id;
        public DateTime VremePocetka;
        public DateTime VremeZavrsetka;
        public decimal PredjenaKilometraza;
        public int TrajanjeMinuti;
        public decimal PocetniNivo;
        public decimal KrajnjiNivo;
        public string PocetnaLokacija;
        public string KrajnjaLokacija;
        public decimal Cena;
        public decimal Naknade;
        public RezervacijaPregled Rezervacija;

        public VoznjaPregled() { }

        public VoznjaPregled(int id, DateTime vremePocetka, DateTime vremeZavrsetka, decimal predjenaKilometraza, int trajanjeMinuti, decimal pocetniNivo, decimal krajnjiNivo, string pocetnaLokacija, string krajnjaLokacija, decimal cena, decimal naknade, RezervacijaPregled rezervacija)
        {
            Id = id;
            VremePocetka = vremePocetka;
            VremeZavrsetka = vremeZavrsetka;
            PredjenaKilometraza = predjenaKilometraza;
            TrajanjeMinuti = trajanjeMinuti;
            PocetniNivo = pocetniNivo;
            KrajnjiNivo = krajnjiNivo;
            PocetnaLokacija = pocetnaLokacija;
            KrajnjaLokacija = krajnjaLokacija;
            Cena = cena;
            Naknade = naknade;
            Rezervacija = rezervacija;
        }
    }

    public class VoznjaBasic
    {
        public int Id;
        public DateTime VremePocetka;
        public DateTime VremeZavrsetka;
        public decimal PredjenaKilometraza;
        public int TrajanjeMinuti;
        public decimal PocetniNivo;
        public decimal KrajnjiNivo;
        public string PocetnaLokacija;
        public string KrajnjaLokacija;
        public decimal Cena;
        public decimal Naknade;
        public RezervacijaPregled Rezervacija;

        public virtual IList<DogadjajUVoznjiPregled> Dogadjaji { get; set; }

        public VoznjaBasic()
        {
            Dogadjaji = new List<DogadjajUVoznjiPregled>();
        }

        public VoznjaBasic(int id, DateTime vremePocetka, DateTime vremeZavrsetka, decimal predjenaKilometraza, int trajanjeMinuti, decimal pocetniNivo, decimal krajnjiNivo, string pocetnaLokacija, string krajnjaLokacija, decimal cena, decimal naknade, RezervacijaPregled rezervacija)
            : this()
        {
            Id = id;
            VremePocetka = vremePocetka;
            VremeZavrsetka = vremeZavrsetka;
            PredjenaKilometraza = predjenaKilometraza;
            TrajanjeMinuti = trajanjeMinuti;
            PocetniNivo = pocetniNivo;
            KrajnjiNivo = krajnjiNivo;
            PocetnaLokacija = pocetnaLokacija;
            KrajnjaLokacija = krajnjaLokacija;
            Cena = cena;
            Naknade = naknade;
            Rezervacija = rezervacija;
        }
    }
    #endregion

    #region SluzbeneVoznje
    public class SluzbenaVoznjaPregled : RezervacijaPregled
    {
        public string Razlog;
        public string OvlascenoLice;

        public SluzbenaVoznjaPregled() { }

        public SluzbenaVoznjaPregled(int id, DateTime vremePocetka, DateTime vremeZavrsetka, string lokacijaPreuzimanja, string lokacijaVracanja, string tip, string status, Vozilo vozilo, string razlog, string ovlascenoLice)
            : base(id, vremePocetka, vremeZavrsetka, lokacijaPreuzimanja, lokacijaVracanja, tip, status, vozilo)
        {
            Razlog = razlog;
            OvlascenoLice = ovlascenoLice;
        }
    }
    #endregion

    #region DogadjajiUVoznji
    public class DogadjajUVoznjiPregled
    {
        public int Id;
        public string Tip;
        public DateTime Vreme;
        public string Lokacija;
        public string Opis;

        public DogadjajUVoznjiPregled() { }

        public DogadjajUVoznjiPregled(int id, string tip, DateTime vreme, string lokacija, string opis)
        {
            Id = id;
            Tip = tip;
            Vreme = vreme;
            Lokacija = lokacija;
            Opis = opis;
        }
    }
    #endregion
}
