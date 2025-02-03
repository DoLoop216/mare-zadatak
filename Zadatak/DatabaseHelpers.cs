using Bogus;
using Newtonsoft.Json;

namespace Zadatak;

public static class DatabaseHelpers
{
    private static Faker<Kategorija> _kategorijaFaker = new Faker<Kategorija>()
        .StrictMode(true)
        .RuleFor(x => x.Naziv, f => f.Commerce.Categories(1)[0]);
    
    private static Faker<Osoba> _osobaFaker = new Faker<Osoba>()
        .StrictMode(true)
        .RuleFor(x => x.Ime, f => f.Person.FirstName)
        .RuleFor(x => x.Prezime, f => f.Person.LastName);
    
    private static Faker<Proizvod> _proizvodFaker = new Faker<Proizvod>()
        .StrictMode(true)
        .RuleFor(x => x.Naziv, f => f.Commerce.ProductName())
        .RuleFor(x => x.Cena, f => f.Random.Double(1, 1000))
        .RuleFor(x => x.KataloskiBroj, f => f.Commerce.Ean13())
        .RuleFor(x => x.KolicinaNaZalihama, f => f.Random.Number(1, 100))
        .RuleFor(x => x.Kategorije, f => _kategorijaFaker.Generate(f.Random.Number(1, 5)));
    
    private static Faker<Prodavnica> _prodavnicaFaker = new Faker<Prodavnica>()
        .StrictMode(true)
        .RuleFor(x => x.Naziv, f => f.Company.CompanyName())
        .RuleFor(x => x.Adresa, f => f.Address.FullAddress())
        .RuleFor(x => x.Prozivodi, f => _proizvodFaker.Generate(f.Random.Number(1, 100)))
        .RuleFor(x => x.Zaposleni, f => _osobaFaker.Generate(f.Random.Number(1, 10)));
    

    public static List<Prodavnica> LoadProdavnice()
    {
        return JsonConvert.DeserializeObject<List<Prodavnica>>(JsonConvert.SerializeObject(_prodavnicaFaker.Generate(System.Random.Shared.Next(3, 10))))!;
    }
}