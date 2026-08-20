namespace FluentNHibernateTemplate.Forms
{
    partial class NezgodeSteteForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewNezgode;
        private ColumnHeader colId;
        private ColumnHeader colVozilo;
        private ColumnHeader colOdgovornost;
        private ColumnHeader colProcena;
        private ColumnHeader colSlike;
        private ColumnHeader colKuce;
        private ColumnHeader colZapisnici;
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
            listViewNezgode = new ListView();
            colId = new ColumnHeader();
            colVozilo = new ColumnHeader();
            colOdgovornost = new ColumnHeader();
            colProcena = new ColumnHeader();
            colSlike = new ColumnHeader();
            colKuce = new ColumnHeader();
            colZapisnici = new ColumnHeader();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            grpAkcije = new GroupBox();
            grpAkcije.SuspendLayout();
            SuspendLayout();
            // 
            // listViewNezgode
            // 
            listViewNezgode.Columns.AddRange(new ColumnHeader[] {
                colId, colVozilo, colOdgovornost, colProcena, colSlike, colKuce, colZapisnici
            });
            listViewNezgode.FullRowSelect = true;
            listViewNezgode.GridLines = true;
            listViewNezgode.Location = new Point(12, 12);
            listViewNezgode.MultiSelect = false;
            listViewNezgode.Name = "listViewNezgode";
            listViewNezgode.Size = new Size(820, 420);
            listViewNezgode.TabIndex = 0;
            listViewNezgode.UseCompatibleStateImageBehavior = false;
            listViewNezgode.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 40;
            // 
            // colVozilo
            // 
            colVozilo.Text = "Vozilo";
            colVozilo.Width = 160;
            // 
            // colOdgovornost
            // 
            colOdgovornost.Text = "Odgovornost";
            colOdgovornost.Width = 110;
            // 
            // colProcena
            // 
            colProcena.Text = "Procena štete (RSD)";
            colProcena.Width = 140;
            // 
            // colSlike
            // 
            colSlike.Text = "Fotografije";
            colSlike.Width = 90;
            // 
            // colKuce
            // 
            colKuce.Text = "Osiguranja";
            colKuce.Width = 90;
            // 
            // colZapisnici
            // 
            colZapisnici.Text = "Zapisnici";
            colZapisnici.Width = 90;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(15, 25);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 30);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Nova šteta";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(15, 65);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(130, 30);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni / Detalji";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(15, 105);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(130, 30);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši štetu";
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
            // NezgodeSteteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 445);
            Controls.Add(grpAkcije);
            Controls.Add(listViewNezgode);
            Name = "NezgodeSteteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Evidencija Nezgoda i Šteta";
            Load += NezgodeSteteForm_Load;
            grpAkcije.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
