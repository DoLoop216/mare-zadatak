using Zadatak3;

List<Biljka> biljke = new List<Biljka>();

Biljka biljka1 = new Biljka();
Biljka biljka2 = new Biljka();
Biljka biljka3 = new Biljka();
Biljka biljka4 = new Biljka();

biljka1.V = "Ruza";
biljka1.Dim = new Dimenzije { VisinaCm = 50, ObimCm = 30 };
biljka1.Lok = new Lokacija { Naziv = "Vrt" };

biljka2.V = "Tulipan";
biljka2.Dim = new Dimenzije { VisinaCm = 30, ObimCm = 20 };
biljka2.Lok = new Lokacija { Naziv = "Vrt" };

biljka3.V = "Jagoda";
biljka3.Dim = new Dimenzije { VisinaCm = 10, ObimCm = 15 };
biljka3.Lok = new Lokacija { Naziv = "Vrt" };

biljke.Add(biljka1);
biljke.Add(biljka2);
biljke.Add(biljka3);
biljke.Add(biljka4);

foreach (Biljka biljka in biljke)
{
    Console.WriteLine($"Biljka: {biljka.V}, Visina: {biljka.Dim}, Obim: {biljka.Dim.ObimCm}, Lokacija: {biljka.Lok.Naziv}");
}