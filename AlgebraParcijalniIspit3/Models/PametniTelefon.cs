using Ispit.Konzola.Sucelja;
using System;
using System.Numerics;

namespace Ispit.Konzola.Models
{
    internal class PametniTelefon : IPametniTelefon
    {
        public delegate void TelefonKreiranDelegate(PametniTelefon telefon);

        public event TelefonKreiranDelegate TelefonKreiran;


        public string Model { get; private set; }

        public PametniTelefon(string model)
        {
            Model = model;
            TelefonKreiran.Invoke(this); //nema kaj pozvat jer nije suban i šalje krivi objekt
        }

        public string Poziv(string telefonski_broj)
        {
            try
            {
                ProvjeriAkoJeValidanBroj(telefonski_broj);
            }
            catch
            {
                return "Neispravan telefonski broj!";
            }

            return $"Evo zovem...{telefonski_broj}";
        }

        public string Surfaj(string url)
        {
            try
            {
                ProvjeriAkoJeValidanUrl(url);
            }
            catch
            {
                return "Neispravan url!";
            }

            return $"Surfam na {url}";
        }

        internal bool ProvjeriAkoJeValidanUrl(string url)
        {
            var znakovi = url.ToCharArray();
            foreach (var c in znakovi)
            {
                if(char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }

        internal bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            var znakovi = telefonski_broj.ToCharArray();
            foreach (var c in znakovi)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
