using System;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class KorisnikDodatniPodaciForm : Form
    {
        private readonly int korisnikId;

        public KorisnikDodatniPodaciForm(int korisnikId)
        {
            InitializeComponent();
            this.korisnikId = korisnikId;
            Text = $"Dodatni podaci - Korisnik (ID: {korisnikId})";
        }

        private void KorisnikDodatniPodaciForm_Load(object sender, EventArgs e)
        {
            dtpDatumVerifikacije.Value = DateTime.Now;
            dtpDatumDodavanjaPlacanja.Value = DateTime.Now;

            PopuniTelefone();
            PopuniVerifikacije();
            PopuniNacinePlacanja();
        }

        #region Telefoni

        private void PopuniTelefone()
        {
            listViewTelefoni.Items.Clear();
            var telefoni = DTOManager.vratiTelefoneKorisnika(korisnikId);
            foreach (var t in telefoni)
            {
                ListViewItem item = new(new string[] { t.Id.ToString(), t.BrojTelefona });
                listViewTelefoni.Items.Add(item);
            }
            listViewTelefoni.Refresh();
        }

        private void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoviTelefon.Text))
            {
                MessageBox.Show("Unesite broj telefona.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DTOManager.dodajTelefonKorisniku(korisnikId, txtNoviTelefon.Text.Trim()))
            {
                txtNoviTelefon.Clear();
                PopuniTelefone();
            }
        }

        private void btnObrisiTelefon_Click(object sender, EventArgs e)
        {
            if (listViewTelefoni.SelectedItems.Count == 0) return;
            int id = int.Parse(listViewTelefoni.SelectedItems[0].SubItems[0].Text);

            if (DTOManager.obrisiTelefonKorisnika(id))
                PopuniTelefone();
        }

        #endregion

        #region Verifikacije

        private void PopuniVerifikacije()
        {
            listViewVerifikacije.Items.Clear();
            var verifikacije = DTOManager.vratiVerifikacijeKorisnika(korisnikId);
            foreach (var v in verifikacije)
            {
                ListViewItem item = new(new string[]
                {
                    v.Id.ToString(),
                    v.DatumVerifikacije.ToString("dd.MM.yyyy"),
                    v.Verifikator,
                    v.Rezultat,
                    v.Ogranicenja ?? string.Empty
                });
                listViewVerifikacije.Items.Add(item);
            }
            listViewVerifikacije.Refresh();
        }

        private void btnDodajVerifikaciju_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVerifikator.Text) || string.IsNullOrWhiteSpace(txtRezultat.Text))
            {
                MessageBox.Show("Unesite verifikatora i rezultat.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DTOManager.dodajVerifikacijuKorisniku(
                korisnikId,
                dtpDatumVerifikacije.Value,
                txtVerifikator.Text.Trim(),
                txtRezultat.Text.Trim(),
                string.IsNullOrWhiteSpace(txtOgranicenjaVerifikacije.Text) ? null : txtOgranicenjaVerifikacije.Text.Trim()))
            {
                txtVerifikator.Clear();
                txtRezultat.Clear();
                txtOgranicenjaVerifikacije.Clear();
                PopuniVerifikacije();
            }
        }

        private void btnObrisiVerifikaciju_Click(object sender, EventArgs e)
        {
            if (listViewVerifikacije.SelectedItems.Count == 0) return;
            int id = int.Parse(listViewVerifikacije.SelectedItems[0].SubItems[0].Text);

            if (DTOManager.obrisiVerifikacijuKorisnika(id))
                PopuniVerifikacije();
        }

        #endregion

        #region NaciniPlacanja

        private void PopuniNacinePlacanja()
        {
            listViewNaciniPlacanja.Items.Clear();
            var naciniPlacanja = DTOManager.vratiNacinePlacanjaKorisnika(korisnikId);
            foreach (var n in naciniPlacanja)
            {
                ListViewItem item = new(new string[]
                {
                    n.Id.ToString(),
                    n.TipPlacanja,
                    n.Status,
                    n.DatumDodavanja.ToString("dd.MM.yyyy"),
                    n.Ogranicenja ?? string.Empty
                });
                listViewNaciniPlacanja.Items.Add(item);
            }
            listViewNaciniPlacanja.Refresh();
        }

        private void btnDodajNacinPlacanja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipPlacanja.Text) || string.IsNullOrWhiteSpace(txtStatusPlacanja.Text))
            {
                MessageBox.Show("Unesite tip i status plaćanja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DTOManager.dodajNacinPlacanjaKorisniku(
                korisnikId,
                txtTipPlacanja.Text.Trim(),
                txtStatusPlacanja.Text.Trim(),
                dtpDatumDodavanjaPlacanja.Value,
                string.IsNullOrWhiteSpace(txtOgranicenjaPlacanja.Text) ? null : txtOgranicenjaPlacanja.Text.Trim()))
            {
                txtTipPlacanja.Clear();
                txtStatusPlacanja.Clear();
                txtOgranicenjaPlacanja.Clear();
                PopuniNacinePlacanja();
            }
        }

        private void btnObrisiNacinPlacanja_Click(object sender, EventArgs e)
        {
            if (listViewNaciniPlacanja.SelectedItems.Count == 0) return;
            int id = int.Parse(listViewNaciniPlacanja.SelectedItems[0].SubItems[0].Text);

            if (DTOManager.obrisiNacinPlacanjaKorisnika(id))
                PopuniNacinePlacanja();
        }

        #endregion
    }
}