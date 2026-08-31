namespace FluentNHibernateTemplate.Forms
{
    partial class NezgodaStetaCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOdgovornost;
        private System.Windows.Forms.ComboBox cmbOdgovornost;
        private System.Windows.Forms.Label lblProcena;
        private System.Windows.Forms.NumericUpDown numProcena;
        private System.Windows.Forms.GroupBox grpDetalji;
        private System.Windows.Forms.Label lblFotografije;
        private System.Windows.Forms.ListBox lstSlike;
        private System.Windows.Forms.TextBox txtNovaSlika;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnObrisiSliku;
        private System.Windows.Forms.Label lblOsiguravajuceKuce;
        private System.Windows.Forms.ListBox lstKuce;
        private System.Windows.Forms.TextBox txtNovaKuca;
        private System.Windows.Forms.Button btnDodajKucu;
        private System.Windows.Forms.Button btnObrisiKucu;
        private System.Windows.Forms.Label lblZapisnici;
        private System.Windows.Forms.ListBox lstZapisnici;
        private System.Windows.Forms.TextBox txtNoviZapisnik;
        private System.Windows.Forms.Button btnDodajZapisnik;
        private System.Windows.Forms.Button btnObrisiZapisnik;
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
            this.lblOdgovornost = new System.Windows.Forms.Label();
            this.cmbOdgovornost = new System.Windows.Forms.ComboBox();
            this.lblProcena = new System.Windows.Forms.Label();
            this.numProcena = new System.Windows.Forms.NumericUpDown();
            this.grpDetalji = new System.Windows.Forms.GroupBox();
            this.lblFotografije = new System.Windows.Forms.Label();
            this.lstSlike = new System.Windows.Forms.ListBox();
            this.txtNovaSlika = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnObrisiSliku = new System.Windows.Forms.Button();
            this.lblOsiguravajuceKuce = new System.Windows.Forms.Label();
            this.lstKuce = new System.Windows.Forms.ListBox();
            this.txtNovaKuca = new System.Windows.Forms.TextBox();
            this.btnDodajKucu = new System.Windows.Forms.Button();
            this.btnObrisiKucu = new System.Windows.Forms.Button();
            this.lblZapisnici = new System.Windows.Forms.Label();
            this.lstZapisnici = new System.Windows.Forms.ListBox();
            this.txtNoviZapisnik = new System.Windows.Forms.TextBox();
            this.btnDodajZapisnik = new System.Windows.Forms.Button();
            this.btnObrisiZapisnik = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numProcena)).BeginInit();
            this.grpDetalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdgovornost
            // 
            this.lblOdgovornost.AutoSize = true;
            this.lblOdgovornost.Location = new System.Drawing.Point(20, 20);
            this.lblOdgovornost.Name = "lblOdgovornost";
            this.lblOdgovornost.Size = new System.Drawing.Size(127, 20);
            this.lblOdgovornost.TabIndex = 0;
            this.lblOdgovornost.Text = "Tip odgovornosti:";
            // 
            // cmbOdgovornost
            // 
            this.cmbOdgovornost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdgovornost.Location = new System.Drawing.Point(160, 17);
            this.cmbOdgovornost.Name = "cmbOdgovornost";
            this.cmbOdgovornost.Size = new System.Drawing.Size(250, 28);
            this.cmbOdgovornost.TabIndex = 1;
            // 
            // lblProcena
            // 
            this.lblProcena.AutoSize = true;
            this.lblProcena.Location = new System.Drawing.Point(20, 60);
            this.lblProcena.Name = "lblProcena";
            this.lblProcena.Size = new System.Drawing.Size(139, 20);
            this.lblProcena.TabIndex = 2;
            this.lblProcena.Text = "Procena štete (RSD):";
            // 
            // numProcena
            // 
            this.numProcena.DecimalPlaces = 2;
            this.numProcena.Location = new System.Drawing.Point(160, 57);
            this.numProcena.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numProcena.Name = "numProcena";
            this.numProcena.Size = new System.Drawing.Size(250, 27);
            this.numProcena.TabIndex = 3;
            // 
            // grpDetalji
            // 
            this.grpDetalji.Controls.Add(this.btnObrisiZapisnik);
            this.grpDetalji.Controls.Add(this.btnDodajZapisnik);
            this.grpDetalji.Controls.Add(this.txtNoviZapisnik);
            this.grpDetalji.Controls.Add(this.lstZapisnici);
            this.grpDetalji.Controls.Add(this.lblZapisnici);
            this.grpDetalji.Controls.Add(this.btnObrisiKucu);
            this.grpDetalji.Controls.Add(this.btnDodajKucu);
            this.grpDetalji.Controls.Add(this.txtNovaKuca);
            this.grpDetalji.Controls.Add(this.lstKuce);
            this.grpDetalji.Controls.Add(this.lblOsiguravajuceKuce);
            this.grpDetalji.Controls.Add(this.btnObrisiSliku);
            this.grpDetalji.Controls.Add(this.btnDodajSliku);
            this.grpDetalji.Controls.Add(this.txtNovaSlika);
            this.grpDetalji.Controls.Add(this.lstSlike);
            this.grpDetalji.Controls.Add(this.lblFotografije);
            this.grpDetalji.Location = new System.Drawing.Point(20, 100);
            this.grpDetalji.Name = "grpDetalji";
            this.grpDetalji.Size = new System.Drawing.Size(720, 310);
            this.grpDetalji.TabIndex = 4;
            this.grpDetalji.TabStop = false;
            this.grpDetalji.Text = "Prilozi i detalji štete (za izmene)";
            // 
            // lblFotografije
            // 
            this.lblFotografije.AutoSize = true;
            this.lblFotografije.Location = new System.Drawing.Point(15, 25);
            this.lblFotografije.Name = "lblFotografije";
            this.lblFotografije.Size = new System.Drawing.Size(126, 20);
            this.lblFotografije.TabIndex = 0;
            this.lblFotografije.Text = "Fotografije (URL):";
            // 
            // lstSlike
            // 
            this.lstSlike.ItemHeight = 20;
            this.lstSlike.Location = new System.Drawing.Point(15, 50);
            this.lstSlike.Name = "lstSlike";
            this.lstSlike.Size = new System.Drawing.Size(215, 184);
            this.lstSlike.TabIndex = 1;
            // 
            // txtNovaSlika
            // 
            this.txtNovaSlika.Location = new System.Drawing.Point(15, 235);
            this.txtNovaSlika.Name = "txtNovaSlika";
            this.txtNovaSlika.Size = new System.Drawing.Size(215, 27);
            this.txtNovaSlika.TabIndex = 2;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(15, 268);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(100, 30);
            this.btnDodajSliku.TabIndex = 3;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // btnObrisiSliku
            // 
            this.btnObrisiSliku.Location = new System.Drawing.Point(130, 268);
            this.btnObrisiSliku.Name = "btnObrisiSliku";
            this.btnObrisiSliku.Size = new System.Drawing.Size(100, 30);
            this.btnObrisiSliku.TabIndex = 4;
            this.btnObrisiSliku.Text = "Obriši";
            this.btnObrisiSliku.UseVisualStyleBackColor = true;
            this.btnObrisiSliku.Click += new System.EventHandler(this.btnObrisiSliku_Click);
            // 
            // lblOsiguravajuceKuce
            // 
            this.lblOsiguravajuceKuce.AutoSize = true;
            this.lblOsiguravajuceKuce.Location = new System.Drawing.Point(250, 25);
            this.lblOsiguravajuceKuce.Name = "lblOsiguravajuceKuce";
            this.lblOsiguravajuceKuce.Size = new System.Drawing.Size(139, 20);
            this.lblOsiguravajuceKuce.TabIndex = 5;
            this.lblOsiguravajuceKuce.Text = "Osiguravajuće kuće:";
            // 
            // lstKuce
            // 
            this.lstKuce.ItemHeight = 20;
            this.lstKuce.Location = new System.Drawing.Point(250, 50);
            this.lstKuce.Name = "lstKuce";
            this.lstKuce.Size = new System.Drawing.Size(215, 184);
            this.lstKuce.TabIndex = 6;
            // 
            // txtNovaKuca
            // 
            this.txtNovaKuca.Location = new System.Drawing.Point(250, 235);
            this.txtNovaKuca.Name = "txtNovaKuca";
            this.txtNovaKuca.Size = new System.Drawing.Size(215, 27);
            this.txtNovaKuca.TabIndex = 7;
            // 
            // btnDodajKucu
            // 
            this.btnDodajKucu.Location = new System.Drawing.Point(250, 268);
            this.btnDodajKucu.Name = "btnDodajKucu";
            this.btnDodajKucu.Size = new System.Drawing.Size(100, 30);
            this.btnDodajKucu.TabIndex = 8;
            this.btnDodajKucu.Text = "Dodaj";
            this.btnDodajKucu.UseVisualStyleBackColor = true;
            this.btnDodajKucu.Click += new System.EventHandler(this.btnDodajKucu_Click);
            // 
            // btnObrisiKucu
            // 
            this.btnObrisiKucu.Location = new System.Drawing.Point(365, 268);
            this.btnObrisiKucu.Name = "btnObrisiKucu";
            this.btnObrisiKucu.Size = new System.Drawing.Size(100, 30);
            this.btnObrisiKucu.TabIndex = 9;
            this.btnObrisiKucu.Text = "Obriši";
            this.btnObrisiKucu.UseVisualStyleBackColor = true;
            this.btnObrisiKucu.Click += new System.EventHandler(this.btnObrisiKucu_Click);
            // 
            // lblZapisnici
            // 
            this.lblZapisnici.AutoSize = true;
            this.lblZapisnici.Location = new System.Drawing.Point(485, 25);
            this.lblZapisnici.Name = "lblZapisnici";
            this.lblZapisnici.Size = new System.Drawing.Size(110, 20);
            this.lblZapisnici.TabIndex = 10;
            this.lblZapisnici.Text = "Zapisnici (URL):";
            // 
            // lstZapisnici
            // 
            this.lstZapisnici.ItemHeight = 20;
            this.lstZapisnici.Location = new System.Drawing.Point(485, 50);
            this.lstZapisnici.Name = "lstZapisnici";
            this.lstZapisnici.Size = new System.Drawing.Size(215, 184);
            this.lstZapisnici.TabIndex = 11;
            // 
            // txtNoviZapisnik
            // 
            this.txtNoviZapisnik.Location = new System.Drawing.Point(485, 235);
            this.txtNoviZapisnik.Name = "txtNoviZapisnik";
            this.txtNoviZapisnik.Size = new System.Drawing.Size(215, 27);
            this.txtNoviZapisnik.TabIndex = 12;
            // 
            // btnDodajZapisnik
            // 
            this.btnDodajZapisnik.Location = new System.Drawing.Point(485, 268);
            this.btnDodajZapisnik.Name = "btnDodajZapisnik";
            this.btnDodajZapisnik.Size = new System.Drawing.Size(100, 30);
            this.btnDodajZapisnik.TabIndex = 13;
            this.btnDodajZapisnik.Text = "Dodaj";
            this.btnDodajZapisnik.UseVisualStyleBackColor = true;
            this.btnDodajZapisnik.Click += new System.EventHandler(this.btnDodajZapisnik_Click);
            // 
            // btnObrisiZapisnik
            // 
            this.btnObrisiZapisnik.Location = new System.Drawing.Point(600, 268);
            this.btnObrisiZapisnik.Name = "btnObrisiZapisnik";
            this.btnObrisiZapisnik.Size = new System.Drawing.Size(100, 30);
            this.btnObrisiZapisnik.TabIndex = 14;
            this.btnObrisiZapisnik.Text = "Obriši";
            this.btnObrisiZapisnik.UseVisualStyleBackColor = true;
            this.btnObrisiZapisnik.Click += new System.EventHandler(this.btnObrisiZapisnik_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(300, 425);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(150, 35);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // NezgodaStetaCreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 475);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.grpDetalji);
            this.Controls.Add(this.numProcena);
            this.Controls.Add(this.lblProcena);
            this.Controls.Add(this.cmbOdgovornost);
            this.Controls.Add(this.lblOdgovornost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NezgodaStetaCreateUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.NezgodaStetaCreateUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numProcena)).EndInit();
            this.grpDetalji.ResumeLayout(false);
            this.grpDetalji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
