using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class OpremaForm : Form
    {
        private readonly int? voziloFilterId;

        public OpremaForm(int? voziloId = null)
        {
            InitializeComponent();
            voziloFilterId = voziloId;
        }

        private void OpremaForm_Load(object sender, EventArgs e)
        {
            cmbVozila.DataSource = DTOManager.vratiSvaVozila();
            cmbVozila.DisplayMember = "ToString";
            cmbVozila.ValueMember = "Id";

            if (voziloFilterId.HasValue)
                cmbVozila.SelectedValue = voziloFilterId.Value;

            PopuniKatalogOpreme();
            PopuniDodeljenuOpremu();
        }

        public void PopuniKatalogOpreme()
        {
            listViewKatalog.Items.Clear();
            cmbOpremaIzbor.Items.Clear();
            var oprema = DTOManager.vratiSvuOpremu();

            foreach (var o in oprema)
            {
                ListViewItem item = new(new string[] { o.Id.ToString(), o.Naziv, o.Opis ?? string.Empty });
                listViewKatalog.Items.Add(item);
                cmbOpremaIzbor.Items.Add(o);
            }
            if (cmbOpremaIzbor.Items.Count > 0)
                cmbOpremaIzbor.SelectedIndex = 0;
            listViewKatalog.Refresh();
        }

        public void PopuniDodeljenuOpremu()
        {
            listViewDodeljena.Items.Clear();
            if (cmbVozila.SelectedValue is int vId)
            {
                var dodeljena = DTOManager.vratiOpremuZaVozilo(vId);
                foreach (var d in dodeljena)
                {
                    ListViewItem item = new(new string[] {
                        d.OpremaId.ToString(),
                        d.OpremaNaziv,
                        d.IsDodatna ? "Dodatna" : "Fabrička",
                        d.OpremaOpis ?? string.Empty
                    });
                    listViewDodeljena.Items.Add(item);
                }
            }
            listViewDodeljena.Refresh();
        }

        private void cmbVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniDodeljenuOpremu();
        }

        private void btnDodajKatalog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivOpreme.Text))
            {
                MessageBox.Show("Molimo unesite naziv opreme.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpremaPregled op = new()
            {
                Naziv = txtNazivOpreme.Text.Trim(),
                Opis = txtOpisOpreme.Text.Trim()
            };

            if (DTOManager.dodajOpremu(op))
            {
                txtNazivOpreme.Clear();
                txtOpisOpreme.Clear();
                PopuniKatalogOpreme();
            }
        }

        private void btnObrisiKatalog_Click(object sender, EventArgs e)
        {
            if (listViewKatalog.SelectedItems.Count == 0) return;
            int opId = int.Parse(listViewKatalog.SelectedItems[0].SubItems[0].Text);

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovu stavku opreme?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DTOManager.obrisiOpremu(opId))
                    PopuniKatalogOpreme();
            }
        }

        private void btnDodeli_Click(object sender, EventArgs e)
        {
            if (cmbVozila.SelectedValue is int vId && cmbOpremaIzbor.SelectedItem is OpremaPregled op)
            {
                bool isDodatna = chkDodatna.Checked;
                if (DTOManager.dodajOpremuVozilu(vId, op.Id, isDodatna))
                {
                    PopuniDodeljenuOpremu();
                }
            }
        }

        private void btnUkloniDodeljenu_Click(object sender, EventArgs e)
        {
            if (cmbVozila.SelectedValue is int vId && listViewDodeljena.SelectedItems.Count > 0)
            {
                int opId = int.Parse(listViewDodeljena.SelectedItems[0].SubItems[0].Text);
                if (DTOManager.obrisiOpremuSaVozila(vId, opId))
                {
                    PopuniDodeljenuOpremu();
                }
            }
        }
    }
}
