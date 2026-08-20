namespace FluentNHibernateTemplate.Forms
{
    partial class PunjenjeTocenjeCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dtpDatumVreme;
        private TextBox txtLokacija;
        private NumericUpDown numKolicina;
        private NumericUpDown numCena;
        private ComboBox cmbNacin;
        private TextBox txtEvidentirao;
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
            dtpDatumVreme = new DateTimePicker();
            txtLokacija = new TextBox();
            numKolicina = new NumericUpDown();
            numCena = new NumericUpDown();
            cmbNacin = new ComboBox();
            txtEvidentirao = new TextBox();
            btnSacuvaj = new Button();

            Label l2 = new() { Text = "Datum i vreme:", Location = new Point(20, 20), AutoSize = true };
            Label l3 = new() { Text = "Lokacija:", Location = new Point(20, 60), AutoSize = true };
            Label l4 = new() { Text = "Količina (L/kWh):", Location = new Point(20, 100), AutoSize = true };
            Label l5 = new() { Text = "Cena (RSD):", Location = new Point(20, 140), AutoSize = true };
            Label l6 = new() { Text = "Način evidencije:", Location = new Point(20, 180), AutoSize = true };
            Label l7 = new() { Text = "Evidentirao:", Location = new Point(20, 220), AutoSize = true };

            dtpDatumVreme.Location = new Point(160, 17); dtpDatumVreme.Size = new Size(250, 27); dtpDatumVreme.CustomFormat = "dd.MM.yyyy HH:mm"; dtpDatumVreme.Format = DateTimePickerFormat.Custom;
            txtLokacija.Location = new Point(160, 57); txtLokacija.Size = new Size(250, 27);
            numKolicina.Location = new Point(160, 97); numKolicina.Size = new Size(250, 27); numKolicina.DecimalPlaces = 2; numKolicina.Maximum = 10000;
            numCena.Location = new Point(160, 137); numCena.Size = new Size(250, 27); numCena.DecimalPlaces = 2; numCena.Maximum = 1000000;
            cmbNacin.Location = new Point(160, 177); cmbNacin.Size = new Size(250, 27); cmbNacin.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEvidentirao.Location = new Point(160, 217); txtEvidentirao.Size = new Size(250, 27);

            btnSacuvaj.Location = new Point(160, 265);
            btnSacuvaj.Size = new Size(130, 35);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 320);
            Controls.AddRange(new Control[] {
                l2, dtpDatumVreme, l3, txtLokacija, l4, numKolicina,
                l5, numCena, l6, cmbNacin, l7, txtEvidentirao, btnSacuvaj
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += PunjenjeTocenjeCreateUpdateForm_Load;
        }
    }
}
