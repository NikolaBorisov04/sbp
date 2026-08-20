namespace FluentNHibernateTemplate.Forms
{
    partial class KvaroviForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewKvarovi;
        private ColumnHeader colId;
        private ColumnHeader colVozilo;
        private ColumnHeader colPrijavio;
        private ColumnHeader colDatumPrijave;
        private ColumnHeader colOzbiljnost;
        private ColumnHeader colStatus;
        private ColumnHeader colOtklonjeno;
        private ColumnHeader colOpis;
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
            listViewKvarovi = new ListView();
            colId = new ColumnHeader();
            colVozilo = new ColumnHeader();
            colPrijavio = new ColumnHeader();
            colDatumPrijave = new ColumnHeader();
            colOzbiljnost = new ColumnHeader();
            colStatus = new ColumnHeader();
            colOtklonjeno = new ColumnHeader();
            colOpis = new ColumnHeader();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            grpAkcije = new GroupBox();
            grpAkcije.SuspendLayout();
            SuspendLayout();
            // 
            // listViewKvarovi
            // 
            listViewKvarovi.Columns.AddRange(new ColumnHeader[] {
                colId, colVozilo, colPrijavio, colDatumPrijave, colOzbiljnost, colStatus, colOtklonjeno, colOpis
            });
            listViewKvarovi.FullRowSelect = true;
            listViewKvarovi.GridLines = true;
            listViewKvarovi.Location = new Point(12, 12);
            listViewKvarovi.MultiSelect = false;
            listViewKvarovi.Name = "listViewKvarovi";
            listViewKvarovi.Size = new Size(820, 420);
            listViewKvarovi.TabIndex = 0;
            listViewKvarovi.UseCompatibleStateImageBehavior = false;
            listViewKvarovi.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 40;
            // 
            // colVozilo
            // 
            colVozilo.Text = "Vozilo";
            colVozilo.Width = 140;
            // 
            // colPrijavio
            // 
            colPrijavio.Text = "Prijavio";
            colPrijavio.Width = 90;
            // 
            // colDatumPrijave
            // 
            colDatumPrijave.Text = "Prijava";
            colDatumPrijave.Width = 90;
            // 
            // colOzbiljnost
            // 
            colOzbiljnost.Text = "Ozbiljnost";
            colOzbiljnost.Width = 90;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 80;
            // 
            // colOtklonjeno
            // 
            colOtklonjeno.Text = "Otklonjeno";
            colOtklonjeno.Width = 90;
            // 
            // colOpis
            // 
            colOpis.Text = "Opis problema";
            colOpis.Width = 190;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(15, 25);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 30);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Prijavi kvar";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(15, 65);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(130, 30);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni kvar";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(15, 105);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(130, 30);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši kvar";
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
            // KvaroviForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 445);
            Controls.Add(grpAkcije);
            Controls.Add(listViewKvarovi);
            Name = "KvaroviForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Evidencija Kvarova";
            Load += KvaroviForm_Load;
            grpAkcije.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
