namespace FluentNHibernateTemplate.Forms
{
    partial class KorisnikDodatniPodaciForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpTelefoni;
        private System.Windows.Forms.ListView listViewTelefoni;
        private System.Windows.Forms.ColumnHeader colTelId;
        private System.Windows.Forms.ColumnHeader colTelBroj;
        private System.Windows.Forms.TextBox txtNoviTelefon;
        private System.Windows.Forms.Button btnDodajTelefon;
        private System.Windows.Forms.Button btnObrisiTelefon;

        private System.Windows.Forms.GroupBox grpVerifikacije;
        private System.Windows.Forms.ListView listViewVerifikacije;
        private System.Windows.Forms.ColumnHeader colVerId;
        private System.Windows.Forms.ColumnHeader colVerDatum;
        private System.Windows.Forms.ColumnHeader colVerVerifikator;
        private System.Windows.Forms.ColumnHeader colVerRezultat;
        private System.Windows.Forms.ColumnHeader colVerOgranicenja;
        private System.Windows.Forms.DateTimePicker dtpDatumVerifikacije;
        private System.Windows.Forms.TextBox txtVerifikator;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.TextBox txtOgranicenjaVerifikacije;
        private System.Windows.Forms.Button btnDodajVerifikaciju;
        private System.Windows.Forms.Button btnObrisiVerifikaciju;

        private System.Windows.Forms.GroupBox grpNaciniPlacanja;
        private System.Windows.Forms.ListView listViewNaciniPlacanja;
        private System.Windows.Forms.ColumnHeader colPlId;
        private System.Windows.Forms.ColumnHeader colPlTip;
        private System.Windows.Forms.ColumnHeader colPlStatus;
        private System.Windows.Forms.ColumnHeader colPlDatum;
        private System.Windows.Forms.ColumnHeader colPlOgranicenja;
        private System.Windows.Forms.TextBox txtTipPlacanja;
        private System.Windows.Forms.TextBox txtStatusPlacanja;
        private System.Windows.Forms.DateTimePicker dtpDatumDodavanjaPlacanja;
        private System.Windows.Forms.TextBox txtOgranicenjaPlacanja;
        private System.Windows.Forms.Button btnDodajNacinPlacanja;
        private System.Windows.Forms.Button btnObrisiNacinPlacanja;

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
            grpTelefoni = new GroupBox();
            listViewTelefoni = new ListView();
            colTelId = new ColumnHeader();
            colTelBroj = new ColumnHeader();
            txtNoviTelefon = new TextBox();
            btnDodajTelefon = new Button();
            btnObrisiTelefon = new Button();

            grpVerifikacije = new GroupBox();
            listViewVerifikacije = new ListView();
            colVerId = new ColumnHeader();
            colVerDatum = new ColumnHeader();
            colVerVerifikator = new ColumnHeader();
            colVerRezultat = new ColumnHeader();
            colVerOgranicenja = new ColumnHeader();
            dtpDatumVerifikacije = new DateTimePicker();
            txtVerifikator = new TextBox();
            txtRezultat = new TextBox();
            txtOgranicenjaVerifikacije = new TextBox();
            btnDodajVerifikaciju = new Button();
            btnObrisiVerifikaciju = new Button();

            grpNaciniPlacanja = new GroupBox();
            listViewNaciniPlacanja = new ListView();
            colPlId = new ColumnHeader();
            colPlTip = new ColumnHeader();
            colPlStatus = new ColumnHeader();
            colPlDatum = new ColumnHeader();
            colPlOgranicenja = new ColumnHeader();
            txtTipPlacanja = new TextBox();
            txtStatusPlacanja = new TextBox();
            dtpDatumDodavanjaPlacanja = new DateTimePicker();
            txtOgranicenjaPlacanja = new TextBox();
            btnDodajNacinPlacanja = new Button();
            btnObrisiNacinPlacanja = new Button();

            grpTelefoni.SuspendLayout();
            grpVerifikacije.SuspendLayout();
            grpNaciniPlacanja.SuspendLayout();
            SuspendLayout();

