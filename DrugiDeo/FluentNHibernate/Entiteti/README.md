# Entiteti

Ovde dodajte klase koje predstavljaju tabele/entitete vaše teme.

Primer strukture (samo ilustracija):

- EntitetA.cs
- EntitetB.cs
- EntitetC.cs

Preporuka:
- svojstva treba da budu `virtual` zbog NHibernate-a;
- primarni ključ tipično ima `protected set`;
- nazivi svojstava treba da odgovaraju vašem domenskom modelu, a ne nužno imenima kolona u bazi;
- za svaku konkretnu temu napravite samo entitete koji su vam potrebni.
