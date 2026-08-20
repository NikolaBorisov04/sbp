namespace FluentNHibernateTemplate.Forms
{
    partial class ServisCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbVozilo;
        private ComboBox cmbTipServisa;
        private TextBox txtServisniCentar;
        private DateTimePicker dtpDatumPrijema;
        private CheckBox chkZavrsen;
        private DateTimePicker dtpDatumZavrsetka;
        private TextBox txtOpis;
        private TextBox txtDelovi;
        private NumericUpDown numTroskovi;
        private ComboBox cmbStatus;
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
            cmbVozilo = new ComboBox();
            cmbTipServisa = new ComboBox();
            txtServisniCentar = new TextBox();
            dtpDatumPrijema = new DateTimePicker();
            chkZavrsen = new CheckBox();
            dtpDatumZavrsetka = new DateTimePicker();
            txtOpis = new TextBox();
            txtDelovi = new TextBox();
            numTroskovi = new NumericUpDown();
            cmbStatus = new ComboBox();
            btnSacuvaj = new Button();

            Label l1 = new() { Text = "Vozilo:", Location = new Point(20, 20), AutoSize = true };
            Label l2 = new() { Text = "Tip servisa:", Location = new Point(20, 60), AutoSize = true };
            Label l3 = new() { Text = "Servisni centar:", Location = new Point(20, 100), AutoSize = true };
            Label l4 = new() { Text = "Datum prijema:", Location = new Point(20, 140), AutoSize = true };
            Label l5 = new() { Text = "Datum završetka:", Location = new Point(20, 180), AutoSize = true };
            Label l6 = new() { Text = "Troškovi (RSD):", Location = new Point(20, 220), AutoSize = true };
            Label l7 = new() { Text = "Status:", Location = new Point(20, 260), AutoSize = true };
            Label l8 = new() { Text = "Opis radova:", Location = new Point(20, 300), AutoSize = true };
            Label l9 = new() { Text = "Zamenjeni delovi:", Location = new Point(20, 380), AutoSize = true };

            cmbVozilo.Location = new Point(160, 17); cmbVozilo.Size = new Size(250, 27); cmbVozilo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipServisa.Location = new Point(160, 57); cmbTipServisa.Size = new Size(250, 27); cmbTipServisa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtServisniCentar.Location = new Point(160, 97); txtServisniCentar.Size = new Size(250, 27);
            dtpDatumPrijema.Location = new Point(160, 137); dtpDatumPrijema.Size = new Size(250, 27); dtpDatumPrijema.Format = DateTimePickerFormat.Short;

            chkZavrsen.Text = "Završen"; chkZavrsen.Location = new Point(160, 177); chkZavrsen.Size = new Size(80, 27); chkZavrsen.CheckedChanged += chkZavrsen_CheckedChanged;
            dtpDatumZavrsetka.Location = new Point(250, 177); dtpDatumZavrsetka.Size = new Size(160, 27); dtpDatumZavrsetka.Format = DateTimePickerFormat.Short; dtpDatumZavrsetka.Enabled = false;

            numTroskovi.Location = new Point(160, 217); numTroskovi.Size = new Size(250, 27); numTroskovi.DecimalPlaces = 2; numTroskovi.Maximum = 10000000;
            cmbStatus.Location = new Point(160, 257); cmbStatus.Size = new Size(250, 27); cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            txtOpis.Location = new Point(160, 297); txtOpis.Size = new Size(250, 65); txtOpis.Multiline = true;
            txtDelovi.Location = new Point(160, 377); txtDelovi.Size = new Size(250, 50); txtDelovi.Multiline = true;

            btnSacuvaj.Location = new Point(160, 445);
            btnSacuvaj.Size = new Size(130, 35);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 500);
            Controls.AddRange(new Control[] {
                l1, cmbVozilo, l2, cmbTipServisa, l3, txtServisniCentar, l4, dtpDatumPrijema,
                l5, chkZavrsen, dtpDatumZavrsetka, l6, numTroskovi, l7, cmbStatus,
                l8, txtOpis, l9, txtDelovi, btnSacuvaj
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += ServisCreateUpdateForm_Load;
        }
    }
}