            //
            // grpTelefoni
            //
            grpTelefoni.Controls.Add(listViewTelefoni);
            grpTelefoni.Controls.Add(txtNoviTelefon);
            grpTelefoni.Controls.Add(btnDodajTelefon);
            grpTelefoni.Controls.Add(btnObrisiTelefon);
            grpTelefoni.Location = new Point(12, 12);
            grpTelefoni.Name = "grpTelefoni";
            grpTelefoni.Size = new Size(720, 160);
            grpTelefoni.TabIndex = 0;
            grpTelefoni.TabStop = false;
            grpTelefoni.Text = "Telefoni";
            //
            // listViewTelefoni
            //
            listViewTelefoni.Columns.AddRange(new ColumnHeader[] { colTelId, colTelBroj });
            listViewTelefoni.FullRowSelect = true;
            listViewTelefoni.GridLines = true;
            listViewTelefoni.Location = new Point(15, 25);
            listViewTelefoni.MultiSelect = false;
            listViewTelefoni.Name = "listViewTelefoni";
            listViewTelefoni.Size = new Size(400, 120);
            listViewTelefoni.TabIndex = 0;
            listViewTelefoni.UseCompatibleStateImageBehavior = false;
            listViewTelefoni.View = View.Details;
            //
            // colTelId
            //
            colTelId.Text = "ID";
            colTelId.Width = 40;
            //
            // colTelBroj
            //
            colTelBroj.Text = "Broj telefona";
            colTelBroj.Width = 340;
            //
            // txtNoviTelefon
            //
            txtNoviTelefon.Location = new Point(430, 25);
            txtNoviTelefon.Name = "txtNoviTelefon";
            txtNoviTelefon.Size = new Size(270, 27);
            txtNoviTelefon.TabIndex = 1;
            //
            // btnDodajTelefon
            //
            btnDodajTelefon.Location = new Point(430, 60);
            btnDodajTelefon.Name = "btnDodajTelefon";
            btnDodajTelefon.Size = new Size(130, 32);
            btnDodajTelefon.TabIndex = 2;
            btnDodajTelefon.Text = "Dodaj telefon";
            btnDodajTelefon.UseVisualStyleBackColor = true;
            btnDodajTelefon.Click += btnDodajTelefon_Click;
            //
            // btnObrisiTelefon
            //
            btnObrisiTelefon.Location = new Point(570, 60);
            btnObrisiTelefon.Name = "btnObrisiTelefon";
            btnObrisiTelefon.Size = new Size(130, 32);
            btnObrisiTelefon.TabIndex = 3;
            btnObrisiTelefon.Text = "Obriši izabrani";
            btnObrisiTelefon.UseVisualStyleBackColor = true;
            btnObrisiTelefon.Click += btnObrisiTelefon_Click;

