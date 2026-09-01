namespace FluentNHibernateTemplate.Entiteti;

public class VoziloOprema : IEquatable<VoziloOprema>
{
    public virtual Vozilo Vozilo { get; set; } = null!;

    public virtual Oprema Oprema { get; set; } = null!;

    public virtual bool IsDodatna { get; set; }

    public virtual bool Equals(VoziloOprema? other)
    {
        if (ReferenceEquals(this, other))
            return true;

        if (other is null)
            return false;

        int voziloId = Vozilo?.Id ?? 0;
        int opremaId = Oprema?.Id ?? 0;

        int otherVoziloId = other.Vozilo?.Id ?? 0;
        int otherOpremaId = other.Oprema?.Id ?? 0;

        return voziloId == otherVoziloId &&
               opremaId == otherOpremaId;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as VoziloOprema);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(
            Vozilo?.Id ?? 0,
            Oprema?.Id ?? 0
        );
    }
}