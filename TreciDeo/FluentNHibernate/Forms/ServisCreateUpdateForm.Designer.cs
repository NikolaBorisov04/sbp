namespace FluentNHibernateTemplate.Forms
{
    partial class ServisCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTipServisa;
        private System.Windows.Forms.ComboBox cmbTipServisa;
        private System.Windows.Forms.Label lblServisniCentar;
        private System.Windows.Forms.TextBox txtServisniCentar;
        private System.Windows.Forms.Label lblDatumPrijema;
        private System.Windows.Forms.DateTimePicker dtpDatumPrijema;
        private System.Windows.Forms.Label lblDatumZavrsetka;
        private System.Windows.Forms.CheckBox chkZavrsen;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.Label lblTroskovi;
        private System.Windows.Forms.NumericUpDown numTroskovi;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblOpisRadova;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblZamenjeniDelovi;
        private System.Windows.Forms.TextBox txtDelovi;
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
            this.lblTipServisa = new System.Windows.Forms.Label();
            this.cmbTipServisa = new System.Windows.Forms.ComboBox();
            this.lblServisniCentar = new System.Windows.Forms.Label();
            this.txtServisniCentar = new System.Windows.Forms.TextBox();
            this.lblDatumPrijema = new System.Windows.Forms.Label();
            this.dtpDatumPrijema = new System.Windows.Forms.DateTimePicker();
            this.lblDatumZavrsetka = new System.Windows.Forms.Label();
            this.chkZavrsen = new System.Windows.Forms.CheckBox();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.lblTroskovi = new System.Windows.Forms.Label();
            this.numTroskovi = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblOpisRadova = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblZamenjeniDelovi = new System.Windows.Forms.Label();
            this.txtDelovi = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTroskovi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipServisa
            // 
            this.lblTipServisa.AutoSize = true;
            this.lblTipServisa.Location = new System.Drawing.Point(20, 20);
            this.lblTipServisa.Name = "lblTipServisa";
            this.lblTipServisa.Size = new System.Drawing.Size(83, 20);
            this.lblTipServisa.TabIndex = 0;
            this.lblTipServisa.Text = "Tip servisa:";
            // 
            // cmbTipServisa
            // 
            this.cmbTipServisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipServisa.Location = new System.Drawing.Point(160, 17);
            this.cmbTipServisa.Name = "cmbTipServisa";
            this.cmbTipServisa.Size = new System.Drawing.Size(250, 28);
            this.cmbTipServisa.TabIndex = 1;
            // 
            // lblServisniCentar
            // 
            this.lblServisniCentar.AutoSize = true;
            this.lblServisniCentar.Location = new System.Drawing.Point(20, 60);
            this.lblServisniCentar.Name = "lblServisniCentar";
            this.lblServisniCentar.Size = new System.Drawing.Size(107, 20);
            this.lblServisniCentar.TabIndex = 2;
            this.lblServisniCentar.Text = "Servisni centar:";
            // 
            // txtServisniCentar
            // 
            this.txtServisniCentar.Location = new System.Drawing.Point(160, 57);
            this.txtServisniCentar.Name = "txtServisniCentar";
            this.txtServisniCentar.Size = new System.Drawing.Size(250, 27);
            this.txtServisniCentar.TabIndex = 3;
            // 
            // lblDatumPrijema
            // 
            this.lblDatumPrijema.AutoSize = true;
            this.lblDatumPrijema.Location = new System.Drawing.Point(20, 100);
            this.lblDatumPrijema.Name = "lblDatumPrijema";
            this.lblDatumPrijema.Size = new System.Drawing.Size(110, 20);
            this.lblDatumPrijema.TabIndex = 4;
            this.lblDatumPrijema.Text = "Datum prijema:";
            // 
            // dtpDatumPrijema
            // 
            this.dtpDatumPrijema.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPrijema.Location = new System.Drawing.Point(160, 97);
            this.dtpDatumPrijema.Name = "dtpDatumPrijema";
            this.dtpDatumPrijema.Size = new System.Drawing.Size(250, 27);
            this.dtpDatumPrijema.TabIndex = 5;
            // 
            // lblDatumZavrsetka
            // 
            this.lblDatumZavrsetka.AutoSize = true;
            this.lblDatumZavrsetka.Location = new System.Drawing.Point(20, 140);
            this.lblDatumZavrsetka.Name = "lblDatumZavrsetka";
            this.lblDatumZavrsetka.Size = new System.Drawing.Size(121, 20);
            this.lblDatumZavrsetka.TabIndex = 6;
            this.lblDatumZavrsetka.Text = "Datum završetka:";
            // 
            // chkZavrsen
            // 
            this.chkZavrsen.Location = new System.Drawing.Point(160, 137);
            this.chkZavrsen.Name = "chkZavrsen";
            this.chkZavrsen.Size = new System.Drawing.Size(80, 27);
            this.chkZavrsen.TabIndex = 7;
            this.chkZavrsen.Text = "Završen";
            this.chkZavrsen.CheckedChanged += new System.EventHandler(this.chkZavrsen_CheckedChanged);
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Enabled = false;
            this.dtpDatumZavrsetka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(250, 137);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(160, 27);
            this.dtpDatumZavrsetka.TabIndex = 8;
            // 
            // lblTroskovi
            // 
            this.lblTroskovi.AutoSize = true;
            this.lblTroskovi.Location = new System.Drawing.Point(20, 180);
            this.lblTroskovi.Name = "lblTroskovi";
            this.lblTroskovi.Size = new System.Drawing.Size(107, 20);
            this.lblTroskovi.TabIndex = 9;
            this.lblTroskovi.Text = "Troškovi (RSD):";
            // 
            // numTroskovi
            // 
            this.numTroskovi.DecimalPlaces = 2;
            this.numTroskovi.Location = new System.Drawing.Point(160, 177);
            this.numTroskovi.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numTroskovi.Name = "numTroskovi";
            this.numTroskovi.Size = new System.Drawing.Size(250, 27);
            this.numTroskovi.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 220);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(160, 217);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(250, 28);
            this.cmbStatus.TabIndex = 12;
            // 
            // lblOpisRadova
            // 
            this.lblOpisRadova.AutoSize = true;
            this.lblOpisRadova.Location = new System.Drawing.Point(20, 260);
            this.lblOpisRadova.Name = "lblOpisRadova";
            this.lblOpisRadova.Size = new System.Drawing.Size(92, 20);
            this.lblOpisRadova.TabIndex = 13;
            this.lblOpisRadova.Text = "Opis radova:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(160, 257);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(250, 65);
            this.txtOpis.TabIndex = 14;
            // 
            // lblZamenjeniDelovi
            // 
            this.lblZamenjeniDelovi.AutoSize = true;
            this.lblZamenjeniDelovi.Location = new System.Drawing.Point(20, 340);
            this.lblZamenjeniDelovi.Name = "lblZamenjeniDelovi";
            this.lblZamenjeniDelovi.Size = new System.Drawing.Size(126, 20);
            this.lblZamenjeniDelovi.TabIndex = 15;
            this.lblZamenjeniDelovi.Text = "Zamenjeni delovi:";
            // 
            // txtDelovi
            // 
            this.txtDelovi.Location = new System.Drawing.Point(160, 337);
            this.txtDelovi.Multiline = true;
            this.txtDelovi.Name = "txtDelovi";
            this.txtDelovi.Size = new System.Drawing.Size(250, 50);
            this.txtDelovi.TabIndex = 16;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(160, 410);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(130, 35);
            this.btnSacuvaj.TabIndex = 17;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // ServisCreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 465);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtDelovi);
            this.Controls.Add(this.lblZamenjeniDelovi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpisRadova);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numTroskovi);
            this.Controls.Add(this.lblTroskovi);
            this.Controls.Add(this.dtpDatumZavrsetka);
            this.Controls.Add(this.chkZavrsen);
            this.Controls.Add(this.lblDatumZavrsetka);
            this.Controls.Add(this.dtpDatumPrijema);
            this.Controls.Add(this.lblDatumPrijema);
            this.Controls.Add(this.txtServisniCentar);
            this.Controls.Add(this.lblServisniCentar);
            this.Controls.Add(this.cmbTipServisa);
            this.Controls.Add(this.lblTipServisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ServisCreateUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ServisCreateUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTroskovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
