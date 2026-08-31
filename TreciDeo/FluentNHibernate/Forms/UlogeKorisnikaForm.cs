using System;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class UlogeKorisnikaForm : Form
    {
        private readonly int korisnikFilterId;

        public UlogeKorisnikaForm(int korisnikId)
        {
            InitializeComponent();
            korisnikFilterId = korisnikId;
            Text = $"Uloge za Korisnika (ID: {korisnikId})";
        }

        private void UlogeKorisnikaForm_Load(object sender, EventArgs e)
        {
            PopuniKatalogUloga();
            PopuniDodeljeneUloge();
        }

        public void PopuniKatalogUloga()
        {
            listViewKatalog.Items.Clear();
            cmbUlogaIzbor.Items.Clear();
            var uloge = DTOManager.vratiSveUloge();

            foreach (var u in uloge)
            {
                ListViewItem item = new(new string[] { u.Id.ToString(), u.Naziv });
                listViewKatalog.Items.Add(item);
                cmbUlogaIzbor.Items.Add(u);
            }
            if (cmbUlogaIzbor.Items.Count > 0)
                cmbUlogaIzbor.SelectedIndex = 0;
            listViewKatalog.Refresh();
        }

        public void PopuniDodeljeneUloge()
        {
            listViewDodeljene.Items.Clear();
            var dodeljene = DTOManager.vratiUlogeZaKorisnika(korisnikFilterId);
            foreach (var d in dodeljene)
            {
                ListViewItem item = new(new string[] { d.Id.ToString(), d.Naziv });
                listViewDodeljene.Items.Add(item);
            }
            listViewDodeljene.Refresh();
        }

        private void btnDodajKatalog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivUloge.Text))
            {
                MessageBox.Show("Molimo unesite naziv uloge.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UlogaPregled up = new()
            {
                Naziv = txtNazivUloge.Text.Trim()
            };

            if (DTOManager.dodajUlogu(up))
            {
                txtNazivUloge.Clear();
                PopuniKatalogUloga();
            }
        }

        private void btnObrisiKatalog_Click(object sender, EventArgs e)
        {
            if (listViewKatalog.SelectedItems.Count == 0) return;
            int ulogaId = int.Parse(listViewKatalog.SelectedItems[0].SubItems[0].Text);

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovu ulogu iz kataloga?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DTOManager.obrisiUlogu(ulogaId))
                    PopuniKatalogUloga();
            }
        }

        private void btnDodeli_Click(object sender, EventArgs e)
        {
            if (cmbUlogaIzbor.SelectedItem is UlogaPregled up)
            {
                if (DTOManager.dodajUloguKorisniku(korisnikFilterId, up.Id))
                {
                    PopuniDodeljeneUloge();
                }
                else
                {
                    MessageBox.Show("Korisnik već ima ovu ulogu ili je došlo do greške.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUkloniDodeljenu_Click(object sender, EventArgs e)
        {
            if (listViewDodeljene.SelectedItems.Count > 0)
            {
                int ulogaId = int.Parse(listViewDodeljene.SelectedItems[0].SubItems[0].Text);
                if (DTOManager.obrisiUloguSaKorisnika(korisnikFilterId, ulogaId))
                {
                    PopuniDodeljeneUloge();
                }
            }
        }
    }
}