            //
            // grpVerifikacije
            //
            grpVerifikacije.Controls.Add(listViewVerifikacije);
            grpVerifikacije.Controls.Add(dtpDatumVerifikacije);
            grpVerifikacije.Controls.Add(txtVerifikator);
            grpVerifikacije.Controls.Add(txtRezultat);
            grpVerifikacije.Controls.Add(txtOgranicenjaVerifikacije);
            grpVerifikacije.Controls.Add(btnDodajVerifikaciju);
            grpVerifikacije.Controls.Add(btnObrisiVerifikaciju);
            grpVerifikacije.Location = new Point(12, 185);
            grpVerifikacije.Name = "grpVerifikacije";
            grpVerifikacije.Size = new Size(720, 220);
            grpVerifikacije.TabIndex = 1;
            grpVerifikacije.TabStop = false;
            grpVerifikacije.Text = "Verifikacije";
            //
            // listViewVerifikacije
            //
            listViewVerifikacije.Columns.AddRange(new ColumnHeader[] { colVerId, colVerDatum, colVerVerifikator, colVerRezultat, colVerOgranicenja });
            listViewVerifikacije.FullRowSelect = true;
            listViewVerifikacije.GridLines = true;
            listViewVerifikacije.Location = new Point(15, 25);
            listViewVerifikacije.MultiSelect = false;
            listViewVerifikacije.Name = "listViewVerifikacije";
            listViewVerifikacije.Size = new Size(690, 100);
            listViewVerifikacije.TabIndex = 0;
            listViewVerifikacije.UseCompatibleStateImageBehavior = false;
            listViewVerifikacije.View = View.Details;
            //
            // colVerId
            //
            colVerId.Text = "ID";
            colVerId.Width = 40;
            //
            // colVerDatum
            //
            colVerDatum.Text = "Datum";
            colVerDatum.Width = 90;
            //
            // colVerVerifikator
            //
            colVerVerifikator.Text = "Verifikator";
            colVerVerifikator.Width = 150;
            //
            // colVerRezultat
            //
            colVerRezultat.Text = "Rezultat";
            colVerRezultat.Width = 150;
            //
            // colVerOgranicenja
            //
            colVerOgranicenja.Text = "Ograničenja";
            colVerOgranicenja.Width = 150;
            //
            // dtpDatumVerifikacije
            //
            dtpDatumVerifikacije.Format = DateTimePickerFormat.Short;
            dtpDatumVerifikacije.Location = new Point(15, 135);
            dtpDatumVerifikacije.Name = "dtpDatumVerifikacije";
            dtpDatumVerifikacije.Size = new Size(150, 27);
            dtpDatumVerifikacije.TabIndex = 1;
            //
            // txtVerifikator
            //
            txtVerifikator.Location = new Point(175, 135);
            txtVerifikator.Name = "txtVerifikator";
            txtVerifikator.PlaceholderText = "Verifikator";
            txtVerifikator.Size = new Size(150, 27);
            txtVerifikator.TabIndex = 2;
            //
            // txtRezultat
            //
            txtRezultat.Location = new Point(335, 135);
            txtRezultat.Name = "txtRezultat";
            txtRezultat.PlaceholderText = "Rezultat";
            txtRezultat.Size = new Size(150, 27);
            txtRezultat.TabIndex = 3;
            //
            // txtOgranicenjaVerifikacije
            //
            txtOgranicenjaVerifikacije.Location = new Point(495, 135);
            txtOgranicenjaVerifikacije.Name = "txtOgranicenjaVerifikacije";
            txtOgranicenjaVerifikacije.PlaceholderText = "Ograničenja";
            txtOgranicenjaVerifikacije.Size = new Size(210, 27);
            txtOgranicenjaVerifikacije.TabIndex = 4;
            //
            // btnDodajVerifikaciju
            //
            btnDodajVerifikaciju.Location = new Point(15, 175);
            btnDodajVerifikaciju.Name = "btnDodajVerifikaciju";
            btnDodajVerifikaciju.Size = new Size(150, 32);
            btnDodajVerifikaciju.TabIndex = 5;
            btnDodajVerifikaciju.Text = "Dodaj verifikaciju";
            btnDodajVerifikaciju.UseVisualStyleBackColor = true;
            btnDodajVerifikaciju.Click += btnDodajVerifikaciju_Click;
            //
            // btnObrisiVerifikaciju
            //
            btnObrisiVerifikaciju.Location = new Point(175, 175);
            btnObrisiVerifikaciju.Name = "btnObrisiVerifikaciju";
            btnObrisiVerifikaciju.Size = new Size(150, 32);
            btnObrisiVerifikaciju.TabIndex = 6;
            btnObrisiVerifikaciju.Text = "Obriši izabranu";
            btnObrisiVerifikaciju.UseVisualStyleBackColor = true;
            btnObrisiVerifikaciju.Click += btnObrisiVerifikaciju_Click;

