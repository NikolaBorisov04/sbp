namespace FluentNHibernateTemplate.Entiteti;

public class KorisnikUloga : IEquatable<KorisnikUloga>
{
    public virtual Korisnik Korisnik { get; set; } = null!;
    public virtual Uloga Uloga { get; set; } = null!;

    public virtual bool Equals(KorisnikUloga? other)
    {
        if (ReferenceEquals(this, other))
            return true;
        if (other is null)
            return false;

        int korisnikId = Korisnik?.Id ?? 0;
        int ulogaId = Uloga?.Id ?? 0;

        int otherKorisnikId = other.Korisnik?.Id ?? 0;
        int otherUlogaId = other.Uloga?.Id ?? 0;

        return korisnikId == otherKorisnikId &&
               ulogaId == otherUlogaId;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as KorisnikUloga);
    }
    public override int GetHashCode()
    {
        int korisnikId = Korisnik?.Id ?? 0;
        int ulogaId = Uloga?.Id ?? 0;

        return HashCode.Combine(korisnikId, ulogaId);
    }
}