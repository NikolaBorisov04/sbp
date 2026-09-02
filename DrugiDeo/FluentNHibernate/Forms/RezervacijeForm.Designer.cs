namespace FluentNHibernateTemplate.Forms
{
    partial class RezervacijeForm
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
            listaRezervacija = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listaRezervacija
            // 
            listaRezervacija.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listaRezervacija.FullRowSelect = true;
            listaRezervacija.GridLines = true;
            listaRezervacija.Location = new Point(12, 12);
            listaRezervacija.Name = "listaRezervacija";
            listaRezervacija.Size = new Size(1504, 426);
            listaRezervacija.TabIndex = 0;
            listaRezervacija.UseCompatibleStateImageBehavior = false;
            listaRezervacija.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Vreme početka";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vreme završetka";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Lokacija preuzimanja";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Lokacija vraćanja";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tip";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Status";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Korisnik";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Vozilo";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Vozač";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Razlog";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 160;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Ovlašćeno lice";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 140;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(1544, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 133);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o rezervacijama";
            // 
            // button3
            // 
            button3.Location = new Point(19, 96);
            button3.Name = "button3";
            button3.Size = new Size(165, 29);
            button3.TabIndex = 2;
            button3.Text = "Izbriši rezervaciju";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(19, 61);
            button2.Name = "button2";
            button2.Size = new Size(165, 29);
            button2.TabIndex = 1;
            button2.Text = "Izmeni rezervaciju";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(19, 26);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 0;
            button1.Text = "Kreiraj rezervaciju";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RezervacijeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1770, 450);
            Controls.Add(groupBox1);
            Controls.Add(listaRezervacija);
            Name = "RezervacijeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervacije";
            Load += RezervacijeForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listaRezervacija;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}