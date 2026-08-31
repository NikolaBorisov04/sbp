namespace FluentNHibernateTemplate.Forms
{
    partial class KorisnikCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTipKorisnika;
        private System.Windows.Forms.ComboBox cmbTipKorisnika;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDatumRegistracije;
        private System.Windows.Forms.DateTimePicker dtpDatumRegistracije;
        private System.Windows.Forms.Label lblStatusNaloga;
        private System.Windows.Forms.TextBox txtStatusNaloga;
        private System.Windows.Forms.Label lblNacinVerifikacije;
        private System.Windows.Forms.TextBox txtNacinVerifikacije;

        private System.Windows.Forms.Panel panelFizickoLice;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblBrojVozackeDozvole;
        private System.Windows.Forms.TextBox txtBrojVozackeDozvole;
        private System.Windows.Forms.Label lblKategorijeDozvole;
        private System.Windows.Forms.TextBox txtKategorijeDozvole;
        private System.Windows.Forms.Label lblDatumIzdavanjaDozvole;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanjaDozvole;
        private System.Windows.Forms.Label lblDatumIstekaDozvole;
        private System.Windows.Forms.DateTimePicker dtpDatumIstekaDozvole;

        private System.Windows.Forms.Panel panelPravnoLice;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblPib;
        private System.Windows.Forms.TextBox txtPib;
        private System.Windows.Forms.Label lblMaticniBroj;
        private System.Windows.Forms.TextBox txtMaticniBroj;
        private System.Windows.Forms.Label lblSediste;
        private System.Windows.Forms.TextBox txtSediste;
        private System.Windows.Forms.Label lblKontaktOsoba;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.Label lblUgovoreniUsloviKoriscenja;
        private System.Windows.Forms.TextBox txtUgovoreniUsloviKoriscenja;

        private System.Windows.Forms.Button btnSacuvaj;

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
            this.lblTipKorisnika = new System.Windows.Forms.Label();
            this.cmbTipKorisnika = new System.Windows.Forms.ComboBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDatumRegistracije = new System.Windows.Forms.Label();
            this.dtpDatumRegistracije = new System.Windows.Forms.DateTimePicker();
            this.lblStatusNaloga = new System.Windows.Forms.Label();
            this.txtStatusNaloga = new System.Windows.Forms.TextBox();
            this.lblNacinVerifikacije = new System.Windows.Forms.Label();
            this.txtNacinVerifikacije = new System.Windows.Forms.TextBox();

            this.panelFizickoLice = new System.Windows.Forms.Panel();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblBrojVozackeDozvole = new System.Windows.Forms.Label();
            this.txtBrojVozackeDozvole = new System.Windows.Forms.TextBox();
            this.lblKategorijeDozvole = new System.Windows.Forms.Label();
            this.txtKategorijeDozvole = new System.Windows.Forms.TextBox();
            this.lblDatumIzdavanjaDozvole = new System.Windows.Forms.Label();
            this.dtpDatumIzdavanjaDozvole = new System.Windows.Forms.DateTimePicker();
            this.lblDatumIstekaDozvole = new System.Windows.Forms.Label();
            this.dtpDatumIstekaDozvole = new System.Windows.Forms.DateTimePicker();

            this.panelPravnoLice = new System.Windows.Forms.Panel();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblPib = new System.Windows.Forms.Label();
            this.txtPib = new System.Windows.Forms.TextBox();
            this.lblMaticniBroj = new System.Windows.Forms.Label();
            this.txtMaticniBroj = new System.Windows.Forms.TextBox();
            this.lblSediste = new System.Windows.Forms.Label();
            this.txtSediste = new System.Windows.Forms.TextBox();
            this.lblKontaktOsoba = new System.Windows.Forms.Label();
            this.txtKontaktOsoba = new System.Windows.Forms.TextBox();
            this.lblUgovoreniUsloviKoriscenja = new System.Windows.Forms.Label();
            this.txtUgovoreniUsloviKoriscenja = new System.Windows.Forms.TextBox();

            this.btnSacuvaj = new System.Windows.Forms.Button();

            this.panelFizickoLice.SuspendLayout();
            this.panelPravnoLice.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTipKorisnika
            //
            this.lblTipKorisnika.AutoSize = true;
            this.lblTipKorisnika.Location = new System.Drawing.Point(20, 20);
            this.lblTipKorisnika.Name = "lblTipKorisnika";
            this.lblTipKorisnika.Size = new System.Drawing.Size(105, 20);
            this.lblTipKorisnika.TabIndex = 0;
            this.lblTipKorisnika.Text = "Tip korisnika:";
            //
            // cmbTipKorisnika
            //
            this.cmbTipKorisnika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipKorisnika.Location = new System.Drawing.Point(200, 17);
            this.cmbTipKorisnika.Name = "cmbTipKorisnika";
            this.cmbTipKorisnika.Size = new System.Drawing.Size(280, 28);
            this.cmbTipKorisnika.TabIndex = 1;
            this.cmbTipKorisnika.SelectedIndexChanged += new System.EventHandler(this.cmbTipKorisnika_SelectedIndexChanged);
            //
            // lblAdresa
            //
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(20, 60);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(60, 20);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa:";
            //
            // txtAdresa
            //
            this.txtAdresa.Location = new System.Drawing.Point(200, 57);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(280, 27);
            this.txtAdresa.TabIndex = 3;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(200, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 27);
            this.txtEmail.TabIndex = 5;
            //
            // lblDatumRegistracije
            //
            this.lblDatumRegistracije.AutoSize = true;
            this.lblDatumRegistracije.Location = new System.Drawing.Point(20, 140);
            this.lblDatumRegistracije.Name = "lblDatumRegistracije";
            this.lblDatumRegistracije.Size = new System.Drawing.Size(140, 20);
            this.lblDatumRegistracije.TabIndex = 6;
            this.lblDatumRegistracije.Text = "Datum registracije:";
            //
            // dtpDatumRegistracije
            //
            this.dtpDatumRegistracije.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRegistracije.Location = new System.Drawing.Point(200, 137);
            this.dtpDatumRegistracije.Name = "dtpDatumRegistracije";
            this.dtpDatumRegistracije.Size = new System.Drawing.Size(280, 27);
            this.dtpDatumRegistracije.TabIndex = 7;
            //
            // lblStatusNaloga
            //
            this.lblStatusNaloga.AutoSize = true;
            this.lblStatusNaloga.Location = new System.Drawing.Point(20, 180);
            this.lblStatusNaloga.Name = "lblStatusNaloga";
            this.lblStatusNaloga.Size = new System.Drawing.Size(110, 20);
            this.lblStatusNaloga.TabIndex = 8;
            this.lblStatusNaloga.Text = "Status naloga:";
            //
            // txtStatusNaloga
            //
            this.txtStatusNaloga.Location = new System.Drawing.Point(200, 177);
            this.txtStatusNaloga.Name = "txtStatusNaloga";
            this.txtStatusNaloga.Size = new System.Drawing.Size(280, 27);
            this.txtStatusNaloga.TabIndex = 9;
            //
            // lblNacinVerifikacije
            //
            this.lblNacinVerifikacije.AutoSize = true;
            this.lblNacinVerifikacije.Location = new System.Drawing.Point(20, 220);
            this.lblNacinVerifikacije.Name = "lblNacinVerifikacije";
            this.lblNacinVerifikacije.Size = new System.Drawing.Size(140, 20);
            this.lblNacinVerifikacije.TabIndex = 10;
            this.lblNacinVerifikacije.Text = "Način verifikacije:";
            //
            // txtNacinVerifikacije
            //
            this.txtNacinVerifikacije.Location = new System.Drawing.Point(200, 217);
            this.txtNacinVerifikacije.Name = "txtNacinVerifikacije";
            this.txtNacinVerifikacije.Size = new System.Drawing.Size(280, 27);
            this.txtNacinVerifikacije.TabIndex = 11;
            //
            // panelFizickoLice
            //
            this.panelFizickoLice.Location = new System.Drawing.Point(20, 260);
            this.panelFizickoLice.Name = "panelFizickoLice";
            this.panelFizickoLice.Size = new System.Drawing.Size(500, 300);
            this.panelFizickoLice.TabIndex = 12;
            this.panelFizickoLice.Controls.Add(this.lblJmbg);
            this.panelFizickoLice.Controls.Add(this.txtJmbg);
            this.panelFizickoLice.Controls.Add(this.lblIme);
            this.panelFizickoLice.Controls.Add(this.txtIme);
            this.panelFizickoLice.Controls.Add(this.lblPrezime);
            this.panelFizickoLice.Controls.Add(this.txtPrezime);
            this.panelFizickoLice.Controls.Add(this.lblBrojVozackeDozvole);
            this.panelFizickoLice.Controls.Add(this.txtBrojVozackeDozvole);
            this.panelFizickoLice.Controls.Add(this.lblKategorijeDozvole);
            this.panelFizickoLice.Controls.Add(this.txtKategorijeDozvole);
            this.panelFizickoLice.Controls.Add(this.lblDatumIzdavanjaDozvole);
            this.panelFizickoLice.Controls.Add(this.dtpDatumIzdavanjaDozvole);
            this.panelFizickoLice.Controls.Add(this.lblDatumIstekaDozvole);
            this.panelFizickoLice.Controls.Add(this.dtpDatumIstekaDozvole);
            //
            // lblJmbg
            //
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(0, 0);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(52, 20);
            this.lblJmbg.TabIndex = 0;
            this.lblJmbg.Text = "JMBG:";
            //
            // txtJmbg
            //
            this.txtJmbg.Location = new System.Drawing.Point(180, -3);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.Size = new System.Drawing.Size(280, 27);
            this.txtJmbg.TabIndex = 1;
            //
            // lblIme
            //
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(0, 40);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(38, 20);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            //
            // txtIme
            //
            this.txtIme.Location = new System.Drawing.Point(180, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(280, 27);
            this.txtIme.TabIndex = 3;
            //
            // lblPrezime
            //
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(0, 80);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(68, 20);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            //
            // txtPrezime
            //
            this.txtPrezime.Location = new System.Drawing.Point(180, 77);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(280, 27);
            this.txtPrezime.TabIndex = 5;
            //
            // lblBrojVozackeDozvole
            //
            this.lblBrojVozackeDozvole.AutoSize = true;
            this.lblBrojVozackeDozvole.Location = new System.Drawing.Point(0, 120);
            this.lblBrojVozackeDozvole.Name = "lblBrojVozackeDozvole";
            this.lblBrojVozackeDozvole.Size = new System.Drawing.Size(160, 20);
            this.lblBrojVozackeDozvole.TabIndex = 6;
            this.lblBrojVozackeDozvole.Text = "Broj vozačke dozvole:";
            //
            // txtBrojVozackeDozvole
            //
            this.txtBrojVozackeDozvole.Location = new System.Drawing.Point(180, 117);
            this.txtBrojVozackeDozvole.Name = "txtBrojVozackeDozvole";
            this.txtBrojVozackeDozvole.Size = new System.Drawing.Size(280, 27);
            this.txtBrojVozackeDozvole.TabIndex = 7;
            //
            // lblKategorijeDozvole
            //
            this.lblKategorijeDozvole.AutoSize = true;
            this.lblKategorijeDozvole.Location = new System.Drawing.Point(0, 160);
            this.lblKategorijeDozvole.Name = "lblKategorijeDozvole";
            this.lblKategorijeDozvole.Size = new System.Drawing.Size(140, 20);
            this.lblKategorijeDozvole.TabIndex = 8;
            this.lblKategorijeDozvole.Text = "Kategorije dozvole:";
            //
            // txtKategorijeDozvole
            //
            this.txtKategorijeDozvole.Location = new System.Drawing.Point(180, 157);
            this.txtKategorijeDozvole.Name = "txtKategorijeDozvole";
            this.txtKategorijeDozvole.Size = new System.Drawing.Size(280, 27);
            this.txtKategorijeDozvole.TabIndex = 9;
            //
            // lblDatumIzdavanjaDozvole
            //
            this.lblDatumIzdavanjaDozvole.AutoSize = true;
            this.lblDatumIzdavanjaDozvole.Location = new System.Drawing.Point(0, 200);
            this.lblDatumIzdavanjaDozvole.Name = "lblDatumIzdavanjaDozvole";
            this.lblDatumIzdavanjaDozvole.Size = new System.Drawing.Size(170, 20);
            this.lblDatumIzdavanjaDozvole.TabIndex = 10;
            this.lblDatumIzdavanjaDozvole.Text = "Datum izdavanja dozv.:";
            //
            // dtpDatumIzdavanjaDozvole
            //
            this.dtpDatumIzdavanjaDozvole.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumIzdavanjaDozvole.Location = new System.Drawing.Point(180, 197);
            this.dtpDatumIzdavanjaDozvole.Name = "dtpDatumIzdavanjaDozvole";
            this.dtpDatumIzdavanjaDozvole.Size = new System.Drawing.Size(280, 27);
            this.dtpDatumIzdavanjaDozvole.TabIndex = 11;
            //
            // lblDatumIstekaDozvole
            //
            this.lblDatumIstekaDozvole.AutoSize = true;
            this.lblDatumIstekaDozvole.Location = new System.Drawing.Point(0, 240);
            this.lblDatumIstekaDozvole.Name = "lblDatumIstekaDozvole";
            this.lblDatumIstekaDozvole.Size = new System.Drawing.Size(150, 20);
            this.lblDatumIstekaDozvole.TabIndex = 12;
            this.lblDatumIstekaDozvole.Text = "Datum isteka dozv.:";
            //
            // dtpDatumIstekaDozvole
            //
            this.dtpDatumIstekaDozvole.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumIstekaDozvole.Location = new System.Drawing.Point(180, 237);
            this.dtpDatumIstekaDozvole.Name = "dtpDatumIstekaDozvole";
            this.dtpDatumIstekaDozvole.Size = new System.Drawing.Size(280, 27);
            this.dtpDatumIstekaDozvole.TabIndex = 13;
            //
            // panelPravnoLice
            //
            this.panelPravnoLice.Location = new System.Drawing.Point(20, 260);
            this.panelPravnoLice.Name = "panelPravnoLice";
            this.panelPravnoLice.Size = new System.Drawing.Size(500, 300);
            this.panelPravnoLice.TabIndex = 13;
            this.panelPravnoLice.Controls.Add(this.lblNaziv);
            this.panelPravnoLice.Controls.Add(this.txtNaziv);
            this.panelPravnoLice.Controls.Add(this.lblPib);
            this.panelPravnoLice.Controls.Add(this.txtPib);
            this.panelPravnoLice.Controls.Add(this.lblMaticniBroj);
            this.panelPravnoLice.Controls.Add(this.txtMaticniBroj);
            this.panelPravnoLice.Controls.Add(this.lblSediste);
            this.panelPravnoLice.Controls.Add(this.txtSediste);
            this.panelPravnoLice.Controls.Add(this.lblKontaktOsoba);
            this.panelPravnoLice.Controls.Add(this.txtKontaktOsoba);
            this.panelPravnoLice.Controls.Add(this.lblUgovoreniUsloviKoriscenja);
            this.panelPravnoLice.Controls.Add(this.txtUgovoreniUsloviKoriscenja);
            //
            // lblNaziv
            //
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(0, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(52, 20);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            //
            // txtNaziv
            //
            this.txtNaziv.Location = new System.Drawing.Point(180, -3);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(280, 27);
            this.txtNaziv.TabIndex = 1;
            //
            // lblPib
            //
            this.lblPib.AutoSize = true;
            this.lblPib.Location = new System.Drawing.Point(0, 40);
            this.lblPib.Name = "lblPib";
            this.lblPib.Size = new System.Drawing.Size(38, 20);
            this.lblPib.TabIndex = 2;
            this.lblPib.Text = "PIB:";
            //
            // txtPib
            //
            this.txtPib.Location = new System.Drawing.Point(180, 37);
            this.txtPib.Name = "txtPib";
            this.txtPib.Size = new System.Drawing.Size(280, 27);
            this.txtPib.TabIndex = 3;
            //
            // lblMaticniBroj
            //
            this.lblMaticniBroj.AutoSize = true;
            this.lblMaticniBroj.Location = new System.Drawing.Point(0, 80);
            this.lblMaticniBroj.Name = "lblMaticniBroj";
            this.lblMaticniBroj.Size = new System.Drawing.Size(110, 20);
            this.lblMaticniBroj.TabIndex = 4;
            this.lblMaticniBroj.Text = "Matični broj:";
            //
            // txtMaticniBroj
            //
            this.txtMaticniBroj.Location = new System.Drawing.Point(180, 77);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(280, 27);
            this.txtMaticniBroj.TabIndex = 5;
            //
            // lblSediste
            //
            this.lblSediste.AutoSize = true;
            this.lblSediste.Location = new System.Drawing.Point(0, 120);
            this.lblSediste.Name = "lblSediste";
            this.lblSediste.Size = new System.Drawing.Size(62, 20);
            this.lblSediste.TabIndex = 6;
            this.lblSediste.Text = "Sedište:";
            //
            // txtSediste
            //
            this.txtSediste.Location = new System.Drawing.Point(180, 117);
            this.txtSediste.Name = "txtSediste";
            this.txtSediste.Size = new System.Drawing.Size(280, 27);
            this.txtSediste.TabIndex = 7;
            //
            // lblKontaktOsoba
            //
            this.lblKontaktOsoba.AutoSize = true;
            this.lblKontaktOsoba.Location = new System.Drawing.Point(0, 160);
            this.lblKontaktOsoba.Name = "lblKontaktOsoba";
            this.lblKontaktOsoba.Size = new System.Drawing.Size(120, 20);
            this.lblKontaktOsoba.TabIndex = 8;
            this.lblKontaktOsoba.Text = "Kontakt osoba:";
            //
            // txtKontaktOsoba
            //
            this.txtKontaktOsoba.Location = new System.Drawing.Point(180, 157);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.Size = new System.Drawing.Size(280, 27);
            this.txtKontaktOsoba.TabIndex = 9;
            //
            // lblUgovoreniUsloviKoriscenja
            //
            this.lblUgovoreniUsloviKoriscenja.AutoSize = true;
            this.lblUgovoreniUsloviKoriscenja.Location = new System.Drawing.Point(0, 200);
            this.lblUgovoreniUsloviKoriscenja.Name = "lblUgovoreniUsloviKoriscenja";
            this.lblUgovoreniUsloviKoriscenja.Size = new System.Drawing.Size(160, 20);
            this.lblUgovoreniUsloviKoriscenja.TabIndex = 10;
            this.lblUgovoreniUsloviKoriscenja.Text = "Ugovoreni uslovi:";
            //
            // txtUgovoreniUsloviKoriscenja
            //
            this.txtUgovoreniUsloviKoriscenja.Location = new System.Drawing.Point(180, 197);
            this.txtUgovoreniUsloviKoriscenja.Multiline = true;
            this.txtUgovoreniUsloviKoriscenja.Name = "txtUgovoreniUsloviKoriscenja";
            this.txtUgovoreniUsloviKoriscenja.Size = new System.Drawing.Size(280, 80);
            this.txtUgovoreniUsloviKoriscenja.TabIndex = 11;
            //
            // btnSacuvaj
            //
            this.btnSacuvaj.Location = new System.Drawing.Point(200, 580);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(130, 35);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            //
            // KorisnikCreateUpdateForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 640);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.panelPravnoLice);
            this.Controls.Add(this.panelFizickoLice);
            this.Controls.Add(this.txtNacinVerifikacije);
            this.Controls.Add(this.lblNacinVerifikacije);
            this.Controls.Add(this.txtStatusNaloga);
            this.Controls.Add(this.lblStatusNaloga);
            this.Controls.Add(this.dtpDatumRegistracije);
            this.Controls.Add(this.lblDatumRegistracije);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.cmbTipKorisnika);
            this.Controls.Add(this.lblTipKorisnika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KorisnikCreateUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.KorisnikCreateUpdateForm_Load);
            this.panelFizickoLice.ResumeLayout(false);
            this.panelFizickoLice.PerformLayout();
            this.panelPravnoLice.ResumeLayout(false);
            this.panelPravnoLice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}