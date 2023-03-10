using System;

namespace ClassOpdracht1 //Namespace
{
     
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise//Class
    {
        private readonly string accountName; //String

        internal ClassStructureExercise(string accountName) //Function
        {
            this.accountName = accountName; //Variable
        }

        internal void ShowGreetingInConsole() //Function
        {
            string greeting = "hello"; //String Variable
            Console.WriteLine(greeting + " " + accountName); //Console comand 
        }

        internal void Show1To10() //Function
        {
            for (int i = 0; i < 10; i++) // For Statement 
            {
                Console.WriteLine(i.ToString()); //Console Comand
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2) //Function
        {

            int dx = x2 - x1; //Variable
            int dy = y2 - y1; //Variable

            double lengthSquared = (dx * dx) + (dy * dy); //Variable

            double length = Math.Sqrt(lengthSquared); //Variable
            return length; //Return

        }
        internal int MultiplyToPower2(int value) //Function
        {
            int result = value * value; //Variable
            return result; // Return
        }


        static void Main(string[] args) //Function
        {
            Console.WriteLine("Hello, World!"); //Console Comand

        }
    }
}