            //
            // grpNaciniPlacanja
            //
            grpNaciniPlacanja.Controls.Add(listViewNaciniPlacanja);
            grpNaciniPlacanja.Controls.Add(txtTipPlacanja);
            grpNaciniPlacanja.Controls.Add(txtStatusPlacanja);
            grpNaciniPlacanja.Controls.Add(dtpDatumDodavanjaPlacanja);
            grpNaciniPlacanja.Controls.Add(txtOgranicenjaPlacanja);
            grpNaciniPlacanja.Controls.Add(btnDodajNacinPlacanja);
            grpNaciniPlacanja.Controls.Add(btnObrisiNacinPlacanja);
            grpNaciniPlacanja.Location = new Point(12, 415);
            grpNaciniPlacanja.Name = "grpNaciniPlacanja";
            grpNaciniPlacanja.Size = new Size(720, 220);
            grpNaciniPlacanja.TabIndex = 2;
            grpNaciniPlacanja.TabStop = false;
            grpNaciniPlacanja.Text = "Načini plaćanja";
            //
            // listViewNaciniPlacanja
            //
            listViewNaciniPlacanja.Columns.AddRange(new ColumnHeader[] { colPlId, colPlTip, colPlStatus, colPlDatum, colPlOgranicenja });
            listViewNaciniPlacanja.FullRowSelect = true;
            listViewNaciniPlacanja.GridLines = true;
            listViewNaciniPlacanja.Location = new Point(15, 25);
            listViewNaciniPlacanja.MultiSelect = false;
            listViewNaciniPlacanja.Name = "listViewNaciniPlacanja";
            listViewNaciniPlacanja.Size = new Size(690, 100);
            listViewNaciniPlacanja.TabIndex = 0;
            listViewNaciniPlacanja.UseCompatibleStateImageBehavior = false;
            listViewNaciniPlacanja.View = View.Details;
            //
            // colPlId
            //
            colPlId.Text = "ID";
            colPlId.Width = 40;
            //
            // colPlTip
            //
            colPlTip.Text = "Tip plaćanja";
            colPlTip.Width = 150;
            //
            // colPlStatus
            //
            colPlStatus.Text = "Status";
            colPlStatus.Width = 100;
            //
            // colPlDatum
            //
            colPlDatum.Text = "Datum dodavanja";
            colPlDatum.Width = 130;
            //
            // colPlOgranicenja
            //
            colPlOgranicenja.Text = "Ograničenja";
            colPlOgranicenja.Width = 150;
            //
            // txtTipPlacanja
            //
            txtTipPlacanja.Location = new Point(15, 135);
            txtTipPlacanja.Name = "txtTipPlacanja";
            txtTipPlacanja.PlaceholderText = "Tip plaćanja";
            txtTipPlacanja.Size = new Size(150, 27);
            txtTipPlacanja.TabIndex = 1;
            //
            // txtStatusPlacanja
            //
            txtStatusPlacanja.Location = new Point(175, 135);
            txtStatusPlacanja.Name = "txtStatusPlacanja";
            txtStatusPlacanja.PlaceholderText = "Status";
            txtStatusPlacanja.Size = new Size(120, 27);
            txtStatusPlacanja.TabIndex = 2;
            //
            // dtpDatumDodavanjaPlacanja
            //
            dtpDatumDodavanjaPlacanja.Format = DateTimePickerFormat.Short;
            dtpDatumDodavanjaPlacanja.Location = new Point(305, 135);
            dtpDatumDodavanjaPlacanja.Name = "dtpDatumDodavanjaPlacanja";
            dtpDatumDodavanjaPlacanja.Size = new Size(150, 27);
            dtpDatumDodavanjaPlacanja.TabIndex = 3;
            //
            // txtOgranicenjaPlacanja
            //
            txtOgranicenjaPlacanja.Location = new Point(465, 135);
            txtOgranicenjaPlacanja.Name = "txtOgranicenjaPlacanja";
            txtOgranicenjaPlacanja.PlaceholderText = "Ograničenja";
            txtOgranicenjaPlacanja.Size = new Size(240, 27);
            txtOgranicenjaPlacanja.TabIndex = 4;
            //
            // btnDodajNacinPlacanja
            //
            btnDodajNacinPlacanja.Location = new Point(15, 175);
            btnDodajNacinPlacanja.Name = "btnDodajNacinPlacanja";
            btnDodajNacinPlacanja.Size = new Size(180, 32);
            btnDodajNacinPlacanja.TabIndex = 5;
            btnDodajNacinPlacanja.Text = "Dodaj način plaćanja";
            btnDodajNacinPlacanja.UseVisualStyleBackColor = true;
            btnDodajNacinPlacanja.Click += btnDodajNacinPlacanja_Click;
            //
            // btnObrisiNacinPlacanja
            //
            btnObrisiNacinPlacanja.Location = new Point(205, 175);
            btnObrisiNacinPlacanja.Name = "btnObrisiNacinPlacanja";
            btnObrisiNacinPlacanja.Size = new Size(150, 32);
            btnObrisiNacinPlacanja.TabIndex = 6;
            btnObrisiNacinPlacanja.Text = "Obriši izabrani";
            btnObrisiNacinPlacanja.UseVisualStyleBackColor = true;
            btnObrisiNacinPlacanja.Click += btnObrisiNacinPlacanja_Click;

            //
            // KorisnikDodatniPodaciForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 655);
            Controls.Add(grpNaciniPlacanja);
            Controls.Add(grpVerifikacije);
            Controls.Add(grpTelefoni);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "KorisnikDodatniPodaciForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodatni podaci o korisniku";
            Load += KorisnikDodatniPodaciForm_Load;
            grpTelefoni.ResumeLayout(false);
            grpTelefoni.PerformLayout();
            grpVerifikacije.ResumeLayout(false);
            grpVerifikacije.PerformLayout();
            grpNaciniPlacanja.ResumeLayout(false);
            grpNaciniPlacanja.PerformLayout();
            ResumeLayout(false);
        }
    }
}