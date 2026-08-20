using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernateTemplate.Entiteti;

namespace FluentNHibernateTemplate
{
    #region Tipovi i Katalozi
    public class TipPogonaPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public TipPogonaPregled() { }
        public TipPogonaPregled(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public override string ToString() => Naziv;
    }

    public class TipKoriscenjaPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public TipKoriscenjaPregled() { }
        public TipKoriscenjaPregled(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public override string ToString() => Naziv;
    }

    public class TipServisaPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public TipServisaPregled() { }
        public TipServisaPregled(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public override string ToString() => Naziv;
    }

    public class PrijavioKvarPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public PrijavioKvarPregled() { }
        public PrijavioKvarPregled(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public override string ToString() => Naziv;
    }

    public class TipOdgovornostiPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public TipOdgovornostiPregled() { }
        public TipOdgovornostiPregled(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public override string ToString() => Naziv;
    }
    #endregion

    #region Vozila
    public class VoziloPregled
    {
        public int Id { get; set; }
        public string RegistarskaOznaka { get; set; } = string.Empty;
        public string Vin { get; set; } = string.Empty;
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int GodinaProizvodnje { get; set; }
        public DateTime DatumNabavke { get; set; }
        public string Status { get; set; } = string.Empty;
        public int BrojSedista { get; set; }
        public string TipPogona { get; set; } = string.Empty;
        public string TipKoriscenja { get; set; } = string.Empty;
        public string Podtip { get; set; } = string.Empty;

        public VoziloPregled() { }

        public VoziloPregled(int id, string registarskaOznaka, string vin, string marka, string model, int godinaProizvodnje, DateTime datumNabavke, string status, int brojSedista, string tipPogona, string tipKoriscenja, string podtip)
        {
            Id = id;
            RegistarskaOznaka = registarskaOznaka;
            Vin = vin;
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            DatumNabavke = datumNabavke;
            Status = status;
            BrojSedista = brojSedista;
            TipPogona = tipPogona;
            TipKoriscenja = tipKoriscenja;
            Podtip = podtip;
        }

        public override string ToString() => $"{Marka} {Model} ({RegistarskaOznaka})";
    }

    public class VoziloBasic
    {
        public int Id { get; set; }
        public string RegistarskaOznaka { get; set; } = string.Empty;
        public string Vin { get; set; } = string.Empty;
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int GodinaProizvodnje { get; set; }
        public DateTime DatumNabavke { get; set; }
        public string Status { get; set; } = string.Empty;
        public int BrojSedista { get; set; }
        public string? StanjeEnterijera { get; set; }
        public string? StanjeEksterijera { get; set; }
        public string? OgranicenjaKoriscenja { get; set; }

        public int TipKoriscenjaId { get; set; }
        public string TipKoriscenjaNaziv { get; set; } = string.Empty;
        public int TipPogonaId { get; set; }
        public string TipPogonaNaziv { get; set; } = string.Empty;

        public string Podtip { get; set; } = "Osnovno";

        // Elektricno
        public decimal KapacitetBaterije { get; set; }
        public decimal TrenutniNivoNapunjenosti { get; set; }
        public int Autonomija { get; set; }
        public string TipPunjenja { get; set; } = string.Empty;
        public int BrojCiklusaPunjenja { get; set; }

        // Hibridno
        public string TipHibridnogPogona { get; set; } = string.Empty;

        // Klasicno
        public string TipGoriva { get; set; } = string.Empty;
        public decimal ZapreminaRezervoara { get; set; }
        public decimal ProsecnaPotrosnja { get; set; }

        public VoziloBasic() { }
    }
    #endregion

    #region Oprema
    public class OpremaPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;
        public string? Opis { get; set; }

        public OpremaPregled() { }

        public OpremaPregled(int id, string naziv, string? opis)
        {
            Id = id;
            Naziv = naziv;
            Opis = opis;
        }

