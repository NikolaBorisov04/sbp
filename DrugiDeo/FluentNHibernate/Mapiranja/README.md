# Mapiranja

Za svaki entitet napravite Fluent NHibernate mapiranje.

Minimalni oblik:

```csharp
public class EntitetAMapiranje : ClassMap<EntitetA>
{
    public EntitetAMapiranje()
    {
        Table("TABELA_A");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv, "NAZIV");
        // Ostala Map(...) svojstva...
    }
}
```

`DataLayer` automatski traži mapiranja u ovoj aplikaciji, preko `MappingAssemblyMarker` klase.

Ako koristite drugi način generisanja ključa, promenite `GeneratedBy...` prema vašoj Oracle šemi.
