using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;


            //koop 2 controllers
            controllersInMandje += 2;


            //hij is in voorraad snel kopen!
            int ps5 = 0;

            ps5++;

            //koop 1 ps5


            //koop de games:

            int eldenRing = 0;
            eldenRing++;

            int shantae = 0;
            shantae++;

            int spongebob = 0;
            spongebob++;


            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1
            spongebob--;
            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gameprijs = 59.99;


            double totaalControllerPrijs = 0;// controllersInMandje keer controllerPrijs
            totaalControllerPrijs = controllersInMandje * controllerPrijs;
            double gamePrijs = 0;// game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)
            gamePrijs = (eldenRing * gameprijs) + (shantae * gameprijs);



            double totaalPrijs = 0;// tel hier alles bij elkaar op
            totaalPrijs = totaalControllerPrijs + ps5Prijs + gamePrijs;

            //er moet nu 759.95 staan
            Console.WriteLine(totaalPrijs);
        }
    }
}