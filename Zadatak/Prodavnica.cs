namespace Zadatak;

public class Prodavnica
{
    public string Naziv { get; set; }
    public string Adresa { get; set; }
    public List<Proizvod> Prozivodi { get; set; }
    public List<Osoba> Zaposleni { get; set; }

    public void IspisiOsnovnePodatke()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("Naziv: " + Naziv);
        Console.WriteLine("Adresa: " + Adresa);
        Console.WriteLine("Broj proizvoda: " + Prozivodi.Count);
        Console.WriteLine("Broj zaposlenih: " + Zaposleni.Count);
        Console.WriteLine("===================================");
    }
}