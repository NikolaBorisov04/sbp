using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class NezgodeSteteForm : Form
    {
        private readonly int? voziloFilterId;

        public NezgodeSteteForm(int? voziloId = null)
        {
            InitializeComponent();
            voziloFilterId = voziloId;
        }

        private void NezgodeSteteForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            listViewNezgode.Items.Clear();
            List<NezgodaStetaPregled> nezgode = DTOManager.vratiSveNezgodeStete(voziloFilterId);

            foreach (var n in nezgode)
            {
                ListViewItem item = new(new string[]
                {
                    n.Id.ToString(),
                    n.VoziloInfo,
                    n.Odgovornost,
                    n.ProcenaStete.ToString("F2"),
                    n.BrojSlika.ToString(),
                    n.BrojKuca.ToString(),
                    n.BrojZapisnika.ToString()
                });
                listViewNezgode.Items.Add(item);
            }
            listViewNezgode.Refresh();
        }

        private int? GetSelectedId()
        {
            if (listViewNezgode.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite nezgodu/štetu iz liste.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return int.Parse(listViewNezgode.SelectedItems[0].SubItems[0].Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NezgodaStetaCreateUpdateForm form = new(voziloId: voziloFilterId);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            NezgodaStetaCreateUpdateForm form = new(nezgodaId: id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovu štetu i sve povezane podatke?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DTOManager.obrisiNezgoduStetu(id.Value))
                {
                    MessageBox.Show("Nezgoda/šteta je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopuniPodacima();
                }
            }
        }
    }
}
