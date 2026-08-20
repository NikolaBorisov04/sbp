namespace FluentNHibernateTemplate.Forms
{
    partial class ServisiForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewServisi;
        private ColumnHeader colId;
        private ColumnHeader colVozilo;
        private ColumnHeader colTip;
        private ColumnHeader colCentar;
        private ColumnHeader colDatumPrijema;
        private ColumnHeader colDatumZavrsetka;
        private ColumnHeader colTroskovi;
        private ColumnHeader colStatus;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private GroupBox grpAkcije;

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
            listViewServisi = new ListView();
            colId = new ColumnHeader();
            colVozilo = new ColumnHeader();
            colTip = new ColumnHeader();
            colCentar = new ColumnHeader();
            colDatumPrijema = new ColumnHeader();
            colDatumZavrsetka = new ColumnHeader();
            colTroskovi = new ColumnHeader();
            colStatus = new ColumnHeader();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            grpAkcije = new GroupBox();
            grpAkcije.SuspendLayout();
            SuspendLayout();
            // 
            // listViewServisi
            // 
            listViewServisi.Columns.AddRange(new ColumnHeader[] {
                colId, colVozilo, colTip, colCentar, colDatumPrijema, colDatumZavrsetka, colTroskovi, colStatus
            });
            listViewServisi.FullRowSelect = true;
            listViewServisi.GridLines = true;
            listViewServisi.Location = new Point(12, 12);
            listViewServisi.MultiSelect = false;
            listViewServisi.Name = "listViewServisi";
            listViewServisi.Size = new Size(820, 420);
            listViewServisi.TabIndex = 0;
            listViewServisi.UseCompatibleStateImageBehavior = false;
            listViewServisi.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 40;
            // 
            // colVozilo
            // 
            colVozilo.Text = "Vozilo";
            colVozilo.Width = 150;
            // 
            // colTip
            // 
            colTip.Text = "Tip servisa";
            colTip.Width = 100;
            // 
            // colCentar
            // 
            colCentar.Text = "Servisni centar";
            colCentar.Width = 170;
            // 
            // colDatumPrijema
            // 
            colDatumPrijema.Text = "Prijem";
            colDatumPrijema.Width = 90;
            // 
            // colDatumZavrsetka
            // 
            colDatumZavrsetka.Text = "Završetak";
            colDatumZavrsetka.Width = 90;
            // 
            // colTroskovi
            // 
            colTroskovi.Text = "Troškovi (RSD)";
            colTroskovi.Width = 100;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 80;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(15, 25);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 30);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Evidentiraj servis";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(15, 65);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(130, 30);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni servis";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(15, 105);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(130, 30);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši servis";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // grpAkcije
            // 
            grpAkcije.Controls.Add(btnDodaj);
            grpAkcije.Controls.Add(btnIzmeni);
            grpAkcije.Controls.Add(btnObrisi);
            grpAkcije.Location = new Point(845, 12);
            grpAkcije.Name = "grpAkcije";
            grpAkcije.Size = new Size(160, 150);
            grpAkcije.TabIndex = 1;
            grpAkcije.TabStop = false;
            grpAkcije.Text = "Akcije";
            // 
            // ServisiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 445);
            Controls.Add(grpAkcije);
            Controls.Add(listViewServisi);
            Name = "ServisiForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Evidencija Servisa";
            Load += ServisiForm_Load;
            grpAkcije.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
