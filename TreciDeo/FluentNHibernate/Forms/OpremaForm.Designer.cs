namespace FluentNHibernateTemplate.Forms
{
    partial class OpremaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpKatalog;
        private System.Windows.Forms.ListView listViewKatalog;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNaziv;
        private System.Windows.Forms.ColumnHeader colOpis;
        private System.Windows.Forms.Button btnObrisiKatalog;
        private System.Windows.Forms.Label lblNoviNaziv;
        private System.Windows.Forms.TextBox txtNazivOpreme;
        private System.Windows.Forms.Label lblOpisKatalog;
        private System.Windows.Forms.TextBox txtOpisOpreme;
        private System.Windows.Forms.Button btnDodajKatalog;
        private System.Windows.Forms.GroupBox grpDodeljivanje;
        private System.Windows.Forms.ListView listViewDodeljena;
        private System.Windows.Forms.ColumnHeader colDId;
        private System.Windows.Forms.ColumnHeader colDNaziv;
        private System.Windows.Forms.ColumnHeader colDTip;
        private System.Windows.Forms.ColumnHeader colDOpis;
        private System.Windows.Forms.Button btnUkloniDodeljenu;
        private System.Windows.Forms.Label lblIzaberiOpremu;
        private System.Windows.Forms.ComboBox cmbOpremaIzbor;
        private System.Windows.Forms.CheckBox chkDodatna;
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
            txtOpisOpreme = new TextBox();
            lblOpisKatalog = new Label();
            txtNazivOpreme = new TextBox();
            lblNoviNaziv = new Label();
            btnObrisiKatalog = new Button();
            listViewKatalog = new ListView();
            colId = new ColumnHeader();
            colNaziv = new ColumnHeader();
            colOpis = new ColumnHeader();
            grpDodeljivanje = new GroupBox();
            btnDodeli = new Button();
            chkDodatna = new CheckBox();
            cmbOpremaIzbor = new ComboBox();
            lblIzaberiOpremu = new Label();
            btnUkloniDodeljenu = new Button();
            listViewDodeljena = new ListView();
            colDId = new ColumnHeader();
            colDNaziv = new ColumnHeader();
            colDTip = new ColumnHeader();
            colDOpis = new ColumnHeader();
            grpKatalog.SuspendLayout();
            grpDodeljivanje.SuspendLayout();
            SuspendLayout();
            // 
            // grpKatalog
            // 
            grpKatalog.Controls.Add(btnDodajKatalog);
            grpKatalog.Controls.Add(txtOpisOpreme);
            grpKatalog.Controls.Add(lblOpisKatalog);
            grpKatalog.Controls.Add(txtNazivOpreme);
            grpKatalog.Controls.Add(lblNoviNaziv);
            grpKatalog.Controls.Add(btnObrisiKatalog);
            grpKatalog.Controls.Add(listViewKatalog);
            grpKatalog.Location = new Point(12, 12);
            grpKatalog.Name = "grpKatalog";
            grpKatalog.Size = new Size(450, 480);
            grpKatalog.TabIndex = 0;
            grpKatalog.TabStop = false;
            grpKatalog.Text = "Katalog opreme";
            // 
            // btnDodajKatalog
            // 
            btnDodajKatalog.Location = new Point(100, 430);
            btnDodajKatalog.Name = "btnDodajKatalog";
            btnDodajKatalog.Size = new Size(150, 32);
            btnDodajKatalog.TabIndex = 6;
            btnDodajKatalog.Text = "Dodaj u katalog";
            btnDodajKatalog.UseVisualStyleBackColor = true;
            btnDodajKatalog.Click += btnDodajKatalog_Click;
            // 
            // txtOpisOpreme
            // 
            txtOpisOpreme.Location = new Point(100, 367);
            txtOpisOpreme.Multiline = true;
            txtOpisOpreme.Name = "txtOpisOpreme";
            txtOpisOpreme.Size = new Size(335, 55);
            txtOpisOpreme.TabIndex = 5;
            // 
            // lblOpisKatalog
            // 
            lblOpisKatalog.AutoSize = true;
            lblOpisKatalog.Location = new Point(15, 370);
            lblOpisKatalog.Name = "lblOpisKatalog";
            lblOpisKatalog.Size = new Size(42, 20);
            lblOpisKatalog.TabIndex = 4;
            lblOpisKatalog.Text = "Opis:";
            // 
            // txtNazivOpreme
            // 
            txtNazivOpreme.Location = new Point(100, 332);
            txtNazivOpreme.Name = "txtNazivOpreme";
            txtNazivOpreme.Size = new Size(335, 27);
            txtNazivOpreme.TabIndex = 3;
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
            listViewKatalog.Columns.AddRange(new ColumnHeader[] { colId, colNaziv, colOpis });
            listViewKatalog.FullRowSelect = true;
            listViewKatalog.GridLines = true;
            listViewKatalog.Location = new Point(15, 25);
            listViewKatalog.MultiSelect = false;
            listViewKatalog.Name = "listViewKatalog";
            listViewKatalog.Size = new Size(420, 260);
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
            colNaziv.Width = 140;
            // 
            // colOpis
            // 
            colOpis.Text = "Opis";
            colOpis.Width = 230;
            // 
            // grpDodeljivanje
            // 
            grpDodeljivanje.Controls.Add(btnDodeli);
            grpDodeljivanje.Controls.Add(chkDodatna);
            grpDodeljivanje.Controls.Add(cmbOpremaIzbor);
            grpDodeljivanje.Controls.Add(lblIzaberiOpremu);
            grpDodeljivanje.Controls.Add(btnUkloniDodeljenu);
            grpDodeljivanje.Controls.Add(listViewDodeljena);
            grpDodeljivanje.Location = new Point(480, 12);
            grpDodeljivanje.Name = "grpDodeljivanje";
            grpDodeljivanje.Size = new Size(540, 480);
            grpDodeljivanje.TabIndex = 1;
            grpDodeljivanje.TabStop = false;
            grpDodeljivanje.Text = "Oprema dodeljena ovom vozilu";
            // 
            // btnDodeli
            // 
            btnDodeli.Location = new Point(125, 420);
            btnDodeli.Name = "btnDodeli";
            btnDodeli.Size = new Size(150, 32);
            btnDodeli.TabIndex = 5;
            btnDodeli.Text = "Dodeli opremu";
            btnDodeli.UseVisualStyleBackColor = true;
            btnDodeli.Click += btnDodeli_Click;
            // 
            // chkDodatna
            // 
            chkDodatna.Location = new Point(390, 377);
            chkDodatna.Name = "chkDodatna";
            chkDodatna.Size = new Size(130, 27);
            chkDodatna.TabIndex = 4;
            chkDodatna.Text = "Dodatna oprema";
            // 
            // cmbOpremaIzbor
            // 
            cmbOpremaIzbor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOpremaIzbor.Location = new Point(125, 377);
            cmbOpremaIzbor.Name = "cmbOpremaIzbor";
            cmbOpremaIzbor.Size = new Size(250, 28);
            cmbOpremaIzbor.TabIndex = 3;
            // 
            // lblIzaberiOpremu
            // 
            lblIzaberiOpremu.AutoSize = true;
            lblIzaberiOpremu.Location = new Point(15, 380);
            lblIzaberiOpremu.Name = "lblIzaberiOpremu";
            lblIzaberiOpremu.Size = new Size(113, 20);
            lblIzaberiOpremu.TabIndex = 2;
            lblIzaberiOpremu.Text = "Izaberi opremu:";
            // 
            // btnUkloniDodeljenu
            // 
            btnUkloniDodeljenu.Location = new Point(15, 330);
            btnUkloniDodeljenu.Name = "btnUkloniDodeljenu";
            btnUkloniDodeljenu.Size = new Size(160, 30);
            btnUkloniDodeljenu.TabIndex = 1;
            btnUkloniDodeljenu.Text = "Ukloni sa vozila";
            btnUkloniDodeljenu.UseVisualStyleBackColor = true;
            btnUkloniDodeljenu.Click += btnUkloniDodeljenu_Click;
            // 
            // listViewDodeljena
            // 
            listViewDodeljena.Columns.AddRange(new ColumnHeader[] { colDId, colDNaziv, colDTip, colDOpis });
            listViewDodeljena.FullRowSelect = true;
            listViewDodeljena.GridLines = true;
            listViewDodeljena.Location = new Point(15, 25);
            listViewDodeljena.MultiSelect = false;
            listViewDodeljena.Name = "listViewDodeljena";
            listViewDodeljena.Size = new Size(510, 295);
            listViewDodeljena.TabIndex = 0;
            listViewDodeljena.UseCompatibleStateImageBehavior = false;
            listViewDodeljena.View = View.Details;
            // 
            // colDId
            // 
            colDId.Text = "ID";
            colDId.Width = 40;
            // 
            // colDNaziv
            // 
            colDNaziv.Text = "Naziv opreme";
            colDNaziv.Width = 140;
            // 
            // colDTip
            // 
            colDTip.Text = "Tip opreme";
            colDTip.Width = 90;
            // 
            // colDOpis
            // 
            colDOpis.Text = "Opis";
            colDOpis.Width = 230;
            // 
            // OpremaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 505);
            Controls.Add(grpDodeljivanje);
            Controls.Add(grpKatalog);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "OpremaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upravljanje Opremom";
            Load += OpremaForm_Load;
            grpKatalog.ResumeLayout(false);
            grpKatalog.PerformLayout();
            grpDodeljivanje.ResumeLayout(false);
            grpDodeljivanje.PerformLayout();
            ResumeLayout(false);
        }
    }
}
