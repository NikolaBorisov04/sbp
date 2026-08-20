namespace FluentNHibernateTemplate.Forms
{
    partial class NezgodeSteteForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewNezgode;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colVozilo;
        private System.Windows.Forms.ColumnHeader colOdgovornost;
        private System.Windows.Forms.ColumnHeader colProcena;
        private System.Windows.Forms.ColumnHeader colSlike;
        private System.Windows.Forms.ColumnHeader colKuce;
        private System.Windows.Forms.ColumnHeader colZapisnici;
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
            this.listViewNezgode = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colVozilo = new System.Windows.Forms.ColumnHeader();
            this.colOdgovornost = new System.Windows.Forms.ColumnHeader();
            this.colProcena = new System.Windows.Forms.ColumnHeader();
            this.colSlike = new System.Windows.Forms.ColumnHeader();
            this.colKuce = new System.Windows.Forms.ColumnHeader();
            this.colZapisnici = new System.Windows.Forms.ColumnHeader();
            this.grpAkcije = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.grpAkcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewNezgode
            // 
            this.listViewNezgode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colVozilo,
            this.colOdgovornost,
            this.colProcena,
            this.colSlike,
            this.colKuce,
            this.colZapisnici});
            this.listViewNezgode.FullRowSelect = true;
            this.listViewNezgode.GridLines = true;
            this.listViewNezgode.Location = new System.Drawing.Point(12, 12);
            this.listViewNezgode.MultiSelect = false;
            this.listViewNezgode.Name = "listViewNezgode";
            this.listViewNezgode.Size = new System.Drawing.Size(820, 420);
            this.listViewNezgode.TabIndex = 0;
            this.listViewNezgode.UseCompatibleStateImageBehavior = false;
            this.listViewNezgode.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 40;
            // 
            // colVozilo
            // 
            this.colVozilo.Text = "Vozilo";
            this.colVozilo.Width = 160;
            // 
            // colOdgovornost
            // 
            this.colOdgovornost.Text = "Odgovornost";
            this.colOdgovornost.Width = 110;
            // 
            // colProcena
            // 
            this.colProcena.Text = "Procena štete (RSD)";
            this.colProcena.Width = 140;
            // 
            // colSlike
            // 
            this.colSlike.Text = "Fotografije";
            this.colSlike.Width = 90;
            // 
            // colKuce
            // 
            this.colKuce.Text = "Osiguranja";
            this.colKuce.Width = 90;
            // 
            // colZapisnici
            // 
            this.colZapisnici.Text = "Zapisnici";
            this.colZapisnici.Width = 90;
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
            this.btnObrisi.Text = "Obriši štetu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(15, 65);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(130, 30);
            this.btnIzmeni.TabIndex = 1;
            this.btnIzmeni.Text = "Izmeni / Detalji";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Nova šteta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // NezgodeSteteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 445);
            this.Controls.Add(this.grpAkcije);
            this.Controls.Add(this.listViewNezgode);
            this.Name = "NezgodeSteteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evidencija Nezgoda i Šteta";
            this.Load += new System.EventHandler(this.NezgodeSteteForm_Load);
            this.grpAkcije.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
