using Ispit.Model;
using Ispit.Model.Klase;

namespace Ispit.Konzola;

internal class Program
{
    static void Main(string[] args)
    {
        var GrupirajPremaBanci = Podaci.ListaBanki.GroupJoin(
            Podaci.ListaKlijenata,
            k => k.Simbol,
            b => b.Banka,
            (k, b) => new GrupiraniMilijunasi()
            {
                Banka = k.Simbol,
                Milijunasi = Podaci.ListaKlijenata
                    .Where(b => b.Banka == k.Simbol)
                    .Where(k => k.Stanje > 1000000).Select(k => k.ImePrezime)
            }).ToList();


        foreach (var g in GrupirajPremaBanci)
        {
            Console.WriteLine($"{g.Banka}: ");

            foreach(var m in g.Milijunasi)
            {
                Console.Write($"{m}\n");
            }
            Console.WriteLine();
        }

        var IzvjestajMilijunasa = Podaci.ListaKlijenata.Join(
            Podaci.ListaBanki,
            k => k.Banka,
            b => b.Simbol,
            (k, b) => new
            {
                ImeIPrezime = k.ImePrezime,
                Stanje = k.Stanje,
                NazivBanke = b.Naziv
            }
        )
            .Where(k => k.Stanje > 1000000)
            .ToList();

        foreach (var x in IzvjestajMilijunasa)
        {
            Console.WriteLine($"{x.ImeIPrezime} je u {x.NazivBanke}");

        }




    }
}
