using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class PunjenjeTocenjeCreateUpdateForm : Form
    {
        private readonly int? punjenjeId;
        private readonly int voziloId;
        private PunjenjeTocenjeBasic punjenje = new();

        public PunjenjeTocenjeCreateUpdateForm(int voziloId, int? punjenjeId = null)
        {
            InitializeComponent();
            this.voziloId = voziloId;
            this.punjenjeId = punjenjeId;
            Text = punjenjeId.HasValue ? "Izmena Punjenja / Točenja" : "Novo Punjenje / Točenje";
        }

        private void PunjenjeTocenjeCreateUpdateForm_Load(object sender, EventArgs e)
        {
            cmbNacin.Items.AddRange(new object[] { "Automatski (Telemetrija)", "Korisnik aplikacija", "Karta za gorivo", "Kartica kompanije", "Fiskalni račun" });
            cmbNacin.SelectedIndex = 0;

            if (punjenjeId.HasValue)
            {
                var p = DTOManager.vratiPunjenjeTocenje(punjenjeId.Value);
                if (p != null)
                {
                    punjenje = p;
                    dtpDatumVreme.Value = p.DatumVreme;
                    txtLokacija.Text = p.Lokacija;
                    numKolicina.Value = p.Kolicina;
                    numCena.Value = p.Cena;
                    cmbNacin.SelectedItem = p.NacinEvidentiranja;
                    txtEvidentirao.Text = p.Evidentirao;
                }
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLokacija.Text) || string.IsNullOrWhiteSpace(txtEvidentirao.Text))
            {
                MessageBox.Show("Molimo popunite sva obavezna polja (Lokacija, Evidentirao).", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            punjenje.VoziloId = voziloId;
            punjenje.DatumVreme = dtpDatumVreme.Value;
            punjenje.Lokacija = txtLokacija.Text.Trim();
            punjenje.Kolicina = numKolicina.Value;
            punjenje.Cena = numCena.Value;
            punjenje.NacinEvidentiranja = cmbNacin.SelectedItem?.ToString() ?? "Automatski";
            punjenje.Evidentirao = txtEvidentirao.Text.Trim();

            bool uspeh = punjenjeId.HasValue ? DTOManager.azurirajPunjenjeTocenje(punjenje) : DTOManager.dodajPunjenjeTocenje(punjenje);
            if (uspeh)
            {
                MessageBox.Show("Evidencija je uspešno sačuvana!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
