using System.Runtime.CompilerServices;
using Ispit.Konzola.Models;
using Ispit.Konzola.Sucelja;

namespace Ispit.Konzola;

internal class Program
{
    public delegate void TelefonDelegate(PametniTelefon telefon);

    static void Main(string[] args)
    {
        PametniTelefon telefon = new PametniTelefon("Nokia");

        telefon.TelefonKreiran += Telefon_TelefonKreiran;

    }

    private static void Telefon_TelefonKreiran(PametniTelefon telefon)
    {
        //nekako kreirati IPametniTelefon i proslijediti ga u TestirajTelefon
        TestirajTelefon(telefon);
    }

    public void TestirajTelefon(IPametniTelefon telefon)
    {


        Console.WriteLine("Koji broj da zovem? ");
        var broj = Console.ReadLine();
        telefon.Poziv(broj);
        Console.WriteLine("Koju web stranicu da posjetim? ");
        var url = Console.ReadLine();
        telefon.Surfaj(url);
    }

}