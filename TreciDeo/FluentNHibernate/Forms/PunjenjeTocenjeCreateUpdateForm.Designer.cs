namespace FluentNHibernateTemplate.Forms
{
    partial class PunjenjeTocenjeCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDatumVreme;
        private System.Windows.Forms.DateTimePicker dtpDatumVreme;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.Label lblNacin;
        private System.Windows.Forms.ComboBox cmbNacin;
        private System.Windows.Forms.Label lblEvidentirao;
        private System.Windows.Forms.TextBox txtEvidentirao;
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
            this.lblDatumVreme = new System.Windows.Forms.Label();
            this.dtpDatumVreme = new System.Windows.Forms.DateTimePicker();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.lblNacin = new System.Windows.Forms.Label();
            this.cmbNacin = new System.Windows.Forms.ComboBox();
            this.lblEvidentirao = new System.Windows.Forms.Label();
            this.txtEvidentirao = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatumVreme
            // 
            this.lblDatumVreme.AutoSize = true;
            this.lblDatumVreme.Location = new System.Drawing.Point(20, 20);
            this.lblDatumVreme.Name = "lblDatumVreme";
            this.lblDatumVreme.Size = new System.Drawing.Size(110, 20);
            this.lblDatumVreme.TabIndex = 0;
            this.lblDatumVreme.Text = "Datum i vreme:";
            // 
            // dtpDatumVreme
            // 
            this.dtpDatumVreme.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatumVreme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumVreme.Location = new System.Drawing.Point(160, 17);
            this.dtpDatumVreme.Name = "dtpDatumVreme";
            this.dtpDatumVreme.Size = new System.Drawing.Size(250, 27);
            this.dtpDatumVreme.TabIndex = 1;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Location = new System.Drawing.Point(20, 60);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(65, 20);
            this.lblLokacija.TabIndex = 2;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(160, 57);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(250, 27);
            this.txtLokacija.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(20, 100);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(120, 20);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina (L/kWh):";
            // 
            // numKolicina
            // 
            this.numKolicina.DecimalPlaces = 2;
            this.numKolicina.Location = new System.Drawing.Point(160, 97);
            this.numKolicina.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(250, 27);
            this.numKolicina.TabIndex = 5;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(20, 140);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(84, 20);
            this.lblCena.TabIndex = 6;
            this.lblCena.Text = "Cena (RSD):";
            // 
            // numCena
            // 
            this.numCena.DecimalPlaces = 2;
            this.numCena.Location = new System.Drawing.Point(160, 137);
            this.numCena.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(250, 27);
            this.numCena.TabIndex = 7;
            // 
            // lblNacin
            // 
            this.lblNacin.AutoSize = true;
            this.lblNacin.Location = new System.Drawing.Point(20, 180);
            this.lblNacin.Name = "lblNacin";
            this.lblNacin.Size = new System.Drawing.Size(121, 20);
            this.lblNacin.TabIndex = 8;
            this.lblNacin.Text = "Način evidencije:";
            // 
            // cmbNacin
            // 
            this.cmbNacin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacin.Location = new System.Drawing.Point(160, 177);
            this.cmbNacin.Name = "cmbNacin";
            this.cmbNacin.Size = new System.Drawing.Size(250, 28);
            this.cmbNacin.TabIndex = 9;
            // 
            // lblEvidentirao
            // 
            this.lblEvidentirao.AutoSize = true;
            this.lblEvidentirao.Location = new System.Drawing.Point(20, 220);
            this.lblEvidentirao.Name = "lblEvidentirao";
            this.lblEvidentirao.Size = new System.Drawing.Size(87, 20);
            this.lblEvidentirao.TabIndex = 10;
            this.lblEvidentirao.Text = "Evidentirao:";
            // 
            // txtEvidentirao
            // 
            this.txtEvidentirao.Location = new System.Drawing.Point(160, 217);
            this.txtEvidentirao.Name = "txtEvidentirao";
            this.txtEvidentirao.Size = new System.Drawing.Size(250, 27);
            this.txtEvidentirao.TabIndex = 11;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(160, 265);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(130, 35);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // PunjenjeTocenjeCreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtEvidentirao);
            this.Controls.Add(this.lblEvidentirao);
            this.Controls.Add(this.cmbNacin);
            this.Controls.Add(this.lblNacin);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.dtpDatumVreme);
            this.Controls.Add(this.lblDatumVreme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PunjenjeTocenjeCreateUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PunjenjeTocenjeCreateUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
