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
    public partial class RezervacijaCreateUpdateForm : Form
    {
        public RezervacijaPregled rezervacija;
        private bool kreiranje;
        public RezervacijaCreateUpdateForm()
        {
            InitializeComponent();
            this.rezervacija = new SluzbenaVoznjaPregled();
            this.kreiranje = true;
            this.Text = "Kreiraj rezervaciju";
            this.ucitajPodatkeComboBox();
        }

        public RezervacijaCreateUpdateForm(RezervacijaPregled rezervacija)
        {
            InitializeComponent();
            this.rezervacija = rezervacija;
            this.kreiranje = false;
            this.Text = "Izmeni rezervaciju";
            checkBox1.Enabled = false;
            this.ucitajPodatkeComboBox();
            this.popuniPodacima();
        }
        private void popuniPodacima()
        {
            dateTimePicker1.Value = this.rezervacija.VremePocetka;
            dateTimePicker2.Value = this.rezervacija.VremeZavrsetka;
            textBox1.Text = this.rezervacija.LokacijaPreuzimanja;
            textBox2.Text = this.rezervacija.LokacijaVracanja;
            checkBox1.Checked = (this.rezervacija.Tip == "Službena");
            textBox4.Text = this.rezervacija.Status;
            comboBox1.SelectedValue = this.rezervacija.KorisnikId;
            comboBox2.SelectedValue = this.rezervacija.VoziloId;
            comboBox3.SelectedValue = this.rezervacija.VozacId;

            if (this.rezervacija is SluzbenaVoznjaPregled sluzbena)
            {
                checkBox1.Checked = true;
                textBox5.Text = sluzbena.Razlog;
                textBox6.Text = sluzbena.OvlascenoLice;
            }
        }

        //dopuniti ovo kada budu napravljene metode
        private void ucitajPodatkeComboBox()
        {
            //comboBox1.DataSource = DTOManager.vratiSveKorisnike();
            comboBox2.DataSource = DTOManager.vratiSvaVozila();
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "";
            //comboBox3.DataSource = DTOManager.vratiSvaFizickaLica();
        }

        private void RezervacijaCreateUpdateForm_Load(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                comboBox3.Enabled = false;
                label10.Visible = false;
                textBox5.Visible = false;
                label11.Visible = false;
                textBox6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = this.kreiranje ? "Da li želite da kreirate novu rezervaciju?" : "Da li želite da izvršite izmene rezervacije?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result != DialogResult.OK) return;
            if (checkBox1.Checked)
            {
                if (!(this.rezervacija is SluzbenaVoznjaPregled sluzbena))
                {
                    sluzbena = new SluzbenaVoznjaPregled();
                }
                sluzbena.VremePocetka = dateTimePicker1.Value;
                sluzbena.VremeZavrsetka = dateTimePicker2.Value;
                sluzbena.LokacijaPreuzimanja = textBox1.Text;
                sluzbena.LokacijaVracanja = textBox2.Text;
                sluzbena.Tip = "Službena";
                sluzbena.Status = textBox4.Text;
                sluzbena.VoziloId = (int)comboBox2.SelectedValue;
                sluzbena.Razlog = textBox5.Text;
                sluzbena.OvlascenoLice = textBox6.Text;

                if (this.kreiranje)
                {
                    DTOManager.dodajSluzbenuVoznju(sluzbena);
                    MessageBox.Show("Kreiranje nove službene vožnje je uspešno izvršeno!");
                }
                else
                {
                    DTOManager.azurirajSluzbenuVoznju(sluzbena);
                    MessageBox.Show("Ažuriranje službene vožnje je uspešno izvršeno!");
                }
            }
            else
            {
                this.rezervacija.VremePocetka = dateTimePicker1.Value;
                this.rezervacija.VremeZavrsetka = dateTimePicker2.Value;
                this.rezervacija.LokacijaPreuzimanja = textBox1.Text;
                this.rezervacija.LokacijaVracanja = textBox2.Text;
                this.rezervacija.Tip = "Privatna";
                this.rezervacija.Status = textBox4.Text;
                this.rezervacija.VoziloId = (int)comboBox2.SelectedValue;

                if (this.kreiranje)
                {
                    DTOManager.dodajRezervaciju(this.rezervacija);
                    MessageBox.Show("Kreiranje nove rezervacije je uspešno izvršeno!");
                }
                else
                {
                    DTOManager.azurirajRezervaciju(this.rezervacija);
                    MessageBox.Show("Ažuriranje rezervacije je uspešno izvršeno!");
                }
            }

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label10.Visible = true;
                textBox5.Visible = true;
                label11.Visible = true;
                textBox6.Visible = true;    
            }
            else
            {
                label10.Visible = false;
                textBox5.Visible = false;
                label11.Visible = false;
                textBox6.Visible = false;
            }
        }
    }
}
