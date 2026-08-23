namespace FluentNHibernateTemplate.Forms
{
    partial class DogadjajUVoznjiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listaDogadjaja = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnIzbrisi = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listaDogadjaja
            // 
            listaDogadjaja.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listaDogadjaja.FullRowSelect = true;
            listaDogadjaja.GridLines = true;
            listaDogadjaja.Location = new Point(12, 12);
            listaDogadjaja.Name = "listaDogadjaja";
            listaDogadjaja.Size = new Size(903, 426);
            listaDogadjaja.TabIndex = 0;
            listaDogadjaja.UseCompatibleStateImageBehavior = false;
            listaDogadjaja.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vreme";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Lokacija";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Opis";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 400;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(6, 31);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(171, 29);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj događaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(6, 66);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(171, 29);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni događaj";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnIzbrisi
            // 
            btnIzbrisi.Location = new Point(6, 101);
            btnIzbrisi.Name = "btnIzbrisi";
            btnIzbrisi.Size = new Size(171, 29);
            btnIzbrisi.TabIndex = 3;
            btnIzbrisi.Text = "Izbriši događaj";
            btnIzbrisi.UseVisualStyleBackColor = true;
            btnIzbrisi.Click += btnIzbrisi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIzbrisi);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(btnIzmeni);
            groupBox1.Location = new Point(937, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 145);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o događajima";
            // 
            // DogadjajUVoznjiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 450);
            Controls.Add(groupBox1);
            Controls.Add(listaDogadjaja);
            Name = "DogadjajUVoznjiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Događaji";
            Load += DogadjajUVoznjiForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listaDogadjaja;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnIzbrisi;
        private GroupBox groupBox1;
    }
}