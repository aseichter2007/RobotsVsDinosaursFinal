using System;
using System.Runtime.CompilerServices;

namespace robots_vs_dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Preface: The code in the program is deliberately ugly in many places.
            //I repeatedly broke standardization as a learning excercise.
            // the next complex program I write will be a lot neater and have some
            //constency in the way methods are implemented. 
            bool veryFancy = false;
            string soFancy = "";
            string[] bodyCount = new string[2] { "3", "3" };


            Random random = new Random();
            Console.WriteLine("Do it fancy?");
            string fancy = Console.ReadLine();            
            if (fancy == "yes" || fancy == "y" || fancy == "sure")
            {
                Console.WriteLine("how many robots and dinos?");
                Console.WriteLine("theoretical max count each 2,147,483,647 ");
                Console.WriteLine("but it runs out of addressable memory just over 35 million.");
                Console.WriteLine("robots 'enter' dinos, no commas please.");
                bodyCount = new string[2] { Console.ReadLine(), Console.ReadLine() };
                Console.WriteLine("How fancy do you want it?");
                soFancy = Console.ReadLine();
                if (soFancy == "very" || soFancy == "fancy" || soFancy == "very fancy" || soFancy == "v" || soFancy == "f" || soFancy == "Very" || soFancy == "Fancy" || soFancy == "Very Fancy")
                {
                    Console.WriteLine("Careful bro. Are you sure you can handle it?");
                    string iCantHandleIt = Console.ReadLine();
                    if (iCantHandleIt == "yes")
                    {
                        veryFancy = true;
                    }
                    else if ( iCantHandleIt == "y")
                    {
                        Console.WriteLine("Not enough conviction, I dont believe you. Maybe next time.");
                        Console.ReadLine();
                    }

                }
                if (Convert.ToInt32(bodyCount[0]) > 1000 || Convert.ToInt32(bodyCount[1]) > 1000)
                {
                    Console.WriteLine("Generating, please wait.");
                }

            }
            else
            {
                Console.WriteLine("Maybe just a little fancy?");
                soFancy = Console.ReadLine();
                if (soFancy == "y" || soFancy == "ok" || soFancy == "okay")
                {
                    veryFancy = true;
                }
            }




            Battlefield battlefield = new Battlefield(bodyCount, random, veryFancy);

            battlefield.Round1Fight();

        }
    }
}
