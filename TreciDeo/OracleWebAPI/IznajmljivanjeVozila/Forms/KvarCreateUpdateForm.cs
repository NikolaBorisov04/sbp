using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class KvarCreateUpdateForm : Form
    {
        private readonly int? kvarId;
        private readonly int voziloId;
        private KvarBasic kvar = new();

        public KvarCreateUpdateForm(int voziloId, int? kvarId = null)
        {
            InitializeComponent();
            this.voziloId = voziloId;
            this.kvarId = kvarId;
            Text = kvarId.HasValue ? "Izmena Kvara" : "Prijava Kvara";
        }

        private void KvarCreateUpdateForm_Load(object sender, EventArgs e)
        {
            cmbPrijavio.DataSource = DTOManager.vratiSvePrijavioKvar();
            cmbPrijavio.DisplayMember = "Naziv";
            cmbPrijavio.ValueMember = "Id";

            cmbOzbiljnost.Items.AddRange(new object[] { "Niska", "Srednja", "Visoka", "Kritična" });
            cmbOzbiljnost.SelectedIndex = 1;

            cmbStatus.Items.AddRange(new object[] { "Prijavljen", "U obradi", "Na čekanju", "Otklonjen" });
            cmbStatus.SelectedIndex = 0;

            if (kvarId.HasValue)
            {
                var k = DTOManager.vratiKvar(kvarId.Value);
                if (k != null)
                {
                    kvar = k;
                    cmbPrijavio.SelectedValue = k.PrijavioId;
                    dtpDatumPrijave.Value = k.DatumPrijave;
                    txtOpis.Text = k.OpisProblema;
                    cmbOzbiljnost.SelectedItem = k.ProcenaOzbiljnosti;
                    cmbStatus.SelectedItem = k.Status;
                    if (k.DatumOtklanjanja.HasValue)
                    {
                        chkOtklonjen.Checked = true;
                        dtpDatumOtklanjanja.Value = k.DatumOtklanjanja.Value;
                    }
                }
            }
        }

        private void chkOtklonjen_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumOtklanjanja.Enabled = chkOtklonjen.Checked;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                MessageBox.Show("Molimo unesite opis problema.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kvar.VoziloId = voziloId;
            kvar.PrijavioId = (int)(cmbPrijavio.SelectedValue ?? 1);
            kvar.DatumPrijave = dtpDatumPrijave.Value;
            kvar.OpisProblema = txtOpis.Text.Trim();
            kvar.ProcenaOzbiljnosti = cmbOzbiljnost.SelectedItem?.ToString() ?? "Srednja";
            kvar.Status = cmbStatus.SelectedItem?.ToString() ?? "Prijavljen";
            kvar.DatumOtklanjanja = chkOtklonjen.Checked ? dtpDatumOtklanjanja.Value : null;

            bool uspeh = kvarId.HasValue ? DTOManager.azurirajKvar(kvar) : DTOManager.dodajKvar(kvar);
            if (uspeh)
            {
                MessageBox.Show("Podaci o kvaru su uspešno sačuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
