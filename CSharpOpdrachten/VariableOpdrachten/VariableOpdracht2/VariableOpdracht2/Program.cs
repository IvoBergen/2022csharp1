using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        private static Game GetV()
        {
            return 'hello';
        }

        //class variables & gebruik
        static void Main(Game Mario)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
             twitchStream.name = "SmallAnt";
            //lastStreamName, waarde: de streamname van de laatste keer
            twitchStream.lastStreamName = "Hide n' seek with friends";
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            twitchStream.StreamGame = Mario;
            //followers, waarde: hoeveel followers
            twitchStream.followers = 1800000;
            //automod, waarde: staat automod aan?
            twitchStream.automod = true;
            

            Console.WriteLine("Hello, World!");
            Console.WriteLine(twitchStream);
        }
    }
}