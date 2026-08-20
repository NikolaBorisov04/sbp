namespace FluentNHibernateTemplate.Forms
{
    partial class OpremaForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewKatalog;
        private ColumnHeader colId;
        private ColumnHeader colNaziv;
        private ColumnHeader colOpis;
        private TextBox txtNazivOpreme;
        private TextBox txtOpisOpreme;
        private Button btnDodajKatalog;
        private Button btnObrisiKatalog;
        private GroupBox grpKatalog;

        private GroupBox grpDodeljivanje;
        private ComboBox cmbOpremaIzbor;
        private CheckBox chkDodatna;
        private Button btnDodeli;
        private ListView listViewDodeljena;
        private ColumnHeader colDId;
        private ColumnHeader colDNaziv;
        private ColumnHeader colDTip;
        private ColumnHeader colDOpis;
        private Button btnUkloniDodeljenu;

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
            listViewKatalog = new ListView();
            colId = new ColumnHeader();
            colNaziv = new ColumnHeader();
            colOpis = new ColumnHeader();
            txtNazivOpreme = new TextBox();
            txtOpisOpreme = new TextBox();
            btnDodajKatalog = new Button();
            btnObrisiKatalog = new Button();
            grpKatalog = new GroupBox();

            grpDodeljivanje = new GroupBox();
            cmbOpremaIzbor = new ComboBox();
            chkDodatna = new CheckBox();
            btnDodeli = new Button();
            listViewDodeljena = new ListView();
            colDId = new ColumnHeader();
            colDNaziv = new ColumnHeader();
            colDTip = new ColumnHeader();
            colDOpis = new ColumnHeader();
            btnUkloniDodeljenu = new Button();

            grpKatalog.SuspendLayout();
            grpDodeljivanje.SuspendLayout();
            SuspendLayout();

            // Katalog Group
            grpKatalog.Location = new Point(12, 12);
            grpKatalog.Size = new Size(450, 480);
            grpKatalog.Text = "Katalog opreme";

            listViewKatalog.Columns.AddRange(new ColumnHeader[] { colId, colNaziv, colOpis });
            listViewKatalog.FullRowSelect = true;
            listViewKatalog.GridLines = true;
            listViewKatalog.Location = new Point(15, 25);
            listViewKatalog.MultiSelect = false;
            listViewKatalog.Size = new Size(420, 260);
            listViewKatalog.View = View.Details;
            colId.Text = "ID"; colId.Width = 40;
            colNaziv.Text = "Naziv"; colNaziv.Width = 140;
            colOpis.Text = "Opis"; colOpis.Width = 230;

            btnObrisiKatalog.Location = new Point(15, 292);
            btnObrisiKatalog.Size = new Size(130, 30);
            btnObrisiKatalog.Text = "Obriši iz kataloga";
            btnObrisiKatalog.Click += btnObrisiKatalog_Click;

            Label lkn = new() { Text = "Novi naziv:", Location = new Point(15, 335), AutoSize = true };
            txtNazivOpreme.Location = new Point(100, 332); txtNazivOpreme.Size = new Size(335, 27);
            Label lko = new() { Text = "Opis:", Location = new Point(15, 370), AutoSize = true };
            txtOpisOpreme.Location = new Point(100, 367); txtOpisOpreme.Size = new Size(335, 55); txtOpisOpreme.Multiline = true;
            btnDodajKatalog.Location = new Point(100, 430); btnDodajKatalog.Size = new Size(150, 32);
            btnDodajKatalog.Text = "Dodaj u katalog";
            btnDodajKatalog.Click += btnDodajKatalog_Click;

            grpKatalog.Controls.AddRange(new Control[] {
                listViewKatalog, btnObrisiKatalog, lkn, txtNazivOpreme, lko, txtOpisOpreme, btnDodajKatalog
            });

            // Dodeljivanje Group
            grpDodeljivanje.Location = new Point(480, 12);
            grpDodeljivanje.Size = new Size(540, 480);
            grpDodeljivanje.Text = "Oprema dodeljena ovom vozilu";

            listViewDodeljena.Columns.AddRange(new ColumnHeader[] { colDId, colDNaziv, colDTip, colDOpis });
            listViewDodeljena.FullRowSelect = true;
            listViewDodeljena.GridLines = true;
            listViewDodeljena.Location = new Point(15, 25);
            listViewDodeljena.MultiSelect = false;
            listViewDodeljena.Size = new Size(510, 295);
            listViewDodeljena.View = View.Details;
            colDId.Text = "ID"; colDId.Width = 40;
            colDNaziv.Text = "Naziv opreme"; colDNaziv.Width = 140;
            colDTip.Text = "Tip opreme"; colDTip.Width = 90;
            colDOpis.Text = "Opis"; colDOpis.Width = 230;

            btnUkloniDodeljenu.Location = new Point(15, 330);
            btnUkloniDodeljenu.Size = new Size(160, 30);
            btnUkloniDodeljenu.Text = "Ukloni sa vozila";
            btnUkloniDodeljenu.Click += btnUkloniDodeljenu_Click;

            Label ld = new() { Text = "Izaberi opremu:", Location = new Point(15, 380), AutoSize = true };
            cmbOpremaIzbor.Location = new Point(125, 377); cmbOpremaIzbor.Size = new Size(250, 27); cmbOpremaIzbor.DropDownStyle = ComboBoxStyle.DropDownList;
            chkDodatna.Location = new Point(390, 377); chkDodatna.Size = new Size(130, 27); chkDodatna.Text = "Dodatna oprema";
            btnDodeli.Location = new Point(125, 420); btnDodeli.Size = new Size(150, 32); btnDodeli.Text = "Dodeli opremu";
            btnDodeli.Click += btnDodeli_Click;

            grpDodeljivanje.Controls.AddRange(new Control[] {
                listViewDodeljena, btnUkloniDodeljenu, ld, cmbOpremaIzbor, chkDodatna, btnDodeli
            });

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 505);
            Controls.AddRange(new Control[] { grpKatalog, grpDodeljivanje });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upravljanje Opremom";
            Load += OpremaForm_Load;
            grpKatalog.ResumeLayout(false);
            grpDodeljivanje.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
