using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class NezgodaStetaCreateUpdateForm : Form
    {
        private readonly int? nezgodaId;
        private readonly int? defaultVoziloId;
        private NezgodaStetaBasic nezgoda = new();

        public NezgodaStetaCreateUpdateForm(int? nezgodaId = null, int? voziloId = null)
        {
            InitializeComponent();
            this.nezgodaId = nezgodaId;
            defaultVoziloId = voziloId;
            Text = nezgodaId.HasValue ? "Izmena i Detalji Nezgode / Štete" : "Unos Nezgode / Štete";
        }

        private void NezgodaStetaCreateUpdateForm_Load(object sender, EventArgs e)
        {
            cmbVozilo.DataSource = DTOManager.vratiSvaVozila();
            cmbVozilo.DisplayMember = "ToString";
            cmbVozilo.ValueMember = "Id";

            cmbOdgovornost.DataSource = DTOManager.vratiSveTipoveOdgovornosti();
            cmbOdgovornost.DisplayMember = "Naziv";
            cmbOdgovornost.ValueMember = "Id";

            if (defaultVoziloId.HasValue)
                cmbVozilo.SelectedValue = defaultVoziloId.Value;

            if (nezgodaId.HasValue)
            {
                var n = DTOManager.vratiNezgoduStetu(nezgodaId.Value);
                if (n != null)
                {
                    nezgoda = n;
                    cmbVozilo.SelectedValue = n.VoziloId;
                    cmbOdgovornost.SelectedValue = n.OdgovornostId;
                    numProcena.Value = n.ProcenaStete;
                    OsveziListuSlika();
                    OsveziListuKuca();
                    OsveziListuZapisnika();
                }
            }
            else
            {
                grpDetalji.Enabled = false;
            }
        }

        private void OsveziListuSlika()
        {
            lstSlike.Items.Clear();
            foreach (var f in nezgoda.Fotografije)
                lstSlike.Items.Add(f.Url);
        }

        private void OsveziListuKuca()
        {
            lstKuce.Items.Clear();
            foreach (var k in nezgoda.OsiguravajuceKuce)
                lstKuce.Items.Add(k.OsiguravajucaKuca);
        }

        private void OsveziListuZapisnika()
        {
            lstZapisnici.Items.Clear();
            foreach (var z in nezgoda.Zapisnici)
                lstZapisnici.Items.Add(z.Url);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (!nezgodaId.HasValue) return;
            string url = txtNovaSlika.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                DTOManager.dodajFotografijuStete(nezgodaId.Value, url);
                nezgoda = DTOManager.vratiNezgoduStetu(nezgodaId.Value)!;
                OsveziListuSlika();
                txtNovaSlika.Clear();
            }
        }

        private void btnObrisiSliku_Click(object sender, EventArgs e)
        {
            if (!nezgodaId.HasValue || lstSlike.SelectedIndex < 0) return;
            var item = nezgoda.Fotografije[lstSlike.SelectedIndex];
            DTOManager.obrisiFotografijuStete(item.Id);
            nezgoda = DTOManager.vratiNezgoduStetu(nezgodaId.Value)!;
            OsveziListuSlika();
        }

        private void btnDodajKucu_Click(object sender, EventArgs e)
        {
            if (!nezgodaId.HasValue) return;
            string kuca = txtNovaKuca.Text.Trim();
            if (!string.IsNullOrEmpty(kuca))
            {
                DTOManager.dodajOsiguravajucuKucuStete(nezgodaId.Value, kuca);
                nezgoda = DTOManager.vratiNezgoduStetu(nezgodaId.Value)!;
                OsveziListuKuca();
                txtNovaKuca.Clear();
            }
        }

        private void btnObrisiKucu_Click(object sender, EventArgs e)
        {
            if (!nezgodaId.HasValue || lstKuce.SelectedIndex < 0) return;
            var item = nezgoda.OsiguravajuceKuce[lstKuce.SelectedIndex];
            DTOManager.obrisiOsiguravajucuKucuStete(item.Id);
            nezgoda = DTOManager.vratiNezgoduStetu(nezgodaId.Value)!;
            OsveziListuKuca();
        }

        private void btnDodajZapisnik_Click(object sender, EventArgs e)
        {
            if (!nezgodaId.HasValue) return;
            string url = txtNoviZapisnik.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                DTOManager.dodajZapisnikStete(nezgodaId.Value, url);
                nezgoda = DTOManager.vratiNezgoduStetu(nezgodaId.Value)!;
                OsveziListuZapisnika();
                txtNoviZapisnik.Clear();
            }
        }

        private void btnObrisiZapisnik_Click(object sender, EventArgs e)
        {
            if (!nezgodaId.HasValue || lstZapisnici.SelectedIndex < 0) return;
            var item = nezgoda.Zapisnici[lstZapisnici.SelectedIndex];
            DTOManager.obrisiZapisnikStete(item.Id);
            nezgoda = DTOManager.vratiNezgoduStetu(nezgodaId.Value)!;
            OsveziListuZapisnika();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            nezgoda.VoziloId = (int)(cmbVozilo.SelectedValue ?? 1);
            nezgoda.OdgovornostId = (int)(cmbOdgovornost.SelectedValue ?? 1);
            nezgoda.ProcenaStete = numProcena.Value;

            bool uspeh = nezgodaId.HasValue ? DTOManager.azurirajNezgoduStetu(nezgoda) : DTOManager.dodajNezgoduStetu(nezgoda);
            if (uspeh)
            {
                MessageBox.Show("Podaci o nezgodi/šteti su sačuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
