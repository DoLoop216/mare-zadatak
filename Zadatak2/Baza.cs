namespace Zadatak2;

public static class Baza
{
    public static List<Osoba> Partneri { get; set; } = new List<Osoba>();

    public static void InicijalizujBazu()
    {
        for(int i = 0; i < 10; i++)
        {
            Partneri.Add(new Osoba
            {
                Ime = "Osoba" + i,
                Prezime = "Prezime" + i,
                Godiste = 1990 + i
            });
        }
    }
}