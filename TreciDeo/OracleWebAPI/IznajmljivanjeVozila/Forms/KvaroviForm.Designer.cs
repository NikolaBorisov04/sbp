namespace FluentNHibernateTemplate.Forms
{
    partial class KvaroviForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewKvarovi;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colVozilo;
        private System.Windows.Forms.ColumnHeader colPrijavio;
        private System.Windows.Forms.ColumnHeader colDatumPrijave;
        private System.Windows.Forms.ColumnHeader colOzbiljnost;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colOtklonjeno;
        private System.Windows.Forms.ColumnHeader colOpis;
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
            this.listViewKvarovi = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colVozilo = new System.Windows.Forms.ColumnHeader();
            this.colPrijavio = new System.Windows.Forms.ColumnHeader();
            this.colDatumPrijave = new System.Windows.Forms.ColumnHeader();
            this.colOzbiljnost = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.colOtklonjeno = new System.Windows.Forms.ColumnHeader();
            this.colOpis = new System.Windows.Forms.ColumnHeader();
            this.grpAkcije = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.grpAkcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewKvarovi
            // 
            this.listViewKvarovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colVozilo,
            this.colPrijavio,
            this.colDatumPrijave,
            this.colOzbiljnost,
            this.colStatus,
            this.colOtklonjeno,
            this.colOpis});
            this.listViewKvarovi.FullRowSelect = true;
            this.listViewKvarovi.GridLines = true;
            this.listViewKvarovi.Location = new System.Drawing.Point(12, 12);
            this.listViewKvarovi.MultiSelect = false;
            this.listViewKvarovi.Name = "listViewKvarovi";
            this.listViewKvarovi.Size = new System.Drawing.Size(820, 420);
            this.listViewKvarovi.TabIndex = 0;
            this.listViewKvarovi.UseCompatibleStateImageBehavior = false;
            this.listViewKvarovi.View = System.Windows.Forms.View.Details;
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
            // colPrijavio
            // 
            this.colPrijavio.Text = "Prijavio";
            this.colPrijavio.Width = 90;
            // 
            // colDatumPrijave
            // 
            this.colDatumPrijave.Text = "Prijava";
            this.colDatumPrijave.Width = 90;
            // 
            // colOzbiljnost
            // 
            this.colOzbiljnost.Text = "Ozbiljnost";
            this.colOzbiljnost.Width = 90;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 80;
            // 
            // colOtklonjeno
            // 
            this.colOtklonjeno.Text = "Otklonjeno";
            this.colOtklonjeno.Width = 90;
            // 
            // colOpis
            // 
            this.colOpis.Text = "Opis problema";
            this.colOpis.Width = 190;
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
            this.btnObrisi.Text = "Obriši kvar";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(15, 65);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(130, 30);
            this.btnIzmeni.TabIndex = 1;
            this.btnIzmeni.Text = "Izmeni kvar";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Prijavi kvar";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // KvaroviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 445);
            this.Controls.Add(this.grpAkcije);
            this.Controls.Add(this.listViewKvarovi);
            this.Name = "KvaroviForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evidencija Kvarova";
            this.Load += new System.EventHandler(this.KvaroviForm_Load);
            this.grpAkcije.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
