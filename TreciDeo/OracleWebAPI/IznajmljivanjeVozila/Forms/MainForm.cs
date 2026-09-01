using FluentNHibernate.Utils;
using FluentNHibernateTemplate.Entiteti;
using FluentNHibernateTemplate.Forms;

namespace FluentNHibernateTemplate;

/// <summary>
/// Main application form.
/// Replace the placeholder UI with the forms required by your project's theme.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        VoznjeForm f = new VoznjeForm();
        this.Hide();
        f.ShowDialog();
        this.Show();
    }

    private void btnVozila_Click(object sender, EventArgs e)
    {
        VozilaForm f = new();
        this.Hide();
        f.ShowDialog();
        this.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        RezervacijeForm f = new RezervacijeForm();
        this.Hide();
        f.ShowDialog();
        this.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        KorisniciForm f = new();
        this.Hide();
        f.ShowDialog();
        this.Show();
    }
}
