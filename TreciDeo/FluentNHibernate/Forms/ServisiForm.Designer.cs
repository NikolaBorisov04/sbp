namespace FluentNHibernateTemplate.Forms
{
    partial class ServisiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewServisi;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colVozilo;
        private System.Windows.Forms.ColumnHeader colTip;
        private System.Windows.Forms.ColumnHeader colCentar;
        private System.Windows.Forms.ColumnHeader colDatumPrijema;
        private System.Windows.Forms.ColumnHeader colDatumZavrsetka;
        private System.Windows.Forms.ColumnHeader colTroskovi;
        private System.Windows.Forms.ColumnHeader colStatus;
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
            this.listViewServisi = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colVozilo = new System.Windows.Forms.ColumnHeader();
            this.colTip = new System.Windows.Forms.ColumnHeader();
            this.colCentar = new System.Windows.Forms.ColumnHeader();
            this.colDatumPrijema = new System.Windows.Forms.ColumnHeader();
            this.colDatumZavrsetka = new System.Windows.Forms.ColumnHeader();
            this.colTroskovi = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.grpAkcije = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.grpAkcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewServisi
            // 
            this.listViewServisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colVozilo,
            this.colTip,
            this.colCentar,
            this.colDatumPrijema,
            this.colDatumZavrsetka,
            this.colTroskovi,
            this.colStatus});
            this.listViewServisi.FullRowSelect = true;
            this.listViewServisi.GridLines = true;
            this.listViewServisi.Location = new System.Drawing.Point(12, 12);
            this.listViewServisi.MultiSelect = false;
            this.listViewServisi.Name = "listViewServisi";
            this.listViewServisi.Size = new System.Drawing.Size(820, 420);
            this.listViewServisi.TabIndex = 0;
            this.listViewServisi.UseCompatibleStateImageBehavior = false;
            this.listViewServisi.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 40;
            // 
            // colVozilo
            // 
            this.colVozilo.Text = "Vozilo";
            this.colVozilo.Width = 150;
            // 
            // colTip
            // 
            this.colTip.Text = "Tip servisa";
            this.colTip.Width = 100;
            // 
            // colCentar
            // 
            this.colCentar.Text = "Servisni centar";
            this.colCentar.Width = 170;
            // 
            // colDatumPrijema
            // 
            this.colDatumPrijema.Text = "Prijem";
            this.colDatumPrijema.Width = 90;
            // 
            // colDatumZavrsetka
            // 
            this.colDatumZavrsetka.Text = "Završetak";
            this.colDatumZavrsetka.Width = 90;
            // 
            // colTroskovi
            // 
            this.colTroskovi.Text = "Troškovi (RSD)";
            this.colTroskovi.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 80;
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
            this.btnObrisi.Text = "Obriši servis";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(15, 65);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(130, 30);
            this.btnIzmeni.TabIndex = 1;
            this.btnIzmeni.Text = "Izmeni servis";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Evidentiraj servis";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ServisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 445);
            this.Controls.Add(this.grpAkcije);
            this.Controls.Add(this.listViewServisi);
            this.Name = "ServisiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evidencija Servisa";
            this.Load += new System.EventHandler(this.ServisiForm_Load);
            this.grpAkcije.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
