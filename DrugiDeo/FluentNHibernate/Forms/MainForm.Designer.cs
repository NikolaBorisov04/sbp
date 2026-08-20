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
        // btnVozila
        // 
        btnVozila = new Button();
        btnVozila.Location = new Point(12, 160);
        btnVozila.Name = "btnVozila";
        btnVozila.Size = new Size(217, 46);
        btnVozila.TabIndex = 4;
        btnVozila.Text = "Upravljanje Vozilima";
        btnVozila.UseVisualStyleBackColor = true;
        btnVozila.Click += btnVozila_Click;
        // 
        // btnServisi
        // 
        btnServisi = new Button();
        btnServisi.Location = new Point(260, 160);
        btnServisi.Name = "btnServisi";
        btnServisi.Size = new Size(217, 46);
        btnServisi.TabIndex = 5;
        btnServisi.Text = "Evidencija Servisa";
        btnServisi.UseVisualStyleBackColor = true;
        btnServisi.Click += btnServisi_Click;
        // 
        // btnKvarovi
        // 
        btnKvarovi = new Button();
        btnKvarovi.Location = new Point(12, 230);
        btnKvarovi.Name = "btnKvarovi";
        btnKvarovi.Size = new Size(217, 46);
        btnKvarovi.TabIndex = 6;
        btnKvarovi.Text = "Evidencija Kvarova";
        btnKvarovi.UseVisualStyleBackColor = true;
        btnKvarovi.Click += btnKvarovi_Click;
        // 
        // btnPunjenja
        // 
        btnPunjenja = new Button();
        btnPunjenja.Location = new Point(260, 230);
        btnPunjenja.Name = "btnPunjenja";
        btnPunjenja.Size = new Size(217, 46);
        btnPunjenja.TabIndex = 7;
        btnPunjenja.Text = "Punjenja i Točenja";
        btnPunjenja.UseVisualStyleBackColor = true;
        btnPunjenja.Click += btnPunjenja_Click;
        // 
        // btnNezgode
        // 
        btnNezgode = new Button();
        btnNezgode.Location = new Point(12, 300);
        btnNezgode.Name = "btnNezgode";
        btnNezgode.Size = new Size(217, 46);
        btnNezgode.TabIndex = 8;
        btnNezgode.Text = "Nezgode i Štete";
        btnNezgode.UseVisualStyleBackColor = true;
        btnNezgode.Click += btnNezgode_Click;
        // 
        // btnOprema
        // 
        btnOprema = new Button();
        btnOprema.Location = new Point(260, 300);
        btnOprema.Name = "btnOprema";
        btnOprema.Size = new Size(217, 46);
        btnOprema.TabIndex = 9;
        btnOprema.Text = "Oprema Vozila";
        btnOprema.UseVisualStyleBackColor = true;
        btnOprema.Click += btnOprema_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(500, 380);
        Controls.Add(btnOprema);
        Controls.Add(btnNezgode);
        Controls.Add(btnPunjenja);
        Controls.Add(btnKvarovi);
        Controls.Add(btnServisi);
        Controls.Add(btnVozila);
        Controls.Add(button1);
        Controls.Add(UcitajVozilo);
        Controls.Add(testConnectionButton);
        Margin = new Padding(3, 4, 3, 4);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Iznajmljivanje Vozila";
        ResumeLayout(false);
    }
    private Button UcitajVozilo;
    private Button button1;
    private Button btnVozila;
    private Button btnServisi;
    private Button btnKvarovi;
    private Button btnPunjenja;
    private Button btnNezgode;
    private Button btnOprema;
}
