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
    public partial class DogadjajUVoznjiForm : Form
    {
        public VoznjaPregled voznja;
        public DogadjajUVoznjiForm()
        {
            InitializeComponent();
        }

        public DogadjajUVoznjiForm(VoznjaPregled voznja)
        {
            this.voznja = voznja;
            InitializeComponent();
        }

        private void DogadjajUVoznjiForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listaDogadjaja.Items.Clear();
            List<DogadjajUVoznjiPregled> podaci = DTOManager.vratiDogadjajeZaVoznju(this.voznja.Id);

            foreach (DogadjajUVoznjiPregled v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    v.Id.ToString(),
                    v.Tip,
                    v.Vreme.ToString("dd.MM.yyyy HH:mm"),
                    v.Lokacija,
                    v.Opis
                });
                listaDogadjaja.Items.Add(item);
            }
            listaDogadjaja.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DogadjajUVoznjiCreateUpdateForm forma = new DogadjajUVoznjiCreateUpdateForm(this.voznja);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaDogadjaja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite događaj podatke želite da izmenite");
                return;
            }

            int idDogadjaja = Int32.Parse(listaDogadjaja.SelectedItems[0].SubItems[0].Text);
            DogadjajUVoznjiPregled d = DTOManager.vratiDogadjaj(idDogadjaja);

            DogadjajUVoznjiCreateUpdateForm formaUpdate = new DogadjajUVoznjiCreateUpdateForm(d, this.voznja);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (listaDogadjaja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite događaj čije podatke želite da obrišete");
                return;
            }
            int idDogadjaja = Int32.Parse(listaDogadjaja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabran događaj?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiDogadjaj(idDogadjaja);
                MessageBox.Show("Brisanje događaja je uspešno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
