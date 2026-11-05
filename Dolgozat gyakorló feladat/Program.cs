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
    }    
}
foreach (var eszkoz in eszkozok)
{
    Console.WriteLine(eszkoz.ToString());
}
//Console.WriteLine($"Regisztrált eszközök száma a rendszerben: {Eszkoz.OsszesRegisztraltEszkoz} db");
//int teljesNapiBevetel = 0;

//foreach (Eszkoz i in eszkozok)
//{
//    teljesNapiBevetel += i.TeljesNapiBevetel();
//}

//Console.WriteLine($"Teljes eszközpark napi maximális bevétele: {teljesNapiBevetel} Ft");