using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Mapping;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FluentNHibernateTemplate.Forms
{
    public partial class VoznjaCreateUpdateForm : Form
    {
        public VoznjaPregled voznja;
        private bool kreiranje;
        public VoznjaCreateUpdateForm()
        {
            InitializeComponent();
            this.voznja = new VoznjaPregled();
            this.kreiranje = true;
            this.Text = "Kreiraj vožnju";
            comboBox1.Enabled = true;
        }

        public VoznjaCreateUpdateForm(VoznjaPregled v)
        {
            InitializeComponent();
            this.voznja = v;
            this.Text = "Izmeni vožnju";
            this.kreiranje = false;
            comboBox1.Enabled = false;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dateTimePicker1.Value = voznja.VremePocetka;
            dateTimePicker2.Value = voznja.VremeZavrsetka;
            numericUpDown1.Value = voznja.PredjenaKilometraza;
            numericUpDown2.Value = voznja.TrajanjeMinuti;
            numericUpDown3.Value = voznja.PocetniNivo;
            numericUpDown4.Value = voznja.KrajnjiNivo;
            textBox2.Text = voznja.PocetnaLokacija;
            textBox6.Text = voznja.KrajnjaLokacija;
            numericUpDown5.Value = voznja.Cena;
            numericUpDown6.Value = voznja.Naknade;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string poruka = this.kreiranje ? "Da li želite da kreirate novu vožnju?" : "Da li želite da izvršite izmene vožnje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.voznja.VremePocetka = dateTimePicker1.Value;
                this.voznja.VremeZavrsetka = dateTimePicker2.Value;
                this.voznja.PredjenaKilometraza = numericUpDown1.Value;
                this.voznja.TrajanjeMinuti = (int)numericUpDown2.Value;
                this.voznja.PocetniNivo = numericUpDown3.Value;
                this.voznja.KrajnjiNivo = numericUpDown4.Value;
                this.voznja.PocetnaLokacija = textBox2.Text;
                this.voznja.KrajnjaLokacija = textBox6.Text;
                this.voznja.Cena = numericUpDown5.Value;
                this.voznja.Naknade = numericUpDown6.Value;
                
                if (this.kreiranje)
                {
                    this.voznja.RezervacijaId = (int)comboBox1.SelectedValue;
                    DTOManager.dodajVoznju(this.voznja);
                    MessageBox.Show("Kreiranje nove vožnje je uspešno izvršeno!");
                }
                else
                {
                    DTOManager.azurirajVoznju(this.voznja);
                    MessageBox.Show("Ažuriranje vožnje je uspešno izvršeno!");
                }

                this.Close();
            }
        }

        private void VoznjaCreateUpdateForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DTOManager.vratiRezervacijeBezVoznje();
            comboBox1.DisplayMember = "";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
