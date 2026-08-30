using System;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class KorisnikCreateUpdateForm : Form
    {
        private readonly int? korisnikId;
        private KorisnikBasic korisnik = new();

        public KorisnikCreateUpdateForm(int? korisnikId = null)
        {
            InitializeComponent();
            this.korisnikId = korisnikId;
            Text = korisnikId.HasValue ? "Izmena Korisnika" : "Novi Korisnik";
        }

        private void KorisnikCreateUpdateForm_Load(object sender, EventArgs e)
        {
            cmbTipKorisnika.DataSource = DTOManager.vratiSveTipoveKorisnika();
            cmbTipKorisnika.DisplayMember = "Naziv";
            cmbTipKorisnika.ValueMember = "Id";

            dtpDatumRegistracije.Value = DateTime.Now;
            dtpDatumIzdavanjaDozvole.Value = DateTime.Now;
            dtpDatumIstekaDozvole.Value = DateTime.Now.AddYears(10);

            if (korisnikId.HasValue)
            {
                var k = DTOManager.vratiKorisnika(korisnikId.Value);
                if (k != null)
                {
                    korisnik = k;

                    txtAdresa.Text = k.Adresa;
                    txtEmail.Text = k.EmailAdresa;
                    dtpDatumRegistracije.Value = k.DatumRegistracije;
                    txtStatusNaloga.Text = k.StatusNaloga;
                    txtNacinVerifikacije.Text = k.NacinVerifikacije;
                    cmbTipKorisnika.SelectedValue = k.TipKorisnikaId;

                    // Tip korisnika se ne menja prilikom izmene (nasleđena tabela)
                    cmbTipKorisnika.Enabled = false;

                    if (!string.IsNullOrEmpty(k.Jmbg))
                    {
                        txtJmbg.Text = k.Jmbg;
                        txtIme.Text = k.Ime;
                        txtPrezime.Text = k.Prezime;
                        txtBrojVozackeDozvole.Text = k.BrojVozackeDozvole;
                        txtKategorijeDozvole.Text = k.KategorijeDozvole;
                        dtpDatumIzdavanjaDozvole.Value = k.DatumIzdavanjaDozvole;
                        dtpDatumIstekaDozvole.Value = k.DatumIstekaDozvole;
                    }
                    else if (!string.IsNullOrEmpty(k.Naziv))
                    {
                        txtNaziv.Text = k.Naziv;
                        txtPib.Text = k.Pib;
                        txtMaticniBroj.Text = k.MaticniBroj;
                        txtSediste.Text = k.Sediste;
                        txtKontaktOsoba.Text = k.KontaktOsoba;
                        txtUgovoreniUsloviKoriscenja.Text = k.UgovoreniUsloviKoriscenja;
                    }
                }
            }

            PrikaziPoljaZaOdabraniTip();
        }

        private void cmbTipKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziPoljaZaOdabraniTip();
        }

        private void PrikaziPoljaZaOdabraniTip()
        {
            string naziv = (cmbTipKorisnika.SelectedItem as TipKorisnikaPregled)?.Naziv?.ToLowerInvariant() ?? string.Empty;

            bool jeFizicko = naziv.Contains("fizic") || naziv.Contains("fizič");
            bool jePravno = naziv.Contains("pravn");

            panelFizickoLice.Visible = jeFizicko;
            panelPravnoLice.Visible = jePravno;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Molimo unesite adresu i email.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            korisnik.Adresa = txtAdresa.Text.Trim();
            korisnik.EmailAdresa = txtEmail.Text.Trim();
            korisnik.DatumRegistracije = dtpDatumRegistracije.Value;
            korisnik.StatusNaloga = string.IsNullOrWhiteSpace(txtStatusNaloga.Text) ? "Aktivan" : txtStatusNaloga.Text.Trim();
            korisnik.NacinVerifikacije = txtNacinVerifikacije.Text.Trim();
            korisnik.TipKorisnikaId = (int)(cmbTipKorisnika.SelectedValue ?? 0);

            if (panelFizickoLice.Visible)
            {
                if (string.IsNullOrWhiteSpace(txtJmbg.Text) || string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text))
                {
                    MessageBox.Show("Molimo popunite JMBG, ime i prezime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                korisnik.Jmbg = txtJmbg.Text.Trim();
                korisnik.Ime = txtIme.Text.Trim();
                korisnik.Prezime = txtPrezime.Text.Trim();
                korisnik.BrojVozackeDozvole = txtBrojVozackeDozvole.Text.Trim();
                korisnik.KategorijeDozvole = txtKategorijeDozvole.Text.Trim();
                korisnik.DatumIzdavanjaDozvole = dtpDatumIzdavanjaDozvole.Value;
                korisnik.DatumIstekaDozvole = dtpDatumIstekaDozvole.Value;
            }
            else if (panelPravnoLice.Visible)
            {
                if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtPib.Text))
                {
                    MessageBox.Show("Molimo popunite naziv i PIB.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                korisnik.Naziv = txtNaziv.Text.Trim();
                korisnik.Pib = txtPib.Text.Trim();
                korisnik.MaticniBroj = txtMaticniBroj.Text.Trim();
                korisnik.Sediste = txtSediste.Text.Trim();
                korisnik.KontaktOsoba = txtKontaktOsoba.Text.Trim();
                korisnik.UgovoreniUsloviKoriscenja = txtUgovoreniUsloviKoriscenja.Text.Trim();
            }

            bool uspeh = korisnikId.HasValue ? DTOManager.azurirajKorisnika(korisnik) : DTOManager.dodajKorisnika(korisnik);
            if (uspeh)
            {
                MessageBox.Show("Podaci o korisniku su uspešno sačuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}