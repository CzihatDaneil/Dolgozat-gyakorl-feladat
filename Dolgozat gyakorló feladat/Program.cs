using System.IO;
using Dolgozat_gyakorló_feladat;

List<Eszkoz> eszkozok = new List<Eszkoz>();
if (!File.Exists("eszkozok.txt"))
{
    Console.WriteLine("A fájl nem található.");
    return;
}
else {
    string[] sorok = File.ReadAllLines("eszkozok.txt");

    foreach (string sor in sorok)
    {
        if (string.IsNullOrWhiteSpace(sor))
        {
            continue;
        }
        string[] adatok = sor.Split(';');
        if (adatok.Length < 4)
        {
            continue;
        }
        string azonosito = adatok[0];
        string nev = adatok[1];
        string kategoria = adatok[2];
        if(adatok.Length == 4)
        {
            if (int.TryParse(adatok[3], out int napiDij))
            {
                eszkozok.Add(new Eszkoz(adatok[0], adatok[1], adatok[2], adatok[3]));
            }
        }
    }    
}
foreach (var a in eszkozok)
{
    Console.WriteLine(a.ToString());
}
//Console.WriteLine($"Regisztrált eszközök száma a rendszerben: {Eszkoz.OsszesRegisztraltEszkoz} db");
//int teljesNapiBevetel = 0;

//foreach (Eszkoz b in eszkozok)
//{
//    teljesNapiBevetel += b.TeljesNapiBevetel();
//}

//Console.WriteLine($"Teljes eszközpark 1 napi bevétele: {teljesNapiBevetel} Ft");


//Eszkoz legdragabb = eszkozok[0];

//foreach (Eszkoz c in eszkozok)
//{
//    if (c.NapiDij > legdragabb.NapiDij)
//    {
//        legdragabb = c;
//    }
//}

//double tizenNaposDij = KoltsegKalkulator.BérletiDijKedvezmennyel(legdragabb.NapiDij, 10);
//Console.WriteLine($"Legdrágább napi díjú eszköz: {legdragabb.Nev} ({legdragabb.NapiDij} Ft/nap)");
//Console.WriteLine($"10 napos bérleti díja (15% kedvezménnyel): {tizenNaposDij} Ft");


//Eszkoz legnagyobbKeszletu = eszkozok[0];

//foreach (Eszkoz e in eszkozok)
//{
//    if (e.Keszlet > legnagyobbKeszletu.Keszlet)
//    {
//        legnagyobbKeszletu = e;
//    }
//}

//Console.WriteLine($"Legnagyobb készlettel rendelkező eszköz: {legnagyobbKeszletu.Nev} ({legnagyobbKeszletu.Keszlet} db)");