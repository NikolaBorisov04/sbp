namespace FluentNHibernateTemplate.Entiteti;

public class Oprema
{
    public virtual int Id { get; set; }

    public virtual string Naziv { get; set; } = null!;

    public virtual string? Opis { get; set; }

    public virtual IList<VoziloOprema> Vozila { get; set; } = new List<VoziloOprema>();
}
