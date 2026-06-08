using Ispit.Model.Klase;

namespace Ispit.Model
{
    public class Podaci
    {
        public static List<Banka> ListaBanki = new()
        {
            new Banka {Simbol = "DALI", Naziv = "Dalić banka" },
            new Banka() {Simbol = "MODRI", Naziv = "Modrić banka"},
            new Banka() {Simbol = "MAMINJO", Naziv = "Mamić banka"},
            new Banka() {Simbol = "ŠUKER", Naziv = "Šuker banka"}
        };

        public static List<Klijent> ListaKlijenata = new()
        {
            new Klijent {ImePrezime = "Zvonimir Boban", Banka = "ŠUKER", Stanje = 500000},
            new Klijent {ImePrezime = "Davor Šuker", Banka = "ŠUKER", Stanje = 9000000},            //milijunaš
            new Klijent {ImePrezime = "Luka Modrić", Banka = "MODRI", Stanje = 3000000},            //milijunaš
            new Klijent {ImePrezime = "Zlatko Dalić", Banka = "DALI", Stanje = 10000000},           //milijunaš
            new Klijent {ImePrezime = "Zlatan Ibrahimović", Banka = "MAMINJO", Stanje = 2000000},   //milijunaš
            new Klijent {ImePrezime = "Mario Mandžukić", Banka = "MAMINJO", Stanje = 15000000},     //milijunaš
            new Klijent {ImePrezime = "Ivan Perišić", Banka = "MODRI", Stanje = 850000},
            new Klijent {ImePrezime = "Dino Perišić", Banka = "MODRI", Stanje = 150000},
            new Klijent {ImePrezime = "Ante Rebić", Banka = "DALI", Stanje = 250000},
            new Klijent {ImePrezime = "Dejan Lovren", Banka = "ŠUKER", Stanje = 720000}
        };
    }
}
