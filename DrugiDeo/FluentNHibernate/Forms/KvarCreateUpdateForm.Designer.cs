namespace FluentNHibernateTemplate.Forms
{
    partial class KvarCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbPrijavio;
        private DateTimePicker dtpDatumPrijave;
        private TextBox txtOpis;
        private ComboBox cmbOzbiljnost;
        private ComboBox cmbStatus;
        private CheckBox chkOtklonjen;
        private DateTimePicker dtpDatumOtklanjanja;
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
            cmbPrijavio = new ComboBox();
            dtpDatumPrijave = new DateTimePicker();
            txtOpis = new TextBox();
            cmbOzbiljnost = new ComboBox();
            cmbStatus = new ComboBox();
            chkOtklonjen = new CheckBox();
            dtpDatumOtklanjanja = new DateTimePicker();
            btnSacuvaj = new Button();

            Label l2 = new() { Text = "Prijavio:", Location = new Point(20, 20), AutoSize = true };
            Label l3 = new() { Text = "Datum prijave:", Location = new Point(20, 60), AutoSize = true };
            Label l4 = new() { Text = "Ozbiljnost:", Location = new Point(20, 100), AutoSize = true };
            Label l5 = new() { Text = "Status:", Location = new Point(20, 140), AutoSize = true };
            Label l6 = new() { Text = "Otklonjen:", Location = new Point(20, 180), AutoSize = true };
            Label l7 = new() { Text = "Opis problema:", Location = new Point(20, 220), AutoSize = true };

            cmbPrijavio.Location = new Point(160, 17); cmbPrijavio.Size = new Size(250, 27); cmbPrijavio.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpDatumPrijave.Location = new Point(160, 57); dtpDatumPrijave.Size = new Size(250, 27); dtpDatumPrijave.Format = DateTimePickerFormat.Short;
            cmbOzbiljnost.Location = new Point(160, 97); cmbOzbiljnost.Size = new Size(250, 27); cmbOzbiljnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(160, 137); cmbStatus.Size = new Size(250, 27); cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            chkOtklonjen.Text = "Otklonjen"; chkOtklonjen.Location = new Point(160, 177); chkOtklonjen.Size = new Size(90, 27); chkOtklonjen.CheckedChanged += chkOtklonjen_CheckedChanged;
            dtpDatumOtklanjanja.Location = new Point(255, 177); dtpDatumOtklanjanja.Size = new Size(155, 27); dtpDatumOtklanjanja.Format = DateTimePickerFormat.Short; dtpDatumOtklanjanja.Enabled = false;

            txtOpis.Location = new Point(160, 217); txtOpis.Size = new Size(250, 100); txtOpis.Multiline = true;

            btnSacuvaj.Location = new Point(160, 340);
            btnSacuvaj.Size = new Size(130, 35);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 395);
            Controls.AddRange(new Control[] {
                l2, cmbPrijavio, l3, dtpDatumPrijave, l4, cmbOzbiljnost,
                l5, cmbStatus, l6, chkOtklonjen, dtpDatumOtklanjanja, l7, txtOpis, btnSacuvaj
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += KvarCreateUpdateForm_Load;
        }
    }
}
