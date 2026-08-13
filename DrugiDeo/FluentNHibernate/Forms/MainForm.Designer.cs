namespace FluentNHibernateTemplate;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private Button testConnectionButton = null!;
    private Label informationLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        testConnectionButton = new Button();
        informationLabel = new Label();
        SuspendLayout();

        //
        // informationLabel
        //
        informationLabel.AutoSize = true;
        informationLabel.Location = new Point(24, 24);
        informationLabel.Name = "informationLabel";
        informationLabel.Size = new Size(394, 15);
        informationLabel.TabIndex = 0;
        informationLabel.Text = "Univerzalni Fluent NHibernate skelet – ovde dodajte svoj UI.";

        //
        // testConnectionButton
        //
        testConnectionButton.Location = new Point(24, 58);
        testConnectionButton.Name = "testConnectionButton";
        testConnectionButton.Size = new Size(190, 35);
        testConnectionButton.TabIndex = 1;
        testConnectionButton.Text = "Testiraj vezu sa bazom";
        testConnectionButton.UseVisualStyleBackColor = true;
        testConnectionButton.Click += TestConnectionButton_Click;

        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 150);
        Controls.Add(testConnectionButton);
        Controls.Add(informationLabel);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Fluent NHibernate Template";
        ResumeLayout(false);
        PerformLayout();
    }
}
