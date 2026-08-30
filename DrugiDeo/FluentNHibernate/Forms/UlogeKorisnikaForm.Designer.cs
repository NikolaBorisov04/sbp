namespace FluentNHibernateTemplate.Forms
{
    partial class UlogeKorisnikaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpKatalog;
        private System.Windows.Forms.ListView listViewKatalog;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNaziv;
        private System.Windows.Forms.Button btnObrisiKatalog;
        private System.Windows.Forms.Label lblNoviNaziv;
        private System.Windows.Forms.TextBox txtNazivUloge;
        private System.Windows.Forms.Button btnDodajKatalog;
        private System.Windows.Forms.GroupBox grpDodeljivanje;
        private System.Windows.Forms.ListView listViewDodeljene;
        private System.Windows.Forms.ColumnHeader colDId;
        private System.Windows.Forms.ColumnHeader colDNaziv;
        private System.Windows.Forms.Button btnUkloniDodeljenu;
        private System.Windows.Forms.Label lblIzaberiUlogu;
        private System.Windows.Forms.ComboBox cmbUlogaIzbor;
        private System.Windows.Forms.Button btnDodeli;

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
            grpKatalog = new GroupBox();
            btnDodajKatalog = new Button();
            txtNazivUloge = new TextBox();
            lblNoviNaziv = new Label();
            btnObrisiKatalog = new Button();
            listViewKatalog = new ListView();
            colId = new ColumnHeader();
            colNaziv = new ColumnHeader();
            grpDodeljivanje = new GroupBox();
            btnDodeli = new Button();
            cmbUlogaIzbor = new ComboBox();
            lblIzaberiUlogu = new Label();
            btnUkloniDodeljenu = new Button();
            listViewDodeljene = new ListView();
            colDId = new ColumnHeader();
            colDNaziv = new ColumnHeader();
            grpKatalog.SuspendLayout();
            grpDodeljivanje.SuspendLayout();
            SuspendLayout();
            //
            // grpKatalog
            //
            grpKatalog.Controls.Add(btnDodajKatalog);
            grpKatalog.Controls.Add(txtNazivUloge);
            grpKatalog.Controls.Add(lblNoviNaziv);
            grpKatalog.Controls.Add(btnObrisiKatalog);
            grpKatalog.Controls.Add(listViewKatalog);
            grpKatalog.Location = new Point(12, 12);
            grpKatalog.Name = "grpKatalog";
            grpKatalog.Size = new Size(350, 420);
            grpKatalog.TabIndex = 0;
            grpKatalog.TabStop = false;
            grpKatalog.Text = "Katalog uloga";
            //
            // btnDodajKatalog
            //
            btnDodajKatalog.Location = new Point(80, 370);
            btnDodajKatalog.Name = "btnDodajKatalog";
            btnDodajKatalog.Size = new Size(150, 32);
            btnDodajKatalog.TabIndex = 4;
            btnDodajKatalog.Text = "Dodaj u katalog";
            btnDodajKatalog.UseVisualStyleBackColor = true;
            btnDodajKatalog.Click += btnDodajKatalog_Click;
            //
            // txtNazivUloge
            //
            txtNazivUloge.Location = new Point(80, 332);
            txtNazivUloge.Name = "txtNazivUloge";
            txtNazivUloge.Size = new Size(255, 27);
            txtNazivUloge.TabIndex = 3;
            //
            // lblNoviNaziv
            //
            lblNoviNaziv.AutoSize = true;
            lblNoviNaziv.Location = new Point(15, 335);
            lblNoviNaziv.Name = "lblNoviNaziv";
            lblNoviNaziv.Size = new Size(81, 20);
            lblNoviNaziv.TabIndex = 2;
            lblNoviNaziv.Text = "Novi naziv:";
            //
            // btnObrisiKatalog
            //
            btnObrisiKatalog.Location = new Point(15, 292);
            btnObrisiKatalog.Name = "btnObrisiKatalog";
            btnObrisiKatalog.Size = new Size(157, 30);
            btnObrisiKatalog.TabIndex = 1;
            btnObrisiKatalog.Text = "Obriši iz kataloga";
            btnObrisiKatalog.UseVisualStyleBackColor = true;
            btnObrisiKatalog.Click += btnObrisiKatalog_Click;
            //
            // listViewKatalog
            //
            listViewKatalog.Columns.AddRange(new ColumnHeader[] { colId, colNaziv });
            listViewKatalog.FullRowSelect = true;
            listViewKatalog.GridLines = true;
            listViewKatalog.Location = new Point(15, 25);
            listViewKatalog.MultiSelect = false;
            listViewKatalog.Name = "listViewKatalog";
            listViewKatalog.Size = new Size(320, 260);
            listViewKatalog.TabIndex = 0;
            listViewKatalog.UseCompatibleStateImageBehavior = false;
            listViewKatalog.View = View.Details;
            //
            // colId
            //
            colId.Text = "ID";
            colId.Width = 40;
            //
            // colNaziv
            //
            colNaziv.Text = "Naziv";
            colNaziv.Width = 260;
            //
            // grpDodeljivanje
            //
            grpDodeljivanje.Controls.Add(btnDodeli);
            grpDodeljivanje.Controls.Add(cmbUlogaIzbor);
            grpDodeljivanje.Controls.Add(lblIzaberiUlogu);
            grpDodeljivanje.Controls.Add(btnUkloniDodeljenu);
            grpDodeljivanje.Controls.Add(listViewDodeljene);
            grpDodeljivanje.Location = new Point(380, 12);
            grpDodeljivanje.Name = "grpDodeljivanje";
            grpDodeljivanje.Size = new Size(400, 420);
            grpDodeljivanje.TabIndex = 1;
            grpDodeljivanje.TabStop = false;
            grpDodeljivanje.Text = "Uloge dodeljene ovom korisniku";
            //
            // btnDodeli
            //
            btnDodeli.Location = new Point(125, 370);
            btnDodeli.Name = "btnDodeli";
            btnDodeli.Size = new Size(150, 32);
            btnDodeli.TabIndex = 4;
            btnDodeli.Text = "Dodeli ulogu";
            btnDodeli.UseVisualStyleBackColor = true;
            btnDodeli.Click += btnDodeli_Click;
            //
            // cmbUlogaIzbor
            //
            cmbUlogaIzbor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUlogaIzbor.Location = new Point(125, 332);
            cmbUlogaIzbor.Name = "cmbUlogaIzbor";
            cmbUlogaIzbor.Size = new Size(250, 28);
            cmbUlogaIzbor.TabIndex = 3;
            //
            // lblIzaberiUlogu
            //
            lblIzaberiUlogu.AutoSize = true;
            lblIzaberiUlogu.Location = new Point(15, 335);
            lblIzaberiUlogu.Name = "lblIzaberiUlogu";
            lblIzaberiUlogu.Size = new Size(100, 20);
            lblIzaberiUlogu.TabIndex = 2;
            lblIzaberiUlogu.Text = "Izaberi ulogu:";
            //
            // btnUkloniDodeljenu
            //
            btnUkloniDodeljenu.Location = new Point(15, 292);
            btnUkloniDodeljenu.Name = "btnUkloniDodeljenu";
            btnUkloniDodeljenu.Size = new Size(160, 30);
            btnUkloniDodeljenu.TabIndex = 1;
            btnUkloniDodeljenu.Text = "Ukloni sa korisnika";
            btnUkloniDodeljenu.UseVisualStyleBackColor = true;
            btnUkloniDodeljenu.Click += btnUkloniDodeljenu_Click;
            //
            // listViewDodeljene
            //
            listViewDodeljene.Columns.AddRange(new ColumnHeader[] { colDId, colDNaziv });
            listViewDodeljene.FullRowSelect = true;
            listViewDodeljene.GridLines = true;
            listViewDodeljene.Location = new Point(15, 25);
            listViewDodeljene.MultiSelect = false;
            listViewDodeljene.Name = "listViewDodeljene";
            listViewDodeljene.Size = new Size(370, 255);
            listViewDodeljene.TabIndex = 0;
            listViewDodeljene.UseCompatibleStateImageBehavior = false;
            listViewDodeljene.View = View.Details;
            //
            // colDId
            //
            colDId.Text = "ID";
            colDId.Width = 40;
            //
            // colDNaziv
            //
            colDNaziv.Text = "Naziv uloge";
            colDNaziv.Width = 320;
            //
            // UlogeKorisnikaForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 445);
            Controls.Add(grpDodeljivanje);
            Controls.Add(grpKatalog);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UlogeKorisnikaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upravljanje Ulogama Korisnika";
            Load += UlogeKorisnikaForm_Load;
            grpKatalog.ResumeLayout(false);
            grpKatalog.PerformLayout();
            grpDodeljivanje.ResumeLayout(false);
            grpDodeljivanje.PerformLayout();
            ResumeLayout(false);
        }
    }
}