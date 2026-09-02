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
    public partial class RezervacijeForm : Form
    {
        public RezervacijeForm()
        {
            InitializeComponent();
        }

        private void popuniPodacima()
        {
            listaRezervacija.Items.Clear();
            List<RezervacijaPregled> podaci = DTOManager.vratiSveRezervacije();

            foreach (RezervacijaPregled v in podaci)
            {
                string razlog = "";
                string ovlascenoLice = "";

                if (v is SluzbenaVoznjaPregled sluzbena)
                {
                    razlog = sluzbena.Razlog;
                    ovlascenoLice = sluzbena.OvlascenoLice;
                }

                ListViewItem item = new ListViewItem(new string[] {
                    v.Id.ToString(),
                    v.VremePocetka.ToString("dd.MM.yyyy HH:mm"),
                    v.VremeZavrsetka.ToString("dd.MM.yyyy HH:mm"),
                    v.LokacijaPreuzimanja,
                    v.LokacijaVracanja,
                    v.Tip,
                    v.Status,
                    v.KorisnikInfo,
                    v.VoziloInfo,
                    v.VozacInfo,
                    razlog,
                    ovlascenoLice

                });
                listaRezervacija.Items.Add(item);
            }

            listaRezervacija.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervacijaCreateUpdateForm forma = new RezervacijaCreateUpdateForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaRezervacija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite rezervaciju čije podatke želite da izmenite");
                return;
            }

            int idRezervacije = Int32.Parse(listaRezervacija.SelectedItems[0].SubItems[0].Text);
            RezervacijaPregled r = DTOManager.vratiRezervaciju(idRezervacije);

            RezervacijaCreateUpdateForm forma = new RezervacijaCreateUpdateForm(r);
            forma.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaRezervacija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite rezervaciju čije podatke želite da obrišete");
                return;
            }
            int idRezervacije = Int32.Parse(listaRezervacija.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu rezervaciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiRezervaciju(idRezervacije);
                MessageBox.Show("Brisanje rezervacije je uspešno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void RezervacijeForm_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }
    }
}
