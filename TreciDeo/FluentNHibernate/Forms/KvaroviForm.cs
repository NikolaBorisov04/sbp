using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class KvaroviForm : Form
    {
        private readonly int voziloFilterId;

        public KvaroviForm(int voziloId)
        {
            InitializeComponent();
            voziloFilterId = voziloId;
            Text = $"Evidencija Kvarova za Vozilo (ID: {voziloId})";
        }

        private void KvaroviForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            listViewKvarovi.Items.Clear();
            List<KvarPregled> kvarovi = DTOManager.vratiSveKvarove(voziloFilterId);

            foreach (var k in kvarovi)
            {
                ListViewItem item = new(new string[]
                {
                    k.Id.ToString(),
                    k.VoziloInfo,
                    k.Prijavio,
                    k.DatumPrijave.ToString("dd.MM.yyyy"),
                    k.ProcenaOzbiljnosti,
                    k.Status,
                    k.DatumOtklanjanja.HasValue ? k.DatumOtklanjanja.Value.ToString("dd.MM.yyyy") : "-",
                    k.OpisProblema
                });
                listViewKvarovi.Items.Add(item);
            }
            listViewKvarovi.Refresh();
        }

        private int? GetSelectedId()
        {
            if (listViewKvarovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite kvar iz liste.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return int.Parse(listViewKvarovi.SelectedItems[0].SubItems[0].Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KvarCreateUpdateForm form = new(voziloId: voziloFilterId);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            KvarCreateUpdateForm form = new(voziloId: voziloFilterId, kvarId: id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabrani kvar?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DTOManager.obrisiKvar(id.Value))
                {
                    MessageBox.Show("Kvar je uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopuniPodacima();
                }
            }
        }
    }
}
