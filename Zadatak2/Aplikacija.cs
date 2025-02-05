namespace Zadatak2;

public static class Aplikacija
{
    public static void Start()
    {
        Baza.InicijalizujBazu();

        foreach (Osoba partner in Baza.Partneri)
        {
            Console.WriteLine("Osoba: " + partner.Ime + " " + partner.Prezime + " (" + partner + ")");
        }
    }
}