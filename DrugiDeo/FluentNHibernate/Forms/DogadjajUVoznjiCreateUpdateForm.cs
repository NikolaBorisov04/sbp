using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FluentNHibernateTemplate.Forms
{
    public partial class DogadjajUVoznjiCreateUpdateForm : Form
    {
        public DogadjajUVoznjiPregled dogadjaj;
        public VoznjaPregled voznja;
        private bool kreiranje;
        public DogadjajUVoznjiCreateUpdateForm(VoznjaPregled v)
        {
            InitializeComponent();
            this.dogadjaj = new DogadjajUVoznjiPregled();
            this.voznja = v;
            this.kreiranje = true;
            this.Text = "Kreiraj događaj";
        }

        public DogadjajUVoznjiCreateUpdateForm(DogadjajUVoznjiPregled dogadjaj, VoznjaPregled voznja)
        {
            InitializeComponent();
            this.dogadjaj = dogadjaj;
            this.kreiranje = false;
            this.voznja = voznja;
            popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = this.kreiranje ? "Da li želite da kreirate novi događaj?" : "Da li želite da izvršite izmene događaja?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.dogadjaj.Tip = textBox1.Text;
                this.dogadjaj.Vreme = dateTimePicker1.Value;
                this.dogadjaj.Lokacija = textBox2.Text;
                this.dogadjaj.Opis = textBox3.Text;
                
                if (this.kreiranje)
                {
                    DTOManager.dodajDogadjaj(this.dogadjaj, this.voznja.Id);
                    MessageBox.Show("Kreiranje novog događaja je uspešno izvršeno!");
                }
                else
                {
                    DTOManager.azurirajDogadjaj(this.dogadjaj);
                    MessageBox.Show("Ažuriranje događaja je uspešno izvršeno!");
                }
                this.Close();
            }
        }

        private void popuniPodacima()
        {
            textBox1.Text = dogadjaj.Tip;
            dateTimePicker1.Value = dogadjaj.Vreme;
            textBox2.Text = dogadjaj.Lokacija;
            textBox3.Text = dogadjaj.Opis;
        }
    }
}
