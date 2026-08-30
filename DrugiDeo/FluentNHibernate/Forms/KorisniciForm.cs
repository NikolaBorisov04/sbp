using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class KorisniciForm : Form
    {
        public KorisniciForm()
        {
            InitializeComponent();
        }

        private void KorisniciForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            listViewKorisnici.Items.Clear();
            List<KorisnikPregled> korisnici = DTOManager.vratiSveKorisnike();

            foreach (var k in korisnici)
            {
                ListViewItem item = new(new string[]
                {
                    k.Id.ToString(),
                    k.ImeNazivPrikaz,
                    k.EmailAdresa,
                    k.TipKorisnika,
                    k.StatusNaloga,
                    k.DatumRegistracije.ToString("dd.MM.yyyy")
                });
                listViewKorisnici.Items.Add(item);
            }
            listViewKorisnici.Refresh();
        }

        private int? GetSelectedId()
        {
            if (listViewKorisnici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite korisnika iz liste.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return int.Parse(listViewKorisnici.SelectedItems[0].SubItems[0].Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KorisnikCreateUpdateForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            KorisnikCreateUpdateForm form = new(korisnikId: id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }

        private void btnUloge_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            UlogeKorisnikaForm form = new(id.Value);
            form.ShowDialog();
        }

        private void btnDodatniPodaci_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            KorisnikDodatniPodaciForm form = new(id.Value);
            form.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue) return;

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete izabranog korisnika?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DTOManager.obrisiKorisnika(id.Value))
                {
                    MessageBox.Show("Korisnik je uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopuniPodacima();
                }
            }
        }
    }
}