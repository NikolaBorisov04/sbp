namespace FluentNHibernateTemplate.Forms
{
    partial class VoziloCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.NumericUpDown numGodina;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatumNabavke;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblSedista;
        private System.Windows.Forms.NumericUpDown numSedista;
        private System.Windows.Forms.Label lblPogon;
        private System.Windows.Forms.ComboBox cmbPogon;
        private System.Windows.Forms.Label lblKoriscenje;
        private System.Windows.Forms.ComboBox cmbKoriscenje;
        private System.Windows.Forms.Label lblEnterijer;
        private System.Windows.Forms.TextBox txtEnterijer;
        private System.Windows.Forms.Label lblEksterijer;
        private System.Windows.Forms.TextBox txtEksterijer;
        private System.Windows.Forms.Label lblOgranicenja;
        private System.Windows.Forms.TextBox txtOgranicenja;
        private System.Windows.Forms.Panel pnlElektricno;
        private System.Windows.Forms.Label lblKapacitetBatEl;
        private System.Windows.Forms.NumericUpDown numKapacitetBaterije;
        private System.Windows.Forms.Label lblNivoNapunjenosti;
        private System.Windows.Forms.NumericUpDown numNivoNapunjenosti;
        private System.Windows.Forms.Label lblAutonomija;
        private System.Windows.Forms.NumericUpDown numAutonomija;
        private System.Windows.Forms.Label lblTipPunjenja;
        private System.Windows.Forms.TextBox txtTipPunjenja;
        private System.Windows.Forms.Label lblBrojCiklusa;
        private System.Windows.Forms.NumericUpDown numCiklusi;
        private System.Windows.Forms.Panel pnlHibridno;
        private System.Windows.Forms.Label lblKapacitetBatHib;
        private System.Windows.Forms.NumericUpDown numKapacitetBaterijeHib;
        private System.Windows.Forms.Label lblTipHibridnogPogona;
        private System.Windows.Forms.TextBox txtTipHibridnogPogona;
        private System.Windows.Forms.Panel pnlKlasicno;
        private System.Windows.Forms.Label lblTipGoriva;
        private System.Windows.Forms.TextBox txtTipGoriva;
        private System.Windows.Forms.Label lblZapreminaRezervoara;
        private System.Windows.Forms.NumericUpDown numZapreminaRezervoara;
        private System.Windows.Forms.Label lblProsecnaPotrosnja;
        private System.Windows.Forms.NumericUpDown numProsecnaPotrosnja;
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
            lblReg = new Label();
            txtReg = new TextBox();
            lblVin = new Label();
            txtVin = new TextBox();
            lblMarka = new Label();
            txtMarka = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblGodina = new Label();
            numGodina = new NumericUpDown();
            lblDatum = new Label();
            dtpDatumNabavke = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblSedista = new Label();
            numSedista = new NumericUpDown();
            lblPogon = new Label();
            cmbPogon = new ComboBox();
            lblKoriscenje = new Label();
            cmbKoriscenje = new ComboBox();
            lblEnterijer = new Label();
            txtEnterijer = new TextBox();
            lblEksterijer = new Label();
            txtEksterijer = new TextBox();
            lblOgranicenja = new Label();
            txtOgranicenja = new TextBox();
            pnlElektricno = new Panel();
            lblKapacitetBatEl = new Label();
            numKapacitetBaterije = new NumericUpDown();
            lblNivoNapunjenosti = new Label();
            numNivoNapunjenosti = new NumericUpDown();
            lblAutonomija = new Label();
            numAutonomija = new NumericUpDown();
            lblTipPunjenja = new Label();
            txtTipPunjenja = new TextBox();
            lblBrojCiklusa = new Label();
            numCiklusi = new NumericUpDown();
            pnlHibridno = new Panel();
            lblKapacitetBatHib = new Label();
            numKapacitetBaterijeHib = new NumericUpDown();
            lblTipHibridnogPogona = new Label();
            txtTipHibridnogPogona = new TextBox();
            pnlKlasicno = new Panel();
            lblTipGoriva = new Label();
            txtTipGoriva = new TextBox();
            lblZapreminaRezervoara = new Label();
            numZapreminaRezervoara = new NumericUpDown();
            lblProsecnaPotrosnja = new Label();
            numProsecnaPotrosnja = new NumericUpDown();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)numGodina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSedista).BeginInit();
            pnlElektricno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKapacitetBaterije).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNivoNapunjenosti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAutonomija).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCiklusi).BeginInit();
            pnlHibridno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKapacitetBaterijeHib).BeginInit();
            pnlKlasicno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numZapreminaRezervoara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProsecnaPotrosnja).BeginInit();
            SuspendLayout();
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Location = new Point(20, 20);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(138, 20);
            lblReg.TabIndex = 0;
            lblReg.Text = "Registarska oznaka:";
            // 
            // txtReg
            // 
            txtReg.Location = new Point(170, 17);
            txtReg.Name = "txtReg";
            txtReg.Size = new Size(200, 27);
            txtReg.TabIndex = 1;
            // 
            // lblVin
            // 
            lblVin.AutoSize = true;
            lblVin.Location = new Point(20, 60);
            lblVin.Name = "lblVin";
            lblVin.Size = new Size(131, 20);
            lblVin.TabIndex = 2;
            lblVin.Text = "VIN (17 karaktera):";
            // 
            // txtVin
            // 
            txtVin.Location = new Point(170, 57);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(200, 27);
            txtVin.TabIndex = 3;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(20, 100);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(53, 20);
            lblMarka.TabIndex = 4;
            lblMarka.Text = "Marka:";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(170, 97);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(200, 27);
            txtMarka.TabIndex = 5;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(20, 140);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(55, 20);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(170, 137);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 27);
            txtModel.TabIndex = 7;
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(20, 180);
            lblGodina.Name = "lblGodina";
            lblGodina.Size = new Size(143, 20);
            lblGodina.TabIndex = 8;
            lblGodina.Text = "Godina proizvodnje:";
            // 
            // numGodina
            // 
            numGodina.Location = new Point(170, 177);
            numGodina.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numGodina.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numGodina.Name = "numGodina";
            numGodina.Size = new Size(200, 27);
            numGodina.TabIndex = 9;
            numGodina.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(20, 220);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(116, 20);
            lblDatum.TabIndex = 10;
            lblDatum.Text = "Datum nabavke:";
            // 
            // dtpDatumNabavke
            // 
            dtpDatumNabavke.Format = DateTimePickerFormat.Short;
            dtpDatumNabavke.Location = new Point(170, 217);
            dtpDatumNabavke.Name = "dtpDatumNabavke";
            dtpDatumNabavke.Size = new Size(200, 27);
            dtpDatumNabavke.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 260);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(170, 257);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 28);
            cmbStatus.TabIndex = 13;
            // 
            // lblSedista
            // 
            lblSedista.AutoSize = true;
            lblSedista.Location = new Point(20, 300);
            lblSedista.Name = "lblSedista";
            lblSedista.Size = new Size(89, 20);
            lblSedista.TabIndex = 14;
            lblSedista.Text = "Broj sedišta:";
            // 
            // numSedista
            // 
            numSedista.Location = new Point(170, 297);
            numSedista.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numSedista.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSedista.Name = "numSedista";
            numSedista.Size = new Size(200, 27);
            numSedista.TabIndex = 15;
            numSedista.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblPogon
            // 
            lblPogon.AutoSize = true;
            lblPogon.Location = new Point(20, 340);
            lblPogon.Name = "lblPogon";
            lblPogon.Size = new Size(89, 20);
            lblPogon.TabIndex = 16;
            lblPogon.Text = "Tip pogona:";
            // 
            // cmbPogon
            // 
            cmbPogon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPogon.Location = new Point(170, 337);
            cmbPogon.Name = "cmbPogon";
            cmbPogon.Size = new Size(200, 28);
            cmbPogon.TabIndex = 17;
            cmbPogon.SelectedIndexChanged += cmbPogon_SelectedIndexChanged;
            // 
            // lblKoriscenje
            // 
            lblKoriscenje.AutoSize = true;
            lblKoriscenje.Location = new Point(20, 380);
            lblKoriscenje.Name = "lblKoriscenje";
            lblKoriscenje.Size = new Size(103, 20);
            lblKoriscenje.TabIndex = 18;
            lblKoriscenje.Text = "Tip korišćenja:";
            // 
            // cmbKoriscenje
            // 
            cmbKoriscenje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKoriscenje.Location = new Point(170, 377);
            cmbKoriscenje.Name = "cmbKoriscenje";
            cmbKoriscenje.Size = new Size(200, 28);
            cmbKoriscenje.TabIndex = 19;
            // 
            // lblEnterijer
            // 
            lblEnterijer.AutoSize = true;
            lblEnterijer.Location = new Point(410, 20);
            lblEnterijer.Name = "lblEnterijer";
            lblEnterijer.Size = new Size(120, 20);
            lblEnterijer.TabIndex = 20;
            lblEnterijer.Text = "Stanje enterijera:";
            // 
            // txtEnterijer
            // 
            txtEnterijer.Location = new Point(410, 45);
            txtEnterijer.Multiline = true;
            txtEnterijer.Name = "txtEnterijer";
            txtEnterijer.Size = new Size(340, 50);
            txtEnterijer.TabIndex = 21;
            // 
            // lblEksterijer
            // 
            lblEksterijer.AutoSize = true;
            lblEksterijer.Location = new Point(410, 105);
            lblEksterijer.Name = "lblEksterijer";
            lblEksterijer.Size = new Size(125, 20);
            lblEksterijer.TabIndex = 22;
            lblEksterijer.Text = "Stanje eksterijera:";
            // 
            // txtEksterijer
            // 
            txtEksterijer.Location = new Point(410, 130);
            txtEksterijer.Multiline = true;
            txtEksterijer.Name = "txtEksterijer";
            txtEksterijer.Size = new Size(340, 50);
            txtEksterijer.TabIndex = 23;
            // 
            // lblOgranicenja
            // 
            lblOgranicenja.AutoSize = true;
            lblOgranicenja.Location = new Point(410, 190);
            lblOgranicenja.Name = "lblOgranicenja";
            lblOgranicenja.Size = new Size(162, 20);
            lblOgranicenja.TabIndex = 24;
            lblOgranicenja.Text = "Ograničenja korišćenja:";
            // 
            // txtOgranicenja
            // 
            txtOgranicenja.Location = new Point(410, 215);
            txtOgranicenja.Multiline = true;
            txtOgranicenja.Name = "txtOgranicenja";
            txtOgranicenja.Size = new Size(340, 50);
            txtOgranicenja.TabIndex = 25;
            // 
            // pnlElektricno
            // 
            pnlElektricno.Controls.Add(lblKapacitetBatEl);
            pnlElektricno.Controls.Add(numKapacitetBaterije);
            pnlElektricno.Controls.Add(lblNivoNapunjenosti);
            pnlElektricno.Controls.Add(numNivoNapunjenosti);
            pnlElektricno.Controls.Add(lblAutonomija);
            pnlElektricno.Controls.Add(numAutonomija);
            pnlElektricno.Controls.Add(lblTipPunjenja);
            pnlElektricno.Controls.Add(txtTipPunjenja);
            pnlElektricno.Controls.Add(lblBrojCiklusa);
            pnlElektricno.Controls.Add(numCiklusi);
            pnlElektricno.Location = new Point(410, 275);
            pnlElektricno.Name = "pnlElektricno";
            pnlElektricno.Size = new Size(350, 185);
            pnlElektricno.TabIndex = 26;
            // 
            // lblKapacitetBatEl
            // 
            lblKapacitetBatEl.AutoSize = true;
            lblKapacitetBatEl.Location = new Point(5, 8);
            lblKapacitetBatEl.Name = "lblKapacitetBatEl";
            lblKapacitetBatEl.Size = new Size(147, 20);
            lblKapacitetBatEl.TabIndex = 0;
            lblKapacitetBatEl.Text = "Kapacitet bat. (kWh):";
            // 
            // numKapacitetBaterije
            // 
            numKapacitetBaterije.DecimalPlaces = 2;
            numKapacitetBaterije.Location = new Point(170, 5);
            numKapacitetBaterije.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numKapacitetBaterije.Name = "numKapacitetBaterije";
            numKapacitetBaterije.Size = new Size(160, 27);
            numKapacitetBaterije.TabIndex = 1;
            // 
            // lblNivoNapunjenosti
            // 
            lblNivoNapunjenosti.AutoSize = true;
            lblNivoNapunjenosti.Location = new Point(5, 43);
            lblNivoNapunjenosti.Name = "lblNivoNapunjenosti";
            lblNivoNapunjenosti.Size = new Size(148, 20);
            lblNivoNapunjenosti.TabIndex = 2;
            lblNivoNapunjenosti.Text = "Nivo napunjenosti %:";
            // 
            // numNivoNapunjenosti
            // 
            numNivoNapunjenosti.DecimalPlaces = 2;
            numNivoNapunjenosti.Location = new Point(170, 40);
            numNivoNapunjenosti.Name = "numNivoNapunjenosti";
            numNivoNapunjenosti.Size = new Size(160, 27);
            numNivoNapunjenosti.TabIndex = 3;
            // 
            // lblAutonomija
            // 
            lblAutonomija.AutoSize = true;
            lblAutonomija.Location = new Point(5, 78);
            lblAutonomija.Name = "lblAutonomija";
            lblAutonomija.Size = new Size(124, 20);
            lblAutonomija.TabIndex = 4;
            lblAutonomija.Text = "Autonomija (km):";
            // 
            // numAutonomija
            // 
            numAutonomija.Location = new Point(170, 75);
            numAutonomija.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numAutonomija.Name = "numAutonomija";
            numAutonomija.Size = new Size(160, 27);
            numAutonomija.TabIndex = 5;
            // 
            // lblTipPunjenja
            // 
            lblTipPunjenja.AutoSize = true;
            lblTipPunjenja.Location = new Point(5, 121);
            lblTipPunjenja.Name = "lblTipPunjenja";
            lblTipPunjenja.Size = new Size(94, 20);
            lblTipPunjenja.TabIndex = 6;
            lblTipPunjenja.Text = "Tip punjenja:";
            // 
            // txtTipPunjenja
            // 
            txtTipPunjenja.Location = new Point(170, 118);
            txtTipPunjenja.Name = "txtTipPunjenja";
            txtTipPunjenja.Size = new Size(160, 27);
            txtTipPunjenja.TabIndex = 7;
            // 
            // lblBrojCiklusa
            // 
            lblBrojCiklusa.AutoSize = true;
            lblBrojCiklusa.Location = new Point(5, 156);
            lblBrojCiklusa.Name = "lblBrojCiklusa";
            lblBrojCiklusa.Size = new Size(87, 20);
            lblBrojCiklusa.TabIndex = 8;
            lblBrojCiklusa.Text = "Broj ciklusa:";
            // 
            // numCiklusi
            // 
            numCiklusi.Location = new Point(170, 153);
            numCiklusi.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCiklusi.Name = "numCiklusi";
            numCiklusi.Size = new Size(160, 27);
            numCiklusi.TabIndex = 9;
            // 
            // pnlHibridno
            // 
            pnlHibridno.Controls.Add(lblKapacitetBatHib);
            pnlHibridno.Controls.Add(numKapacitetBaterijeHib);
            pnlHibridno.Controls.Add(lblTipHibridnogPogona);
            pnlHibridno.Controls.Add(txtTipHibridnogPogona);
            pnlHibridno.Location = new Point(410, 275);
            pnlHibridno.Name = "pnlHibridno";
            pnlHibridno.Size = new Size(350, 100);
            pnlHibridno.TabIndex = 27;
            // 
            // lblKapacitetBatHib
            // 
            lblKapacitetBatHib.AutoSize = true;
            lblKapacitetBatHib.Location = new Point(5, 8);
            lblKapacitetBatHib.Name = "lblKapacitetBatHib";
            lblKapacitetBatHib.Size = new Size(147, 20);
            lblKapacitetBatHib.TabIndex = 0;
            lblKapacitetBatHib.Text = "Kapacitet bat. (kWh):";
            // 
            // numKapacitetBaterijeHib
            // 
            numKapacitetBaterijeHib.DecimalPlaces = 2;
            numKapacitetBaterijeHib.Location = new Point(170, 5);
            numKapacitetBaterijeHib.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numKapacitetBaterijeHib.Name = "numKapacitetBaterijeHib";
            numKapacitetBaterijeHib.Size = new Size(160, 27);
            numKapacitetBaterijeHib.TabIndex = 1;
            // 
            // lblTipHibridnogPogona
            // 
            lblTipHibridnogPogona.AutoSize = true;
            lblTipHibridnogPogona.Location = new Point(5, 43);
            lblTipHibridnogPogona.Name = "lblTipHibridnogPogona";
            lblTipHibridnogPogona.Size = new Size(122, 20);
            lblTipHibridnogPogona.TabIndex = 2;
            lblTipHibridnogPogona.Text = "Tip hibr. pogona:";
            // 
            // txtTipHibridnogPogona
            // 
            txtTipHibridnogPogona.Location = new Point(170, 40);
            txtTipHibridnogPogona.Name = "txtTipHibridnogPogona";
            txtTipHibridnogPogona.Size = new Size(160, 27);
            txtTipHibridnogPogona.TabIndex = 3;
            // 
            // pnlKlasicno
            // 
            pnlKlasicno.Controls.Add(lblTipGoriva);
            pnlKlasicno.Controls.Add(txtTipGoriva);
            pnlKlasicno.Controls.Add(lblZapreminaRezervoara);
            pnlKlasicno.Controls.Add(numZapreminaRezervoara);
            pnlKlasicno.Controls.Add(lblProsecnaPotrosnja);
            pnlKlasicno.Controls.Add(numProsecnaPotrosnja);
            pnlKlasicno.Location = new Point(410, 275);
            pnlKlasicno.Name = "pnlKlasicno";
            pnlKlasicno.Size = new Size(350, 112);
            pnlKlasicno.TabIndex = 28;
            // 
            // lblTipGoriva
            // 
            lblTipGoriva.AutoSize = true;
            lblTipGoriva.Location = new Point(5, 8);
            lblTipGoriva.Name = "lblTipGoriva";
            lblTipGoriva.Size = new Size(79, 20);
            lblTipGoriva.TabIndex = 0;
            lblTipGoriva.Text = "Tip goriva:";
            // 
            // txtTipGoriva
            // 
            txtTipGoriva.Location = new Point(170, 5);
            txtTipGoriva.Name = "txtTipGoriva";
            txtTipGoriva.Size = new Size(160, 27);
            txtTipGoriva.TabIndex = 1;
            // 
            // lblZapreminaRezervoara
            // 
            lblZapreminaRezervoara.AutoSize = true;
            lblZapreminaRezervoara.Location = new Point(5, 43);
            lblZapreminaRezervoara.Name = "lblZapreminaRezervoara";
            lblZapreminaRezervoara.Size = new Size(99, 20);
            lblZapreminaRezervoara.TabIndex = 2;
            lblZapreminaRezervoara.Text = "Rezervoar (L):";
            // 
            // numZapreminaRezervoara
            // 
            numZapreminaRezervoara.DecimalPlaces = 2;
            numZapreminaRezervoara.Location = new Point(170, 40);
            numZapreminaRezervoara.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numZapreminaRezervoara.Name = "numZapreminaRezervoara";
            numZapreminaRezervoara.Size = new Size(160, 27);
            numZapreminaRezervoara.TabIndex = 3;
            // 
            // lblProsecnaPotrosnja
            // 
            lblProsecnaPotrosnja.AutoSize = true;
            lblProsecnaPotrosnja.Location = new Point(5, 78);
            lblProsecnaPotrosnja.Name = "lblProsecnaPotrosnja";
            lblProsecnaPotrosnja.Size = new Size(144, 20);
            lblProsecnaPotrosnja.TabIndex = 4;
            lblProsecnaPotrosnja.Text = "Potrošnja (L/100km):";
            // 
            // numProsecnaPotrosnja
            // 
            numProsecnaPotrosnja.DecimalPlaces = 2;
            numProsecnaPotrosnja.Location = new Point(170, 75);
            numProsecnaPotrosnja.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numProsecnaPotrosnja.Name = "numProsecnaPotrosnja";
            numProsecnaPotrosnja.Size = new Size(160, 27);
            numProsecnaPotrosnja.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(310, 470);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(160, 35);
            btnSacuvaj.TabIndex = 29;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // VoziloCreateUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 520);
            Controls.Add(btnSacuvaj);
            Controls.Add(pnlKlasicno);
            Controls.Add(pnlHibridno);
            Controls.Add(pnlElektricno);
            Controls.Add(txtOgranicenja);
            Controls.Add(lblOgranicenja);
            Controls.Add(txtEksterijer);
            Controls.Add(lblEksterijer);
            Controls.Add(txtEnterijer);
            Controls.Add(lblEnterijer);
            Controls.Add(cmbKoriscenje);
            Controls.Add(lblKoriscenje);
            Controls.Add(cmbPogon);
            Controls.Add(lblPogon);
            Controls.Add(numSedista);
            Controls.Add(lblSedista);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpDatumNabavke);
            Controls.Add(lblDatum);
            Controls.Add(numGodina);
            Controls.Add(lblGodina);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtMarka);
            Controls.Add(lblMarka);
            Controls.Add(txtVin);
            Controls.Add(lblVin);
            Controls.Add(txtReg);
            Controls.Add(lblReg);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "VoziloCreateUpdateForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += VoziloCreateUpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)numGodina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSedista).EndInit();
            pnlElektricno.ResumeLayout(false);
            pnlElektricno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKapacitetBaterije).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNivoNapunjenosti).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAutonomija).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCiklusi).EndInit();
            pnlHibridno.ResumeLayout(false);
            pnlHibridno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKapacitetBaterijeHib).EndInit();
            pnlKlasicno.ResumeLayout(false);
            pnlKlasicno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numZapreminaRezervoara).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProsecnaPotrosnja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