        public override string ToString() => Naziv;
    }

    public class VoziloOpremaPregled
    {
        public int VoziloId { get; set; }
        public string VoziloOznaka { get; set; } = string.Empty;
        public int OpremaId { get; set; }
        public string OpremaNaziv { get; set; } = string.Empty;
        public string? OpremaOpis { get; set; }
        public bool IsDodatna { get; set; }

        public VoziloOpremaPregled() { }

        public VoziloOpremaPregled(int voziloId, string voziloOznaka, int opremaId, string opremaNaziv, string? opremaOpis, bool isDodatna)
        {
            VoziloId = voziloId;
            VoziloOznaka = voziloOznaka;
            OpremaId = opremaId;
            OpremaNaziv = opremaNaziv;
            OpremaOpis = opremaOpis;
            IsDodatna = isDodatna;
        }
    }
    #endregion

    #region PunjenjeTocenje
    public class PunjenjeTocenjePregled
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public string VoziloInfo { get; set; } = string.Empty;
        public DateTime DatumVreme { get; set; }
        public string Lokacija { get; set; } = string.Empty;
        public decimal Kolicina { get; set; }
        public decimal Cena { get; set; }
        public string NacinEvidentiranja { get; set; } = string.Empty;
        public string Evidentirao { get; set; } = string.Empty;

        public PunjenjeTocenjePregled() { }

        public PunjenjeTocenjePregled(int id, int voziloId, string voziloInfo, DateTime datumVreme, string lokacija, decimal kolicina, decimal cena, string nacinEvidentiranja, string evidentirao)
        {
            Id = id;
            VoziloId = voziloId;
            VoziloInfo = voziloInfo;
            DatumVreme = datumVreme;
            Lokacija = lokacija;
            Kolicina = kolicina;
            Cena = cena;
            NacinEvidentiranja = nacinEvidentiranja;
            Evidentirao = evidentirao;
        }
    }

    public class PunjenjeTocenjeBasic
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public DateTime DatumVreme { get; set; }
        public string Lokacija { get; set; } = string.Empty;
        public decimal Kolicina { get; set; }
        public decimal Cena { get; set; }
        public string NacinEvidentiranja { get; set; } = string.Empty;
        public string Evidentirao { get; set; } = string.Empty;

        public PunjenjeTocenjeBasic() { }
    }
    #endregion

    #region Servisi
    public class ServisPregled
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public string VoziloInfo { get; set; } = string.Empty;
        public string TipServisa { get; set; } = string.Empty;
        public string ServisniCentar { get; set; } = string.Empty;
        public DateTime DatumPrijema { get; set; }
        public DateTime? DatumZavrsetka { get; set; }
        public decimal Troskovi { get; set; }
        public string Status { get; set; } = string.Empty;

        public ServisPregled() { }

        public ServisPregled(int id, int voziloId, string voziloInfo, string tipServisa, string servisniCentar, DateTime datumPrijema, DateTime? datumZavrsetka, decimal troskovi, string status)
        {
            Id = id;
            VoziloId = voziloId;
            VoziloInfo = voziloInfo;
            TipServisa = tipServisa;
            ServisniCentar = servisniCentar;
            DatumPrijema = datumPrijema;
            DatumZavrsetka = datumZavrsetka;
            Troskovi = troskovi;
            Status = status;
        }
    }

    public class ServisBasic
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public int TipServisaId { get; set; }
        public string ServisniCentar { get; set; } = string.Empty;
        public DateTime DatumPrijema { get; set; }
        public DateTime? DatumZavrsetka { get; set; }
        public string? OpisRadova { get; set; }
        public string? ZamenjeniDelovi { get; set; }
        public decimal Troskovi { get; set; }
        public string Status { get; set; } = string.Empty;

        public ServisBasic() { }
    }
    #endregion

    #region Kvarovi
    public class KvarPregled
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public string VoziloInfo { get; set; } = string.Empty;
        public string Prijavio { get; set; } = string.Empty;
        public DateTime DatumPrijave { get; set; }
        public string OpisProblema { get; set; } = string.Empty;
        public string ProcenaOzbiljnosti { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime? DatumOtklanjanja { get; set; }

        public KvarPregled() { }

        public KvarPregled(int id, int voziloId, string voziloInfo, string prijavio, DateTime datumPrijave, string opisProblema, string procenaOzbiljnosti, string status, DateTime? datumOtklanjanja)
        {
            Id = id;
            VoziloId = voziloId;
            VoziloInfo = voziloInfo;
            Prijavio = prijavio;
            DatumPrijave = datumPrijave;
            OpisProblema = opisProblema;
            ProcenaOzbiljnosti = procenaOzbiljnosti;
            Status = status;
            DatumOtklanjanja = datumOtklanjanja;
        }
    }

    public class KvarBasic
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public int PrijavioId { get; set; }
        public DateTime DatumPrijave { get; set; }
        public string OpisProblema { get; set; } = string.Empty;
        public string ProcenaOzbiljnosti { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime? DatumOtklanjanja { get; set; }

        public KvarBasic() { }
    }
    #endregion

    #region NezgodeStete
    public class NezgodaStetaPregled
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public string VoziloInfo { get; set; } = string.Empty;
        public string Odgovornost { get; set; } = string.Empty;
        public decimal ProcenaStete { get; set; }
        public int BrojSlika { get; set; }
        public int BrojKuca { get; set; }
        public int BrojZapisnika { get; set; }

        public NezgodaStetaPregled() { }

        public NezgodaStetaPregled(int id, int voziloId, string voziloInfo, string odgovornost, decimal procenaStete, int brojSlika, int brojKuca, int brojZapisnika)
        {
            Id = id;
            VoziloId = voziloId;
            VoziloInfo = voziloInfo;
            Odgovornost = odgovornost;
            ProcenaStete = procenaStete;
            BrojSlika = brojSlika;
            BrojKuca = brojKuca;
            BrojZapisnika = brojZapisnika;
        }
    }

    public class NezgodaStetaBasic
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public int OdgovornostId { get; set; }
        public decimal ProcenaStete { get; set; }

        public List<NezgodaFotografijaPregled> Fotografije { get; set; } = new List<NezgodaFotografijaPregled>();
        public List<NezgodaOsiguravajucaKucaPregled> OsiguravajuceKuce { get; set; } = new List<NezgodaOsiguravajucaKucaPregled>();
        public List<NezgodaZapisnikPregled> Zapisnici { get; set; } = new List<NezgodaZapisnikPregled>();

        public NezgodaStetaBasic() { }
    }

    public class NezgodaFotografijaPregled
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        public NezgodaFotografijaPregled() { }
        public NezgodaFotografijaPregled(int id, string url)
        {
            Id = id;
            Url = url;
        }
    }

    public class NezgodaOsiguravajucaKucaPregled
    {
        public int Id { get; set; }
        public string OsiguravajucaKuca { get; set; } = string.Empty;

        public NezgodaOsiguravajucaKucaPregled() { }
        public NezgodaOsiguravajucaKucaPregled(int id, string osiguravajucaKuca)
        {
            Id = id;
            OsiguravajucaKuca = osiguravajucaKuca;
        }
    }

    public class NezgodaZapisnikPregled
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        public NezgodaZapisnikPregled() { }
        public NezgodaZapisnikPregled(int id, string url)
        {
            Id = id;
            Url = url;
        }
    }
    #endregion

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

        public VoznjaPregled() { }

        public VoznjaPregled(int id, DateTime vremePocetka, DateTime vremeZavrsetka, decimal predjenaKilometraza, int trajanjeMinuti, decimal pocetniNivo, decimal krajnjiNivo, string pocetnaLokacija, string krajnjaLokacija, decimal cena, decimal naknade)
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
