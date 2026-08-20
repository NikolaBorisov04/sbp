namespace FluentNHibernateTemplate.Forms
{
    partial class NezgodaStetaCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbOdgovornost;
        private NumericUpDown numProcena;
        private GroupBox grpDetalji;
        private ListBox lstSlike;
        private TextBox txtNovaSlika;
        private Button btnDodajSliku;
        private Button btnObrisiSliku;
        private ListBox lstKuce;
        private TextBox txtNovaKuca;
        private Button btnDodajKucu;
        private Button btnObrisiKucu;
        private ListBox lstZapisnici;
        private TextBox txtNoviZapisnik;
        private Button btnDodajZapisnik;
        private Button btnObrisiZapisnik;
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
            cmbOdgovornost = new ComboBox();
            numProcena = new NumericUpDown();
            grpDetalji = new GroupBox();
            lstSlike = new ListBox();
            txtNovaSlika = new TextBox();
            btnDodajSliku = new Button();
            btnObrisiSliku = new Button();
            lstKuce = new ListBox();
            txtNovaKuca = new TextBox();
            btnDodajKucu = new Button();
            btnObrisiKucu = new Button();
            lstZapisnici = new ListBox();
            txtNoviZapisnik = new TextBox();
            btnDodajZapisnik = new Button();
            btnObrisiZapisnik = new Button();
            btnSacuvaj = new Button();

            Label l2 = new() { Text = "Tip odgovornosti:", Location = new Point(20, 20), AutoSize = true };
            Label l3 = new() { Text = "Procena štete (RSD):", Location = new Point(20, 60), AutoSize = true };

            cmbOdgovornost.Location = new Point(160, 17); cmbOdgovornost.Size = new Size(250, 27); cmbOdgovornost.DropDownStyle = ComboBoxStyle.DropDownList;
            numProcena.Location = new Point(160, 57); numProcena.Size = new Size(250, 27); numProcena.DecimalPlaces = 2; numProcena.Maximum = 10000000;

            // Details group
            grpDetalji.Location = new Point(20, 100);
            grpDetalji.Size = new Size(720, 310);
            grpDetalji.Text = "Prilozi i detalji štete (za izmene)";

            Label ls = new() { Text = "Fotografije (URL):", Location = new Point(15, 25), AutoSize = true };
            lstSlike.Location = new Point(15, 50); lstSlike.Size = new Size(215, 180);
            txtNovaSlika.Location = new Point(15, 235); txtNovaSlika.Size = new Size(215, 27);
            btnDodajSliku.Location = new Point(15, 268); btnDodajSliku.Size = new Size(100, 30); btnDodajSliku.Text = "Dodaj"; btnDodajSliku.Click += btnDodajSliku_Click;
            btnObrisiSliku.Location = new Point(130, 268); btnObrisiSliku.Size = new Size(100, 30); btnObrisiSliku.Text = "Obriši"; btnObrisiSliku.Click += btnObrisiSliku_Click;

            Label lk = new() { Text = "Osiguravajuće kuće:", Location = new Point(250, 25), AutoSize = true };
            lstKuce.Location = new Point(250, 50); lstKuce.Size = new Size(215, 180);
            txtNovaKuca.Location = new Point(250, 235); txtNovaKuca.Size = new Size(215, 27);
            btnDodajKucu.Location = new Point(250, 268); btnDodajKucu.Size = new Size(100, 30); btnDodajKucu.Text = "Dodaj"; btnDodajKucu.Click += btnDodajKucu_Click;
            btnObrisiKucu.Location = new Point(365, 268); btnObrisiKucu.Size = new Size(100, 30); btnObrisiKucu.Text = "Obriši"; btnObrisiKucu.Click += btnObrisiKucu_Click;

            Label lz = new() { Text = "Zapisnici (URL):", Location = new Point(485, 25), AutoSize = true };
            lstZapisnici.Location = new Point(485, 50); lstZapisnici.Size = new Size(215, 180);
            txtNoviZapisnik.Location = new Point(485, 235); txtNoviZapisnik.Size = new Size(215, 27);
            btnDodajZapisnik.Location = new Point(485, 268); btnDodajZapisnik.Size = new Size(100, 30); btnDodajZapisnik.Text = "Dodaj"; btnDodajZapisnik.Click += btnDodajZapisnik_Click;
            btnObrisiZapisnik.Location = new Point(600, 268); btnObrisiZapisnik.Size = new Size(100, 30); btnObrisiZapisnik.Text = "Obriši"; btnObrisiZapisnik.Click += btnObrisiZapisnik_Click;

            grpDetalji.Controls.AddRange(new Control[] {
                ls, lstSlike, txtNovaSlika, btnDodajSliku, btnObrisiSliku,
                lk, lstKuce, txtNovaKuca, btnDodajKucu, btnObrisiKucu,
                lz, lstZapisnici, txtNoviZapisnik, btnDodajZapisnik, btnObrisiZapisnik
            });

            btnSacuvaj.Location = new Point(300, 425);
            btnSacuvaj.Size = new Size(150, 35);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 475);
            Controls.AddRange(new Control[] {
                l2, cmbOdgovornost, l3, numProcena, grpDetalji, btnSacuvaj
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += NezgodaStetaCreateUpdateForm_Load;
        }
    }
}
