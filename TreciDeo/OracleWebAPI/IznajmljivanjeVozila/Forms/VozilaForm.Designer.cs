namespace FluentNHibernateTemplate.Forms
{
    partial class VozilaForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewVozila;
        private ColumnHeader colId;
        private ColumnHeader colReg;
        private ColumnHeader colMarka;
        private ColumnHeader colModel;
        private ColumnHeader colGodina;
        private ColumnHeader colDatum;
        private ColumnHeader colStatus;
        private ColumnHeader colSedista;
        private ColumnHeader colPogon;
        private ColumnHeader colKoriscenje;
        private ColumnHeader colPodtip;
        private ColumnHeader colVin;
        private Button btnDodajVozilo;
        private Button btnIzmeniVozilo;
        private Button btnObrisiVozilo;
        private Button btnServisi;
        private Button btnKvarovi;
        private Button btnPunjenja;
        private Button btnNezgode;
        private Button btnOprema;
        private GroupBox grpAkcije;
        private GroupBox grpPovezano;

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
            listViewVozila = new ListView();
            colId = new ColumnHeader();
            colReg = new ColumnHeader();
            colMarka = new ColumnHeader();
            colModel = new ColumnHeader();
            colGodina = new ColumnHeader();
            colDatum = new ColumnHeader();
            colStatus = new ColumnHeader();
            colSedista = new ColumnHeader();
            colPogon = new ColumnHeader();
            colKoriscenje = new ColumnHeader();
            colPodtip = new ColumnHeader();
            colVin = new ColumnHeader();
            btnDodajVozilo = new Button();
            btnIzmeniVozilo = new Button();
            btnObrisiVozilo = new Button();
            btnServisi = new Button();
            btnKvarovi = new Button();
            btnPunjenja = new Button();
            btnNezgode = new Button();
            btnOprema = new Button();
            grpAkcije = new GroupBox();
            grpPovezano = new GroupBox();
            grpAkcije.SuspendLayout();
            grpPovezano.SuspendLayout();
            SuspendLayout();
            // 
            // listViewVozila
            // 
            listViewVozila.Columns.AddRange(new ColumnHeader[] {
                colId, colReg, colMarka, colModel, colGodina, colDatum, colStatus, colSedista, colPogon, colKoriscenje, colVin
            });
            listViewVozila.FullRowSelect = true;
            listViewVozila.GridLines = true;
            listViewVozila.Location = new Point(12, 12);
            listViewVozila.MultiSelect = false;
            listViewVozila.Name = "listViewVozila";
            listViewVozila.Size = new Size(1000, 480);
            listViewVozila.TabIndex = 0;
            listViewVozila.UseCompatibleStateImageBehavior = false;
            listViewVozila.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 40;
            // 
            // colReg
            // 
            colReg.Text = "Reg. Oznaka";
            colReg.Width = 100;
            // 
            // colMarka
            // 
            colMarka.Text = "Marka";
            colMarka.Width = 90;
            // 
            // colModel
            // 
            colModel.Text = "Model";
            colModel.Width = 90;
            // 
            // colGodina
            // 
            colGodina.Text = "Godina";
            colGodina.Width = 60;
            // 
            // colDatum
            // 
            colDatum.Text = "Nabavljeno";
            colDatum.Width = 90;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 90;
            // 
            // colSedista
            // 
            colSedista.Text = "Sedišta";
            colSedista.Width = 60;
            // 
            // colPogon
            // 
            colPogon.Text = "Tip Pogona";
            colPogon.Width = 90;
            // 
            // colKoriscenje
            // 
            colKoriscenje.Text = "Korišćenje";
            colKoriscenje.Width = 100;
            // 
            // colVin
            // 
            colVin.Text = "VIN";
            colVin.Width = 150;
            // 
            // btnDodajVozilo
            // 
            btnDodajVozilo.Location = new Point(15, 25);
            btnDodajVozilo.Name = "btnDodajVozilo";
            btnDodajVozilo.Size = new Size(140, 30);
            btnDodajVozilo.TabIndex = 0;
            btnDodajVozilo.Text = "Dodaj vozilo";
            btnDodajVozilo.UseVisualStyleBackColor = true;
            btnDodajVozilo.Click += btnDodajVozilo_Click;
            // 
            // btnIzmeniVozilo
            // 
            btnIzmeniVozilo.Location = new Point(15, 65);
            btnIzmeniVozilo.Name = "btnIzmeniVozilo";
            btnIzmeniVozilo.Size = new Size(140, 30);
            btnIzmeniVozilo.TabIndex = 1;
            btnIzmeniVozilo.Text = "Izmeni vozilo";
            btnIzmeniVozilo.UseVisualStyleBackColor = true;
            btnIzmeniVozilo.Click += btnIzmeniVozilo_Click;
            // 
            // btnObrisiVozilo
            // 
            btnObrisiVozilo.Location = new Point(15, 105);
            btnObrisiVozilo.Name = "btnObrisiVozilo";
            btnObrisiVozilo.Size = new Size(140, 30);
            btnObrisiVozilo.TabIndex = 2;
            btnObrisiVozilo.Text = "Obriši vozilo";
            btnObrisiVozilo.UseVisualStyleBackColor = true;
            btnObrisiVozilo.Click += btnObrisiVozilo_Click;
            // 
            // btnServisi
            // 
            btnServisi.Location = new Point(15, 25);
            btnServisi.Name = "btnServisi";
            btnServisi.Size = new Size(140, 30);
            btnServisi.TabIndex = 0;
            btnServisi.Text = "Servisi";
            btnServisi.UseVisualStyleBackColor = true;
            btnServisi.Click += btnServisi_Click;
            // 
            // btnKvarovi
            // 
            btnKvarovi.Location = new Point(15, 65);
            btnKvarovi.Name = "btnKvarovi";
            btnKvarovi.Size = new Size(140, 30);
            btnKvarovi.TabIndex = 1;
            btnKvarovi.Text = "Kvarovi";
            btnKvarovi.UseVisualStyleBackColor = true;
            btnKvarovi.Click += btnKvarovi_Click;
            // 
            // btnPunjenja
            // 
            btnPunjenja.Location = new Point(15, 105);
            btnPunjenja.Name = "btnPunjenja";
            btnPunjenja.Size = new Size(140, 30);
            btnPunjenja.TabIndex = 2;
            btnPunjenja.Text = "Punjenja / Točenja";
            btnPunjenja.UseVisualStyleBackColor = true;
            btnPunjenja.Click += btnPunjenja_Click;
            // 
            // btnNezgode
            // 
            btnNezgode.Location = new Point(15, 145);
            btnNezgode.Name = "btnNezgode";
            btnNezgode.Size = new Size(140, 30);
            btnNezgode.TabIndex = 3;
            btnNezgode.Text = "Nezgode i štete";
            btnNezgode.UseVisualStyleBackColor = true;
            btnNezgode.Click += btnNezgode_Click;
            // 
            // btnOprema
            // 
            btnOprema.Location = new Point(15, 185);
            btnOprema.Name = "btnOprema";
            btnOprema.Size = new Size(140, 30);
            btnOprema.TabIndex = 4;
            btnOprema.Text = "Oprema vozila";
            btnOprema.UseVisualStyleBackColor = true;
            btnOprema.Click += btnOprema_Click;
            // 
            // grpAkcije
            // 
            grpAkcije.Controls.Add(btnDodajVozilo);
            grpAkcije.Controls.Add(btnIzmeniVozilo);
            grpAkcije.Controls.Add(btnObrisiVozilo);
            grpAkcije.Location = new Point(1025, 12);
            grpAkcije.Name = "grpAkcije";
            grpAkcije.Size = new Size(170, 150);
            grpAkcije.TabIndex = 1;
            grpAkcije.TabStop = false;
            grpAkcije.Text = "Upravljanje vozilima";
            // 
            // grpPovezano
            // 
            grpPovezano.Controls.Add(btnServisi);
            grpPovezano.Controls.Add(btnKvarovi);
            grpPovezano.Controls.Add(btnPunjenja);
            grpPovezano.Controls.Add(btnNezgode);
            grpPovezano.Controls.Add(btnOprema);
            grpPovezano.Location = new Point(1025, 180);
            grpPovezano.Name = "grpPovezano";
            grpPovezano.Size = new Size(170, 230);
            grpPovezano.TabIndex = 2;
            grpPovezano.TabStop = false;
            grpPovezano.Text = "Povezane evidencije";
            // 
            // VozilaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 505);
            Controls.Add(grpPovezano);
            Controls.Add(grpAkcije);
            Controls.Add(listViewVozila);
            Name = "VozilaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija Vozila";
            Load += VozilaForm_Load;
            grpAkcije.ResumeLayout(false);
            grpPovezano.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
