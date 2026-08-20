namespace FluentNHibernateTemplate.Forms
{
    partial class VoziloCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtReg;
        private TextBox txtVin;
        private TextBox txtMarka;
        private TextBox txtModel;
        private NumericUpDown numGodina;
        private DateTimePicker dtpDatumNabavke;
        private ComboBox cmbStatus;
        private NumericUpDown numSedista;
        private TextBox txtEnterijer;
        private TextBox txtEksterijer;
        private TextBox txtOgranicenja;
        private ComboBox cmbPogon;
        private ComboBox cmbKoriscenje;
        private Panel pnlElektricno;
        private Panel pnlHibridno;
        private Panel pnlKlasicno;
        private NumericUpDown numKapacitetBaterije;
        private NumericUpDown numNivoNapunjenosti;
        private NumericUpDown numAutonomija;
        private TextBox txtTipPunjenja;
        private NumericUpDown numCiklusi;
        private TextBox txtTipHibridnogPogona;
        private TextBox txtTipGoriva;
        private NumericUpDown numZapreminaRezervoara;
        private NumericUpDown numProsecnaPotrosnja;
        private Button btnSacuvaj;

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
            txtReg = new TextBox();
            txtVin = new TextBox();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            numGodina = new NumericUpDown();
            dtpDatumNabavke = new DateTimePicker();
            cmbStatus = new ComboBox();
            numSedista = new NumericUpDown();
            txtEnterijer = new TextBox();
            txtEksterijer = new TextBox();
            txtOgranicenja = new TextBox();
            cmbPogon = new ComboBox();
            cmbKoriscenje = new ComboBox();
            pnlElektricno = new Panel();
            numKapacitetBaterije = new NumericUpDown();
            numNivoNapunjenosti = new NumericUpDown();
            numAutonomija = new NumericUpDown();
            txtTipPunjenja = new TextBox();
            numCiklusi = new NumericUpDown();
            pnlHibridno = new Panel();
            txtTipHibridnogPogona = new TextBox();
            pnlKlasicno = new Panel();
            txtTipGoriva = new TextBox();
            numZapreminaRezervoara = new NumericUpDown();
            numProsecnaPotrosnja = new NumericUpDown();
            btnSacuvaj = new Button();

            Label lblReg = new() { Text = "Registarska oznaka:", Location = new Point(20, 20), AutoSize = true };
            Label lblVin = new() { Text = "VIN (17 karaktera):", Location = new Point(20, 60), AutoSize = true };
            Label lblMarka = new() { Text = "Marka:", Location = new Point(20, 100), AutoSize = true };
            Label lblModel = new() { Text = "Model:", Location = new Point(20, 140), AutoSize = true };
            Label lblGodina = new() { Text = "Godina proizvodnje:", Location = new Point(20, 180), AutoSize = true };
            Label lblDatum = new() { Text = "Datum nabavke:", Location = new Point(20, 220), AutoSize = true };
            Label lblStatus = new() { Text = "Status:", Location = new Point(20, 260), AutoSize = true };
            Label lblSedista = new() { Text = "Broj sedišta:", Location = new Point(20, 300), AutoSize = true };
            Label lblPogon = new() { Text = "Tip pogona:", Location = new Point(20, 340), AutoSize = true };
            Label lblKoriscenje = new() { Text = "Tip korišćenja:", Location = new Point(20, 380), AutoSize = true };

            txtReg.Location = new Point(170, 17); txtReg.Size = new Size(200, 27);
            txtVin.Location = new Point(170, 57); txtVin.Size = new Size(200, 27);
            txtMarka.Location = new Point(170, 97); txtMarka.Size = new Size(200, 27);
            txtModel.Location = new Point(170, 137); txtModel.Size = new Size(200, 27);
            numGodina.Location = new Point(170, 177); numGodina.Size = new Size(200, 27); numGodina.Minimum = 1980; numGodina.Maximum = 2030; numGodina.Value = 2022;
            dtpDatumNabavke.Location = new Point(170, 217); dtpDatumNabavke.Size = new Size(200, 27); dtpDatumNabavke.Format = DateTimePickerFormat.Short;
            cmbStatus.Location = new Point(170, 257); cmbStatus.Size = new Size(200, 27); cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            numSedista.Location = new Point(170, 297); numSedista.Size = new Size(200, 27); numSedista.Minimum = 1; numSedista.Maximum = 60; numSedista.Value = 5;
            cmbPogon.Location = new Point(170, 337); cmbPogon.Size = new Size(200, 27); cmbPogon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPogon.SelectedIndexChanged += cmbPogon_SelectedIndexChanged;
            cmbKoriscenje.Location = new Point(170, 377); cmbKoriscenje.Size = new Size(200, 27); cmbKoriscenje.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblEnterijer = new() { Text = "Stanje enterijera:", Location = new Point(410, 20), AutoSize = true };
            txtEnterijer.Location = new Point(410, 45); txtEnterijer.Size = new Size(340, 50); txtEnterijer.Multiline = true;
            Label lblEksterijer = new() { Text = "Stanje eksterijera:", Location = new Point(410, 105), AutoSize = true };
            txtEksterijer.Location = new Point(410, 130); txtEksterijer.Size = new Size(340, 50); txtEksterijer.Multiline = true;
            Label lblOgranicenja = new() { Text = "Ograničenja korišćenja:", Location = new Point(410, 190), AutoSize = true };
            txtOgranicenja.Location = new Point(410, 215); txtOgranicenja.Size = new Size(340, 50); txtOgranicenja.Multiline = true;

            // Elektricno panel
            pnlElektricno.Location = new Point(410, 275);
            pnlElektricno.Size = new Size(350, 185);
            Label l1 = new() { Text = "Kapacitet bat. (kWh):", Location = new Point(5, 8), AutoSize = true };
            numKapacitetBaterije.Location = new Point(170, 5); numKapacitetBaterije.Size = new Size(160, 27); numKapacitetBaterije.DecimalPlaces = 2; numKapacitetBaterije.Maximum = 500;
            Label l2 = new() { Text = "Nivo napunjenosti %:", Location = new Point(5, 43), AutoSize = true };
            numNivoNapunjenosti.Location = new Point(170, 40); numNivoNapunjenosti.Size = new Size(160, 27); numNivoNapunjenosti.DecimalPlaces = 2; numNivoNapunjenosti.Maximum = 100;
            Label l3 = new() { Text = "Autonomija (km):", Location = new Point(5, 78), AutoSize = true };
            numAutonomija.Location = new Point(170, 75); numAutonomija.Size = new Size(160, 27); numAutonomija.Maximum = 2000;
            Label l4 = new() { Text = "Tip punjenja:", Location = new Point(5, 113), AutoSize = true };
            txtTipPunjenja.Location = new Point(170, 110); txtTipPunjenja.Size = new Size(160, 27);
            Label l5 = new() { Text = "Broj ciklusa:", Location = new Point(5, 148), AutoSize = true };
            numCiklusi.Location = new Point(170, 145); numCiklusi.Size = new Size(160, 27); numCiklusi.Maximum = 10000;
            pnlElektricno.Controls.AddRange(new Control[] { l1, numKapacitetBaterije, l2, numNivoNapunjenosti, l3, numAutonomija, l4, txtTipPunjenja, l5, numCiklusi });

            // Hibridno panel
            pnlHibridno.Location = new Point(410, 275);
            pnlHibridno.Size = new Size(350, 100);
            Label hl0 = new() { Text = "Kapacitet bat. (kWh):", Location = new Point(5, 8), AutoSize = true };
            NumericUpDown numKapacitetBaterijeHib = numKapacitetBaterije;
            Label hl1 = new() { Text = "Tip hibr. pogona:", Location = new Point(5, 43), AutoSize = true };
            txtTipHibridnogPogona.Location = new Point(170, 40); txtTipHibridnogPogona.Size = new Size(160, 27);
            pnlHibridno.Controls.AddRange(new Control[] { hl0, hl1, txtTipHibridnogPogona });

            // Klasicno panel
            pnlKlasicno.Location = new Point(410, 275);
            pnlKlasicno.Size = new Size(350, 120);
            Label kl1 = new() { Text = "Tip goriva:", Location = new Point(5, 8), AutoSize = true };
            txtTipGoriva.Location = new Point(170, 5); txtTipGoriva.Size = new Size(160, 27);
            Label kl2 = new() { Text = "Rezervoar (L):", Location = new Point(5, 43), AutoSize = true };
            numZapreminaRezervoara.Location = new Point(170, 40); numZapreminaRezervoara.Size = new Size(160, 27); numZapreminaRezervoara.DecimalPlaces = 2; numZapreminaRezervoara.Maximum = 300;
            Label kl3 = new() { Text = "Potrošnja (L/100km):", Location = new Point(5, 78), AutoSize = true };
            numProsecnaPotrosnja.Location = new Point(170, 75); numProsecnaPotrosnja.Size = new Size(160, 27); numProsecnaPotrosnja.DecimalPlaces = 2; numProsecnaPotrosnja.Maximum = 50;
            pnlKlasicno.Controls.AddRange(new Control[] { kl1, txtTipGoriva, kl2, numZapreminaRezervoara, kl3, numProsecnaPotrosnja });

            btnSacuvaj.Location = new Point(310, 470);
            btnSacuvaj.Size = new Size(160, 35);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 520);
            Controls.AddRange(new Control[] {
                lblReg, txtReg, lblVin, txtVin, lblMarka, txtMarka, lblModel, txtModel,
                lblGodina, numGodina, lblDatum, dtpDatumNabavke, lblStatus, cmbStatus,
                lblSedista, numSedista, lblPogon, cmbPogon, lblKoriscenje, cmbKoriscenje,
                lblEnterijer, txtEnterijer, lblEksterijer, txtEksterijer,
                lblOgranicenja, txtOgranicenja, pnlElektricno, pnlHibridno, pnlKlasicno, btnSacuvaj
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += VoziloCreateUpdateForm_Load;
        }
    }
}
