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

    private void TestConnectionButton_Click(object sender, EventArgs e)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session == null)
                return;

            MessageBox.Show(
                "NHibernate session je uspešno kreiran. Veza sa bazom radi.",
                "Uspeh",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    private async void UcitajVozilo_Click(object sender, EventArgs e)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session == null)
                return;

            Vozilo? vozilo =
                await session.GetAsync<Vozilo>(1);

            if (vozilo == null)
            {
                MessageBox.Show("Vozilo sa ID 1 ne postoji.");
                return;
            }

            MessageBox.Show(
                $"Vozilo: {vozilo.Marka} {vozilo.Model}\n" +
                $"Registracija: {vozilo.RegistarskaOznaka}\n" +
                $"VIN: {vozilo.Vin}"
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.FormatExceptionMessage());
        }
        finally
        {
            session?.Close();
        }
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
}
