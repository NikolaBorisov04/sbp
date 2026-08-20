using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class PunjenjaTocenjaForm : Form
    {
        private readonly int? voziloFilterId;

        public PunjenjaTocenjaForm(int? voziloId = null)
        {
            InitializeComponent();
            voziloFilterId = voziloId;
        }

        private void PunjenjaTocenjaForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            listViewPunjenja.Items.Clear();
            List<PunjenjeTocenjePregled> punjenja = DTOManager.vratiSvaPunjenjaTocenja(voziloFilterId);

            foreach (var p in punjenja)
            {
                ListViewItem item = new(new string[]
                {
                    p.Id.ToString(),
                    p.VoziloInfo,
                    p.DatumVreme.ToString("dd.MM.yyyy HH:mm"),
                    p.Lokacija,
                    p.Kolicina.ToString("F2"),
                    p.Cena.ToString("F2"),
                    p.NacinEvidentiranja,
                    p.Evidentirao
                });
                listViewPunjenja.Items.Add(item);
            }
            listViewPunjenja.Refresh();
        }

        private int? GetSelectedId()
        {
            if (listViewPunjenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite stavku iz liste.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return int.Parse(listViewPunjenja.SelectedItems[0].SubItems[0].Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PunjenjeTocenjeCreateUpdateForm form = new(voziloId: voziloFilterId);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            PunjenjeTocenjeCreateUpdateForm form = new(punjenjeId: id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj zapis?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DTOManager.obrisiPunjenjeTocenje(id.Value))
                {
                    MessageBox.Show("Zapis je uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopuniPodacima();
                }
            }
        }
    }
}
