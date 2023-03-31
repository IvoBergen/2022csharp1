namespace PropertyOpdracht1
{
    internal class Hond
    {
        //maak hier een property Naam, de set moet private zijn!
        public string Naam { get; private set; }
        public Hond(string naam)
        {
            this.Naam = naam;
        }

    }
}