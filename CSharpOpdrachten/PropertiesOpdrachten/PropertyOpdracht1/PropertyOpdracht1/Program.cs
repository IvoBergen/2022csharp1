using System;

namespace PropertyOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persoon persoon = new Persoon();

            persoon.Naam = "Nigeria" ;//maak deze string aan als property in persoon, gebruik get set
            persoon.Leeftijd = 62 ;//maak deze int aan als property in persoon, gebruik get set
        }
    }
}