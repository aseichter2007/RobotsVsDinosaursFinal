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


            Random random = new Random();
            Console.WriteLine("do it fancy?");
            string fancy = Console.ReadLine();
            bool veryFancy = false;
            string[] bodyCount = new string[2] { "3", "3" };
            if (fancy == "yes" || fancy == "y" || fancy == "sure")
            {
                Console.WriteLine("how many robots and dinos?");
                Console.WriteLine("theoretical max count each 2,147,483,647 ");
                Console.WriteLine("but I run out of addressable memory just over 30 million");
                Console.WriteLine("robots 'enter' dinos, no commas please");
                bodyCount = new string[2] { Console.ReadLine(), Console.ReadLine() };
                //Console.WriteLine(bodycount[0] + bodycount[1]);
                Console.WriteLine("How fancy do you want it?");
                string sofancy = Console.ReadLine();
                if (sofancy == "very" || sofancy == "fancy" || sofancy == "very fancy")
                {
                    Console.WriteLine("Are you sure you can handle it?");
                    string iCantHandleIt = Console.ReadLine();
                    if (iCantHandleIt == "yes")
                    {
                        veryFancy = true;
                    }

                    //Console.WriteLine(bodyCount[0] + bodyCount[1]);
                }

            }
                      
            Battlefield battlefield = new Battlefield(bodyCount, random, veryFancy);

            battlefield.Round1Fight();

        }
    }
}
