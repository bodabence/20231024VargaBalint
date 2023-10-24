using _20231024VargaBalint;
using System.Text;

List<Solsys> lista = new List<Solsys>();
var sr = new StreamReader(
    path: @"..\..\..\src\solsys.txt",
    encoding: Encoding.UTF8);
while (!sr.EndOfStream) lista.Add(new Solsys(sr.ReadLine()));
sr.Close();
var f3 = lista.Count;

var maxTerfogat = lista.Max(x => x.Arany);
var jupiter = lista.Where(x => x.Arany == maxTerfogat).ToList().First();

Console.WriteLine($"3.feladat: \n 3.1: {f3} bolygó van a naprendszerben \n 3.2: a naprendszerben egy bolygónak átlagosan {lista.Average(x => x.HoldSzam)} holdja van \n 3.3 A legnagyobb térfogatú bolygó a {jupiter.BolygoNev} \n ");
Console.ReadLine();
Console.Write("3.4 Írd be a keresett bolygó nevét:");
var keresett = Console.ReadLine();
var f4 = lista.Any(x => x.BolygoNev.ToLower() == keresett.ToLower());
Console.WriteLine(f4 ? "Van ilyen bolgyó a naprendszerben" : "Sajnos nincs lyen nevű bolgyó a naprendszerben");
Console.ReadLine();
Console.Write("3.5 Írj be egy eglsz számot: ");
var egeszSzam =  int.Parse(Console.ReadLine());
Console.WriteLine($"A következő bolgyóknak van {egeszSzam}-nál/nél több holdja");

foreach (var x in lista)
{
    if (x.HoldSzam > egeszSzam)
    {
        Console.Write($"['{x.BolygoNev}'],");

    }

}