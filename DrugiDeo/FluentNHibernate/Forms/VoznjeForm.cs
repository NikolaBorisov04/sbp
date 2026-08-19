using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentNHibernateTemplate.Forms
{
    public partial class VoznjeForm : Form
    {
        public VoznjeForm()
        {
            InitializeComponent();
        }

        private void VoznjeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listaVoznji.Items.Clear();
            List<VoznjaPregled> podaci = DTOManager.vratiSveVoznje();

            foreach (VoznjaPregled v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    v.Id.ToString(),
                    v.VremePocetka.ToString("dd.MM.yyyy HH:mm"),
                    v.VremeZavrsetka.ToString("dd.MM.yyyy HH:mm"),
                    v.PredjenaKilometraza.ToString(),
                    v.TrajanjeMinuti.ToString(),
                    v.PocetniNivo.ToString(),
                    v.KrajnjiNivo.ToString(),
                    v.PocetnaLokacija,
                    v.KrajnjaLokacija,
                    v.Cena.ToString(),
                    v.Naknade.ToString()
                });
                listaVoznji.Items.Add(item);
            }

            listaVoznji.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaVoznji.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vožnju čije podatke želite da izmenite");
                return;
            }

            int idVoznje = Int32.Parse(listaVoznji.SelectedItems[0].SubItems[0].Text);
            VoznjaPregled vb = DTOManager.vratiVoznju(idVoznje);

            VoznjaUpdateForm formaUpdate = new VoznjaUpdateForm(vb);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
