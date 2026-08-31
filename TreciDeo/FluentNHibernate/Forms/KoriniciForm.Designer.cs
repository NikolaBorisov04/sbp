namespace FluentNHibernateTemplate.Forms
{
    partial class KorisniciForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewKorisnici;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colImeNaziv;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colTip;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colDatumRegistracije;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnUloge;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodatniPodaci;

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
            this.listViewKorisnici = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colImeNaziv = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();
            this.colTip = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.colDatumRegistracije = new System.Windows.Forms.ColumnHeader();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnUloge = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodatniPodaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewKorisnici
            // 
            this.listViewKorisnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colImeNaziv,
            this.colEmail,
            this.colTip,
            this.colStatus,
            this.colDatumRegistracije});
            this.listViewKorisnici.FullRowSelect = true;
            this.listViewKorisnici.GridLines = true;
            this.listViewKorisnici.Location = new System.Drawing.Point(20, 20);
            this.listViewKorisnici.MultiSelect = false;
            this.listViewKorisnici.Name = "listViewKorisnici";
            this.listViewKorisnici.Size = new System.Drawing.Size(760, 380);
            this.listViewKorisnici.TabIndex = 0;
            this.listViewKorisnici.UseCompatibleStateImageBehavior = false;
            this.listViewKorisnici.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 50;
            // 
            // colImeNaziv
            // 
            this.colImeNaziv.Text = "Ime / Naziv";
            this.colImeNaziv.Width = 180;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 180;
            // 
            // colTip
            // 
            this.colTip.Text = "Tip korisnika";
            this.colTip.Width = 110;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status naloga";
            this.colStatus.Width = 110;
            // 
            // colDatumRegistracije
            // 
            this.colDatumRegistracije.Text = "Datum registracije";
            this.colDatumRegistracije.Width = 120;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(20, 415);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 35);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(165, 415);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(130, 35);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnUloge
            // 
            this.btnUloge.Location = new System.Drawing.Point(310, 415);
            this.btnUloge.Name = "btnUloge";
            this.btnUloge.Size = new System.Drawing.Size(130, 35);
            this.btnUloge.TabIndex = 3;
            this.btnUloge.Text = "Uloge";
            this.btnUloge.UseVisualStyleBackColor = true;
            this.btnUloge.Click += new System.EventHandler(this.btnUloge_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(455, 415);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(130, 35);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodatniPodaci
            // 
            this.btnDodatniPodaci.Location = new System.Drawing.Point(600, 415);
            this.btnDodatniPodaci.Name = "btnDodatniPodaci";
            this.btnDodatniPodaci.Size = new System.Drawing.Size(130, 35);
            this.btnDodatniPodaci.TabIndex = 5;
            this.btnDodatniPodaci.Text = "Dodatno";
            this.btnDodatniPodaci.UseVisualStyleBackColor = true;
            this.btnDodatniPodaci.Click += new System.EventHandler(this.btnDodatniPodaci_Click);
            // 
            // KorisniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 470);
            this.Controls.Add(this.btnDodatniPodaci);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUloge);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listViewKorisnici);
            this.Name = "KorisniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.KorisniciForm_Load);
            this.ResumeLayout(false);
        }
    }
}