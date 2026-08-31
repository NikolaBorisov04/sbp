using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class ServisCreateUpdateForm : Form
    {
        private readonly int? servisId;
        private readonly int voziloId;
        private ServisBasic servis = new();

        public ServisCreateUpdateForm(int voziloId, int? servisId = null)
        {
            InitializeComponent();
            this.voziloId = voziloId;
            this.servisId = servisId;
            Text = servisId.HasValue ? "Izmena Servisa" : "Evidentiranje Servisa";
        }

        private void ServisCreateUpdateForm_Load(object sender, EventArgs e)
        {
            cmbTipServisa.DataSource = DTOManager.vratiSveTipoveServisa();
            cmbTipServisa.DisplayMember = "Naziv";
            cmbTipServisa.ValueMember = "Id";

            cmbStatus.Items.AddRange(new object[] { "U toku", "Završen", "Otkazan", "Na čekanju" });
            cmbStatus.SelectedIndex = 0;

            if (servisId.HasValue)
            {
                var s = DTOManager.vratiServis(servisId.Value);
                if (s != null)
                {
                    servis = s;
                    cmbTipServisa.SelectedValue = s.TipServisaId;
                    txtServisniCentar.Text = s.ServisniCentar;
                    dtpDatumPrijema.Value = s.DatumPrijema;
                    if (s.DatumZavrsetka.HasValue)
                    {
                        chkZavrsen.Checked = true;
                        dtpDatumZavrsetka.Value = s.DatumZavrsetka.Value;
                    }
                    txtOpis.Text = s.OpisRadova ?? string.Empty;
                    txtDelovi.Text = s.ZamenjeniDelovi ?? string.Empty;
                    numTroskovi.Value = s.Troskovi;
                    cmbStatus.SelectedItem = s.Status;
                }
            }
        }

        private void chkZavrsen_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumZavrsetka.Enabled = chkZavrsen.Checked;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServisniCentar.Text))
            {
                MessageBox.Show("Molimo unesite servisni centar.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            servis.VoziloId = voziloId;
            servis.TipServisaId = (int)(cmbTipServisa.SelectedValue ?? 1);
            servis.ServisniCentar = txtServisniCentar.Text.Trim();
            servis.DatumPrijema = dtpDatumPrijema.Value;
            servis.DatumZavrsetka = chkZavrsen.Checked ? dtpDatumZavrsetka.Value : null;
            servis.OpisRadova = txtOpis.Text.Trim();
            servis.ZamenjeniDelovi = txtDelovi.Text.Trim();
            servis.Troskovi = numTroskovi.Value;
            servis.Status = cmbStatus.SelectedItem?.ToString() ?? "U toku";

            bool uspeh = servisId.HasValue ? DTOManager.azurirajServis(servis) : DTOManager.dodajServis(servis);
            if (uspeh)
            {
                MessageBox.Show("Servis je uspešno sačuvan!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
