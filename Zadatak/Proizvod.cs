namespace Zadatak;

public class Proizvod
{
    public string Naziv { get; set; }
    public double Cena { get; set; }
    public double KolicinaNaZalihama { get; set; }
    public string KataloskiBroj { get; set; }
    public List<Kategorija> Kategorije { get; set; }

    public double UkupnaVrednostZaliha()
    {
        return Cena * KolicinaNaZalihama;
    }
}