namespace Ispit.Konzola.Sucelja
{
    internal interface ITelefon
    {

        public string Model { get;}

        internal string Poziv(string telefonski_broj);

    }
}
