namespace FluentNHibernateTemplate;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        button1 = new Button();
        btnVozila = new Button();
        button2 = new Button();
        button3 = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(12, 279);
        button1.Name = "button1";
        button1.Size = new Size(465, 46);
        button1.TabIndex = 3;
        button1.Text = "Upravljaj vožnjama";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // btnVozila
        // 
        btnVozila.Location = new Point(12, 169);
        btnVozila.Name = "btnVozila";
        btnVozila.Size = new Size(465, 46);
        btnVozila.TabIndex = 4;
        btnVozila.Text = "Upravljaj vozilima";
        btnVozila.UseVisualStyleBackColor = true;
        btnVozila.Click += btnVozila_Click;
        // 
        // button2
        // 
        button2.Location = new Point(12, 224);
        button2.Name = "button2";
        button2.Size = new Size(465, 46);
        button2.TabIndex = 5;
        button2.Text = "Upravljaj rezervacijama";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(12, 114);
        button3.Name = "button3";
        button3.Size = new Size(465, 46);
        button3.TabIndex = 6;
        button3.Text = "Upravljaj korisnicima";
        button3.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(98, 28);
        label1.Name = "label1";
        label1.Size = new Size(304, 41);
        label1.TabIndex = 7;
        label1.Text = "Iznajmljivanje vozila";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(500, 364);
        Controls.Add(label1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(btnVozila);
        Controls.Add(button1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Iznajmljivanje vozila";
        ResumeLayout(false);
        PerformLayout();
    }
    private Button button1;
    private Button btnVozila;
    private Button button2;
    private Button button3;
    private Label label1;
}
