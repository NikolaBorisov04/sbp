namespace FluentNHibernateTemplate.Forms
{
    partial class PunjenjaTocenjaForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewPunjenja;
        private ColumnHeader colId;
        private ColumnHeader colVozilo;
        private ColumnHeader colDatumVreme;
        private ColumnHeader colLokacija;
        private ColumnHeader colKolicina;
        private ColumnHeader colCena;
        private ColumnHeader colNacin;
        private ColumnHeader colEvidentirao;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private GroupBox grpAkcije;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listViewPunjenja = new ListView();
            colId = new ColumnHeader();
            colVozilo = new ColumnHeader();
            colDatumVreme = new ColumnHeader();
            colLokacija = new ColumnHeader();
            colKolicina = new ColumnHeader();
            colCena = new ColumnHeader();
            colNacin = new ColumnHeader();
            colEvidentirao = new ColumnHeader();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            grpAkcije = new GroupBox();
            grpAkcije.SuspendLayout();
            SuspendLayout();
            // 
            // listViewPunjenja
            // 
            listViewPunjenja.Columns.AddRange(new ColumnHeader[] {
                colId, colVozilo, colDatumVreme, colLokacija, colKolicina, colCena, colNacin, colEvidentirao
            });
            listViewPunjenja.FullRowSelect = true;
            listViewPunjenja.GridLines = true;
            listViewPunjenja.Location = new Point(12, 12);
            listViewPunjenja.MultiSelect = false;
            listViewPunjenja.Name = "listViewPunjenja";
            listViewPunjenja.Size = new Size(820, 420);
            listViewPunjenja.TabIndex = 0;
            listViewPunjenja.UseCompatibleStateImageBehavior = false;
            listViewPunjenja.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 40;
            // 
            // colVozilo
            // 
            colVozilo.Text = "Vozilo";
            colVozilo.Width = 140;
            // 
            // colDatumVreme
            // 
            colDatumVreme.Text = "Datum i vreme";
            colDatumVreme.Width = 130;
            // 
            // colLokacija
            // 
            colLokacija.Text = "Lokacija";
            colLokacija.Width = 150;
            // 
            // colKolicina
            // 
            colKolicina.Text = "Količina (L/kWh)";
            colKolicina.Width = 110;
            // 
            // colCena
            // 
            colCena.Text = "Cena (RSD)";
            colCena.Width = 90;
            // 
            // colNacin
            // 
            colNacin.Text = "Način evid.";
            colNacin.Width = 100;
            // 
            // colEvidentirao
            // 
            colEvidentirao.Text = "Evidentirao";
            colEvidentirao.Width = 100;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(15, 25);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 30);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj zapis";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(15, 65);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(130, 30);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni zapis";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(15, 105);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(130, 30);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši zapis";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // grpAkcije
            // 
            grpAkcije.Controls.Add(btnDodaj);
            grpAkcije.Controls.Add(btnIzmeni);
            grpAkcije.Controls.Add(btnObrisi);
            grpAkcije.Location = new Point(845, 12);
            grpAkcije.Name = "grpAkcije";
            grpAkcije.Size = new Size(160, 150);
            grpAkcije.TabIndex = 1;
            grpAkcije.TabStop = false;
            grpAkcije.Text = "Akcije";
            // 
            // PunjenjaTocenjaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 445);
            Controls.Add(grpAkcije);
            Controls.Add(listViewPunjenja);
            Name = "PunjenjaTocenjaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Evidencija Punjenja i Točenja";
            Load += PunjenjaTocenjaForm_Load;
            grpAkcije.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
