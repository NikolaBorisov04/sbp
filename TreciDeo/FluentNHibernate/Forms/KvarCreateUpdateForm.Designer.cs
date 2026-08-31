namespace FluentNHibernateTemplate.Forms
{
    partial class KvarCreateUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPrijavio;
        private System.Windows.Forms.ComboBox cmbPrijavio;
        private System.Windows.Forms.Label lblDatumPrijave;
        private System.Windows.Forms.DateTimePicker dtpDatumPrijave;
        private System.Windows.Forms.Label lblOzbiljnost;
        private System.Windows.Forms.ComboBox cmbOzbiljnost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblOtklonjen;
        private System.Windows.Forms.CheckBox chkOtklonjen;
        private System.Windows.Forms.DateTimePicker dtpDatumOtklanjanja;
        private System.Windows.Forms.Label lblOpisProblema;
        private System.Windows.Forms.TextBox txtOpis;
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
            this.lblPrijavio = new System.Windows.Forms.Label();
            this.cmbPrijavio = new System.Windows.Forms.ComboBox();
            this.lblDatumPrijave = new System.Windows.Forms.Label();
            this.dtpDatumPrijave = new System.Windows.Forms.DateTimePicker();
            this.lblOzbiljnost = new System.Windows.Forms.Label();
            this.cmbOzbiljnost = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblOtklonjen = new System.Windows.Forms.Label();
            this.chkOtklonjen = new System.Windows.Forms.CheckBox();
            this.dtpDatumOtklanjanja = new System.Windows.Forms.DateTimePicker();
            this.lblOpisProblema = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrijavio
            // 
            this.lblPrijavio.AutoSize = true;
            this.lblPrijavio.Location = new System.Drawing.Point(20, 20);
            this.lblPrijavio.Name = "lblPrijavio";
            this.lblPrijavio.Size = new System.Drawing.Size(61, 20);
            this.lblPrijavio.TabIndex = 0;
            this.lblPrijavio.Text = "Prijavio:";
            // 
            // cmbPrijavio
            // 
            this.cmbPrijavio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrijavio.Location = new System.Drawing.Point(160, 17);
            this.cmbPrijavio.Name = "cmbPrijavio";
            this.cmbPrijavio.Size = new System.Drawing.Size(250, 28);
            this.cmbPrijavio.TabIndex = 1;
            // 
            // lblDatumPrijave
            // 
            this.lblDatumPrijave.AutoSize = true;
            this.lblDatumPrijave.Location = new System.Drawing.Point(20, 60);
            this.lblDatumPrijave.Name = "lblDatumPrijave";
            this.lblDatumPrijave.Size = new System.Drawing.Size(107, 20);
            this.lblDatumPrijave.TabIndex = 2;
            this.lblDatumPrijave.Text = "Datum prijave:";
            // 
            // dtpDatumPrijave
            // 
            this.dtpDatumPrijave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPrijave.Location = new System.Drawing.Point(160, 57);
            this.dtpDatumPrijave.Name = "dtpDatumPrijave";
            this.dtpDatumPrijave.Size = new System.Drawing.Size(250, 27);
            this.dtpDatumPrijave.TabIndex = 3;
            // 
            // lblOzbiljnost
            // 
            this.lblOzbiljnost.AutoSize = true;
            this.lblOzbiljnost.Location = new System.Drawing.Point(20, 100);
            this.lblOzbiljnost.Name = "lblOzbiljnost";
            this.lblOzbiljnost.Size = new System.Drawing.Size(78, 20);
            this.lblOzbiljnost.TabIndex = 4;
            this.lblOzbiljnost.Text = "Ozbiljnost:";
            // 
            // cmbOzbiljnost
            // 
            this.cmbOzbiljnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOzbiljnost.Location = new System.Drawing.Point(160, 97);
            this.cmbOzbiljnost.Name = "cmbOzbiljnost";
            this.cmbOzbiljnost.Size = new System.Drawing.Size(250, 28);
            this.cmbOzbiljnost.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(160, 137);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(250, 28);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblOtklonjen
            // 
            this.lblOtklonjen.AutoSize = true;
            this.lblOtklonjen.Location = new System.Drawing.Point(20, 180);
            this.lblOtklonjen.Name = "lblOtklonjen";
            this.lblOtklonjen.Size = new System.Drawing.Size(77, 20);
            this.lblOtklonjen.TabIndex = 8;
            this.lblOtklonjen.Text = "Otklonjen:";
            // 
            // chkOtklonjen
            // 
            this.chkOtklonjen.Location = new System.Drawing.Point(160, 177);
            this.chkOtklonjen.Name = "chkOtklonjen";
            this.chkOtklonjen.Size = new System.Drawing.Size(90, 27);
            this.chkOtklonjen.TabIndex = 9;
            this.chkOtklonjen.Text = "Otklonjen";
            this.chkOtklonjen.CheckedChanged += new System.EventHandler(this.chkOtklonjen_CheckedChanged);
            // 
            // dtpDatumOtklanjanja
            // 
            this.dtpDatumOtklanjanja.Enabled = false;
            this.dtpDatumOtklanjanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumOtklanjanja.Location = new System.Drawing.Point(255, 177);
            this.dtpDatumOtklanjanja.Name = "dtpDatumOtklanjanja";
            this.dtpDatumOtklanjanja.Size = new System.Drawing.Size(155, 27);
            this.dtpDatumOtklanjanja.TabIndex = 10;
            // 
            // lblOpisProblema
            // 
            this.lblOpisProblema.AutoSize = true;
            this.lblOpisProblema.Location = new System.Drawing.Point(20, 220);
            this.lblOpisProblema.Name = "lblOpisProblema";
            this.lblOpisProblema.Size = new System.Drawing.Size(110, 20);
            this.lblOpisProblema.TabIndex = 11;
            this.lblOpisProblema.Text = "Opis problema:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(160, 217);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(250, 100);
            this.txtOpis.TabIndex = 12;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(160, 340);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(130, 35);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // KvarCreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 395);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpisProblema);
            this.Controls.Add(this.dtpDatumOtklanjanja);
            this.Controls.Add(this.chkOtklonjen);
            this.Controls.Add(this.lblOtklonjen);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbOzbiljnost);
            this.Controls.Add(this.lblOzbiljnost);
            this.Controls.Add(this.dtpDatumPrijave);
            this.Controls.Add(this.lblDatumPrijave);
            this.Controls.Add(this.cmbPrijavio);
            this.Controls.Add(this.lblPrijavio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KvarCreateUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.KvarCreateUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
