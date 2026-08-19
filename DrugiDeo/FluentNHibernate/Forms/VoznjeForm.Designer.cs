namespace FluentNHibernateTemplate.Forms
{
    partial class VoznjeForm
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
            listaVoznji = new ListView();
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listaVoznji
            // 
            listaVoznji.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listaVoznji.FullRowSelect = true;
            listaVoznji.GridLines = true;
            listaVoznji.Location = new Point(12, 12);
            listaVoznji.Name = "listaVoznji";
            listaVoznji.Size = new Size(1396, 426);
            listaVoznji.TabIndex = 0;
            listaVoznji.UseCompatibleStateImageBehavior = false;
            listaVoznji.View = View.Details;
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
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vreme završetka";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Pređena kilometraža";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Trajanje (min)";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Početni nivo goriva/baterije";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Krajnji nivo goriva/baterije";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Početna lokacija";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Završna lokacija";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Cena";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Naknade";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(6, 40);
            button1.Name = "button1";
            button1.Size = new Size(143, 30);
            button1.TabIndex = 1;
            button1.Text = "Kreiraj voznju";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 76);
            button2.Name = "button2";
            button2.Size = new Size(143, 30);
            button2.TabIndex = 2;
            button2.Text = "Izmeni voznju";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 112);
            button3.Name = "button3";
            button3.Size = new Size(143, 30);
            button3.TabIndex = 3;
            button3.Text = "Izbriši voznju";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(1435, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 153);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o vožnji";
            // 
            // VoznjeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 450);
            Controls.Add(groupBox1);
            Controls.Add(listaVoznji);
            Name = "VoznjeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voznje";
            Load += VoznjeForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listaVoznji;
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
        private ColumnHeader columnHeader11;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
    }
}