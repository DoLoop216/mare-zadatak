namespace Zadatak;

public static class Helpers
{
    public static void IspisiPodatkeProdavniceSaNajviseZaposlenih(List<Prodavnica> prodavnice)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("Prodavnica sa najvise zaposlenih");
        Prodavnica pSaNajviseZaposlenih = null;
        foreach (Prodavnica p in prodavnice)
        {
            if (pSaNajviseZaposlenih == null)
            {
                pSaNajviseZaposlenih = p;
                continue;
            }
            
            if (p.Zaposleni.Count > pSaNajviseZaposlenih.Zaposleni.Count)
            {
                pSaNajviseZaposlenih = p;
            }
        }

        Console.WriteLine($"Prodavnica {pSaNajviseZaposlenih.Naziv} ima najvise zaposlenih");
        Console.WriteLine("===================================");
    }
    
    public static void IspisiBrojZaposlenih(Prodavnica p)
    {
        Console.WriteLine($"Prodavnica {p.Naziv} ima {p.Zaposleni.Count} zaposlenih");
    }

    public static void IspisiPodatkeProdavniceSaNajvecomVrednoscuZaliha(List<Prodavnica> prodavnice)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("Prodavnica sa najvecom vrednoscu zaliha");
        Prodavnica pSaNajvecomVrednoscuZaliha = null;
        double poslednjeNajvece = 0;
        foreach (Prodavnica p in prodavnice)
        {
            if (pSaNajvecomVrednoscuZaliha == null)
            {
                pSaNajvecomVrednoscuZaliha = p;
                continue;
            }

            double ukupnaVrednostZaliha = 0;
            foreach (Proizvod proizvod in p.Prozivodi)
            {
                ukupnaVrednostZaliha = ukupnaVrednostZaliha + proizvod.UkupnaVrednostZaliha();
            }
            
            if(ukupnaVrednostZaliha > poslednjeNajvece)
            {
                pSaNajvecomVrednoscuZaliha = p;
                poslednjeNajvece = ukupnaVrednostZaliha;
            }
        }

        Console.WriteLine($"Prodavnica {pSaNajvecomVrednoscuZaliha.Naziv} ima najvecu vrednost zaliha ({poslednjeNajvece})");
        Console.WriteLine("===================================");
    }
}