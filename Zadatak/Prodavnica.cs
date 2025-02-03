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
        // TODO: Ispisi
        // Naziv:
        // Adresa:
        // Broj proizvoda:
        // Broj zaposlenih:
        Console.WriteLine("===================================");
    }
}