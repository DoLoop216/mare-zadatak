using Zadatak;
List<Prodavnica> prodavnice = DatabaseHelpers.LoadProdavnice();

Console.WriteLine("U gradu postoji 3 prodavnice"); // TODO: Netacno, zameni 3 sa onoliko prodavnica koliko postoji u objektu "prodavnice"
Console.WriteLine("Te prodavnice su:");
foreach (var prodavnica in prodavnice)
{
    prodavnica.IspisiOsnovnePodatke();
}

// TODO: Ispisi podatke prodavnice sa najvise zaposlenih koristeci IspisiPodatkeProdavniceSaNajviseZaposlenih metodu iz klase Helpers
// TODO: Ispisi podatke prodavnice sa najvecom ukupnom vrednoscu zaliha koristeci IspisiPodatkeProdavniceSaNajvecomVrednoscuZaliha metodu iz klase Helpers
