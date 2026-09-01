namespace FluentNHibernateTemplate.Forms
{
    partial class PunjenjaTocenjaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewPunjenja;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colVozilo;
        private System.Windows.Forms.ColumnHeader colDatumVreme;
        private System.Windows.Forms.ColumnHeader colLokacija;
        private System.Windows.Forms.ColumnHeader colKolicina;
        private System.Windows.Forms.ColumnHeader colCena;
        private System.Windows.Forms.ColumnHeader colNacin;
        private System.Windows.Forms.ColumnHeader colEvidentirao;
        private System.Windows.Forms.GroupBox grpAkcije;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;

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
            this.listViewPunjenja = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colVozilo = new System.Windows.Forms.ColumnHeader();
            this.colDatumVreme = new System.Windows.Forms.ColumnHeader();
            this.colLokacija = new System.Windows.Forms.ColumnHeader();
            this.colKolicina = new System.Windows.Forms.ColumnHeader();
            this.colCena = new System.Windows.Forms.ColumnHeader();
            this.colNacin = new System.Windows.Forms.ColumnHeader();
            this.colEvidentirao = new System.Windows.Forms.ColumnHeader();
            this.grpAkcije = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.grpAkcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPunjenja
            // 
            this.listViewPunjenja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colVozilo,
            this.colDatumVreme,
            this.colLokacija,
            this.colKolicina,
            this.colCena,
            this.colNacin,
            this.colEvidentirao});
            this.listViewPunjenja.FullRowSelect = true;
            this.listViewPunjenja.GridLines = true;
            this.listViewPunjenja.Location = new System.Drawing.Point(12, 12);
            this.listViewPunjenja.MultiSelect = false;
            this.listViewPunjenja.Name = "listViewPunjenja";
            this.listViewPunjenja.Size = new System.Drawing.Size(820, 420);
            this.listViewPunjenja.TabIndex = 0;
            this.listViewPunjenja.UseCompatibleStateImageBehavior = false;
            this.listViewPunjenja.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 40;
            // 
            // colVozilo
            // 
            this.colVozilo.Text = "Vozilo";
            this.colVozilo.Width = 140;
            // 
            // colDatumVreme
            // 
            this.colDatumVreme.Text = "Datum i vreme";
            this.colDatumVreme.Width = 130;
            // 
            // colLokacija
            // 
            this.colLokacija.Text = "Lokacija";
            this.colLokacija.Width = 150;
            // 
            // colKolicina
            // 
            this.colKolicina.Text = "Količina (L/kWh)";
            this.colKolicina.Width = 110;
            // 
            // colCena
            // 
            this.colCena.Text = "Cena (RSD)";
            this.colCena.Width = 90;
            // 
            // colNacin
            // 
            this.colNacin.Text = "Način evid.";
            this.colNacin.Width = 100;
            // 
            // colEvidentirao
            // 
            this.colEvidentirao.Text = "Evidentirao";
            this.colEvidentirao.Width = 100;
            // 
            // grpAkcije
            // 
            this.grpAkcije.Controls.Add(this.btnObrisi);
            this.grpAkcije.Controls.Add(this.btnIzmeni);
            this.grpAkcije.Controls.Add(this.btnDodaj);
            this.grpAkcije.Location = new System.Drawing.Point(845, 12);
            this.grpAkcije.Name = "grpAkcije";
            this.grpAkcije.Size = new System.Drawing.Size(160, 150);
            this.grpAkcije.TabIndex = 1;
            this.grpAkcije.TabStop = false;
            this.grpAkcije.Text = "Akcije";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(15, 105);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(130, 30);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši zapis";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(15, 65);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(130, 30);
            this.btnIzmeni.TabIndex = 1;
            this.btnIzmeni.Text = "Izmeni zapis";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj zapis";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // PunjenjaTocenjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 445);
            this.Controls.Add(this.grpAkcije);
            this.Controls.Add(this.listViewPunjenja);
            this.Name = "PunjenjaTocenjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evidencija Punjenja i Točenja";
            this.Load += new System.EventHandler(this.PunjenjaTocenjaForm_Load);
            this.grpAkcije.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
