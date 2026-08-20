using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class VozilaForm : Form
    {
        public VozilaForm()
        {
            InitializeComponent();
        }

        private void VozilaForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            listViewVozila.Items.Clear();
            List<VoziloPregled> vozila = DTOManager.vratiSvaVozila();

            foreach (var v in vozila)
            {
                ListViewItem item = new(new string[]
                {
                    v.Id.ToString(),
                    v.RegistarskaOznaka,
                    v.Marka,
                    v.Model,
                    v.GodinaProizvodnje.ToString(),
                    v.DatumNabavke.ToString("dd.MM.yyyy"),
                    v.Status,
                    v.BrojSedista.ToString(),
                    v.TipPogona,
                    v.TipKoriscenja,
                    v.Podtip,
                    v.Vin
                });
                listViewVozila.Items.Add(item);
            }
            listViewVozila.Refresh();
        }

        private int? GetSelectedVoziloId()
        {
            if (listViewVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite vozilo iz liste.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return int.Parse(listViewVozila.SelectedItems[0].SubItems[0].Text);
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            VoziloCreateUpdateForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedVoziloId();
            if (!id.HasValue) return;

            VoziloCreateUpdateForm form = new(id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedVoziloId();
            if (!id.HasValue) return;

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabrano vozilo?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DTOManager.obrisiVozilo(id.Value))
                {
                    MessageBox.Show("Vozilo je uspešno obrisano.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopuniPodacima();
                }
            }
        }

        private void btnServisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedVoziloId();
            ServisiForm form = new(id);
            form.ShowDialog();
        }

        private void btnKvarovi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedVoziloId();
            KvaroviForm form = new(id);
            form.ShowDialog();
        }

        private void btnPunjenja_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedVoziloId();
            PunjenjaTocenjaForm form = new(id);
            form.ShowDialog();
        }

        private void btnNezgode_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedVoziloId();
            NezgodeSteteForm form = new(id);
            form.ShowDialog();
        }

        private void btnOprema_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedVoziloId();
            OpremaForm form = new(id);
            form.ShowDialog();
        }
    }
}
