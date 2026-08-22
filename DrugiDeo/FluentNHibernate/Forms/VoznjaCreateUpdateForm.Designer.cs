namespace FluentNHibernateTemplate.Forms
{
    partial class VoznjaCreateUpdateForm
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy. HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(217, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(248, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd.MM.yyyy. HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(217, 66);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(248, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 294);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(217, 256);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(248, 27);
            textBox6.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 31);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 11;
            label2.Text = "Vreme početka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 69);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 12;
            label3.Text = "Vreme završetka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 107);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 13;
            label4.Text = "Pređena kilometraža:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 145);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 14;
            label5.Text = "Trajanje (min):";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(217, 104);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(248, 27);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(217, 142);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(248, 27);
            numericUpDown2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 183);
            label6.Name = "label6";
            label6.Size = new Size(195, 20);
            label6.TabIndex = 17;
            label6.Text = "Početni nivo goriva/baterije:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(217, 180);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(248, 27);
            numericUpDown3.TabIndex = 18;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Location = new Point(217, 218);
            numericUpDown4.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(248, 27);
            numericUpDown4.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 221);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 20;
            label7.Text = "Krajnji nivo goriva/baterije:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(92, 259);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 21;
            label8.Text = "Početna lokacija:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 297);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 22;
            label9.Text = "Krajnja lokacija:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(166, 335);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 23;
            label10.Text = "Cena:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(140, 373);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 24;
            label11.Text = "Naknade:";
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 2;
            numericUpDown5.Location = new Point(217, 332);
            numericUpDown5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(248, 27);
            numericUpDown5.TabIndex = 25;
            // 
            // numericUpDown6
            // 
            numericUpDown6.DecimalPlaces = 2;
            numericUpDown6.Location = new Point(217, 370);
            numericUpDown6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(248, 27);
            numericUpDown6.TabIndex = 26;
            // 
            // button1
            // 
            button1.Location = new Point(347, 444);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 27;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VoznjaCreateUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 490);
            Controls.Add(button1);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(label6);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "VoznjaCreateUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmeni vožnju";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private Button button1;
    }
}