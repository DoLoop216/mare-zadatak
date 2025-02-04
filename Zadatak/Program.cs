using Zadatak;
List<Prodavnica> prodavnice = DatabaseHelpers.LoadProdavnice();

Console.WriteLine($"U gradu postoji {prodavnice.Count} prodavnice");
Console.WriteLine("Te prodavnice su:");
foreach (var prodavnica in prodavnice)
{
    prodavnica.IspisiOsnovnePodatke();
}

Helpers.IspisiPodatkeProdavniceSaNajviseZaposlenih(prodavnice);
Helpers.IspisiPodatkeProdavniceSaNajvecomVrednoscuZaliha(prodavnice);
