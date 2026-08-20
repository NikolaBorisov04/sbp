using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class ServisiForm : Form
    {
        private readonly int? voziloFilterId;

        public ServisiForm(int? voziloId = null)
        {
            InitializeComponent();
            voziloFilterId = voziloId;
        }

        private void ServisiForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            listViewServisi.Items.Clear();
            List<ServisPregled> servisi = DTOManager.vratiSveServise(voziloFilterId);

            foreach (var s in servisi)
            {
                ListViewItem item = new(new string[]
                {
                    s.Id.ToString(),
                    s.VoziloInfo,
                    s.TipServisa,
                    s.ServisniCentar,
                    s.DatumPrijema.ToString("dd.MM.yyyy"),
                    s.DatumZavrsetka.HasValue ? s.DatumZavrsetka.Value.ToString("dd.MM.yyyy") : "-",
                    s.Troskovi.ToString("F2"),
                    s.Status
                });
                listViewServisi.Items.Add(item);
            }
            listViewServisi.Refresh();
        }

        private int? GetSelectedId()
        {
            if (listViewServisi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite servis iz liste.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return int.Parse(listViewServisi.SelectedItems[0].SubItems[0].Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ServisCreateUpdateForm form = new(voziloId: voziloFilterId);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            ServisCreateUpdateForm form = new(servisId: id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabrani servis?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DTOManager.obrisiServis(id.Value))
                {
                    MessageBox.Show("Servis je uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopuniPodacima();
                }
            }
        }
    }
}
