using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class VoziloCreateUpdateForm : Form
    {
        private readonly int? voziloId;
        private VoziloBasic vozilo = new();

        public VoziloCreateUpdateForm()
        {
            InitializeComponent();
            Text = "Novo Vozilo";
        }

        public VoziloCreateUpdateForm(int id)
        {
            InitializeComponent();
            voziloId = id;
            Text = "Izmena Vozila";
        }

        private void VoziloCreateUpdateForm_Load(object sender, EventArgs e)
        {
            var pogoni = DTOManager.vratiSveTipovePogona();
            cmbPogon.DataSource = pogoni;
            cmbPogon.DisplayMember = "Naziv";
            cmbPogon.ValueMember = "Id";

            cmbKoriscenje.DataSource = DTOManager.vratiSveTipoveKoriscenja();
            cmbKoriscenje.DisplayMember = "Naziv";
            cmbKoriscenje.ValueMember = "Id";

            cmbStatus.Items.AddRange(new object[] { "Slobodno", "Iznajmljeno", "Na servisu", "Van funkcije" });
            cmbStatus.SelectedIndex = 0;

            if (voziloId.HasValue)
            {
                var loaded = DTOManager.vratiVozilo(voziloId.Value);
                if (loaded != null)
                {
                    vozilo = loaded;
                    txtReg.Text = vozilo.RegistarskaOznaka;
                    txtVin.Text = vozilo.Vin;
                    txtMarka.Text = vozilo.Marka;
                    txtModel.Text = vozilo.Model;
                    numGodina.Value = vozilo.GodinaProizvodnje;
                    dtpDatumNabavke.Value = vozilo.DatumNabavke;
                    cmbStatus.SelectedItem = vozilo.Status;
                    numSedista.Value = vozilo.BrojSedista;
                    txtEnterijer.Text = vozilo.StanjeEnterijera ?? string.Empty;
                    txtEksterijer.Text = vozilo.StanjeEksterijera ?? string.Empty;
                    txtOgranicenja.Text = vozilo.OgranicenjaKoriscenja ?? string.Empty;

                    cmbPogon.SelectedValue = vozilo.TipPogonaId;
                    cmbPogon.Enabled = false;
                    cmbKoriscenje.SelectedValue = vozilo.TipKoriscenjaId;

                    numKapacitetBaterije.Value = vozilo.KapacitetBaterije;
                    numNivoNapunjenosti.Value = vozilo.TrenutniNivoNapunjenosti;
                    numAutonomija.Value = vozilo.Autonomija;
                    txtTipPunjenja.Text = vozilo.TipPunjenja;
                    numCiklusi.Value = vozilo.BrojCiklusaPunjenja;

                    txtTipHibridnogPogona.Text = vozilo.TipHibridnogPogona;

                    txtTipGoriva.Text = vozilo.TipGoriva;
                    numZapreminaRezervoara.Value = vozilo.ZapreminaRezervoara;
                    numProsecnaPotrosnja.Value = vozilo.ProsecnaPotrosnja;
                }
            }
            else
            {
                cmbPogon.SelectedIndex = -1;
            }

            PrilagodiPoljaZaPogon();
        }

        private void cmbPogon_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrilagodiPoljaZaPogon();
        }

        private void PrilagodiPoljaZaPogon()
        {
            string nazivPogona = (cmbPogon.SelectedItem as TipPogonaPregled)?.Naziv?.ToLowerInvariant() ?? string.Empty;

            bool isEl = nazivPogona.Contains("elektri") || nazivPogona.Contains("el");
            bool isHib = nazivPogona.Contains("hibrid") || nazivPogona.Contains("hib");
            bool isKlas = nazivPogona.Contains("klasi") || nazivPogona.Contains("klas");

            pnlElektricno.Visible = isEl;
            pnlHibridno.Visible = isHib;
            pnlKlasicno.Visible = isKlas;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReg.Text) || string.IsNullOrWhiteSpace(txtVin.Text) ||
                string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text) ||
                cmbPogon.SelectedValue == null || cmbKoriscenje.SelectedValue == null)
            {
                MessageBox.Show("Molimo popunite sva obavezna polja uključujući i Tip pogona.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            vozilo.RegistarskaOznaka = txtReg.Text.Trim();
            vozilo.Vin = txtVin.Text.Trim();
            vozilo.Marka = txtMarka.Text.Trim();
            vozilo.Model = txtModel.Text.Trim();
            vozilo.GodinaProizvodnje = (int)numGodina.Value;
            vozilo.DatumNabavke = dtpDatumNabavke.Value;
            vozilo.Status = cmbStatus.SelectedItem?.ToString() ?? "Slobodno";
            vozilo.BrojSedista = (int)numSedista.Value;
            vozilo.StanjeEnterijera = txtEnterijer.Text.Trim();
            vozilo.StanjeEksterijera = txtEksterijer.Text.Trim();
            vozilo.OgranicenjaKoriscenja = txtOgranicenja.Text.Trim();

            vozilo.TipPogonaId = (int)cmbPogon.SelectedValue;
            vozilo.TipKoriscenjaId = (int)cmbKoriscenje.SelectedValue;

            string nazivPogona = (cmbPogon.SelectedItem as TipPogonaPregled)?.Naziv?.ToLowerInvariant() ?? string.Empty;

            if (nazivPogona.Contains("elektri") || nazivPogona.Contains("el"))
            {
                vozilo.KapacitetBaterije = numKapacitetBaterije.Value;
                vozilo.TrenutniNivoNapunjenosti = numNivoNapunjenosti.Value;
                vozilo.Autonomija = (int)numAutonomija.Value;
                vozilo.TipPunjenja = txtTipPunjenja.Text.Trim();
                vozilo.BrojCiklusaPunjenja = (int)numCiklusi.Value;
            }
            else if (nazivPogona.Contains("hibrid") || nazivPogona.Contains("hib"))
            {
                vozilo.KapacitetBaterije = numKapacitetBaterije.Value;
                vozilo.TipHibridnogPogona = txtTipHibridnogPogona.Text.Trim();
            }
            else if (nazivPogona.Contains("klasi") || nazivPogona.Contains("klas"))
            {
                vozilo.TipGoriva = txtTipGoriva.Text.Trim();
                vozilo.ZapreminaRezervoara = numZapreminaRezervoara.Value;
                vozilo.ProsecnaPotrosnja = numProsecnaPotrosnja.Value;
            }

            bool uspeh = voziloId.HasValue ? DTOManager.azurirajVozilo(vozilo) : DTOManager.dodajVozilo(vozilo);
            if (uspeh)
            {
                MessageBox.Show("Podaci o vozilu su uspešno sačuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
