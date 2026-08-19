namespace FluentNHibernateTemplate;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private Button testConnectionButton = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        testConnectionButton = new Button();
        UcitajVozilo = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // testConnectionButton
        // 
        testConnectionButton.Location = new Point(12, 13);
        testConnectionButton.Margin = new Padding(3, 4, 3, 4);
        testConnectionButton.Name = "testConnectionButton";
        testConnectionButton.Size = new Size(217, 47);
        testConnectionButton.TabIndex = 1;
        testConnectionButton.Text = "Testiraj vezu sa bazom";
        testConnectionButton.UseVisualStyleBackColor = true;
        testConnectionButton.Click += TestConnectionButton_Click;
        // 
        // UcitajVozilo
        // 
        UcitajVozilo.Location = new Point(12, 90);
        UcitajVozilo.Name = "UcitajVozilo";
        UcitajVozilo.Size = new Size(217, 46);
        UcitajVozilo.TabIndex = 2;
        UcitajVozilo.Text = "Ucitaj Vozilo sa ID-ijem 1";
        UcitajVozilo.UseVisualStyleBackColor = true;
        UcitajVozilo.Click += UcitajVozilo_Click;
        // 
        // button1
        // 
        button1.Location = new Point(260, 90);
        button1.Name = "button1";
        button1.Size = new Size(217, 46);
        button1.TabIndex = 3;
        button1.Text = "Prikazi voznje";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(640, 449);
        Controls.Add(button1);
        Controls.Add(UcitajVozilo);
        Controls.Add(testConnectionButton);
        Margin = new Padding(3, 4, 3, 4);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Fluent NHibernate Template";
        ResumeLayout(false);
    }
    private Button UcitajVozilo;
    private Button button1;
}
