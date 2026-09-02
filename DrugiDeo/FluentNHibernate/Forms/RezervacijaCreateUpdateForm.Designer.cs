namespace FluentNHibernateTemplate.Forms
{
    partial class RezervacijaCreateUpdateForm
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            bindingSource1 = new BindingSource(components);
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            checkBox1 = new CheckBox();
            label10 = new Label();
            label11 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Vreme početka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 74);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Vreme završetka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 123);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 3;
            label3.Text = "Lokacija preuzimanja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 172);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 4;
            label4.Text = "Lokacija vraćanja:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 218);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 6;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 259);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 7;
            label7.Text = "Korisnik:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 25);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 8;
            label8.Text = "Vozilo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 74);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 9;
            label9.Text = "Vozač:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy. HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(168, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd.MM.yyyy. HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(168, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(192, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 27);
            textBox4.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(619, 306);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(168, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(494, 25);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 28);
            comboBox2.TabIndex = 17;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(494, 71);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(215, 28);
            comboBox3.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(529, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 24);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Službena vožnja";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(430, 179);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 20;
            label10.Text = "Razlog:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(385, 241);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 21;
            label11.Text = "Ovlašćeno lice:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(494, 172);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 47);
            textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(498, 238);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(215, 46);
            textBox6.TabIndex = 23;
            // 
            // RezervacijaCreateUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 354);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(checkBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "RezervacijaCreateUpdateForm";
            Text = "RezervacijaCreateUpdateForm";
            Load += RezervacijaCreateUpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button button1;
        private ComboBox comboBox1;
        private BindingSource bindingSource1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private CheckBox checkBox1;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}