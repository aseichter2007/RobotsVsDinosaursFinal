using System;
using System.Runtime.CompilerServices;

namespace robots_vs_dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("do it fancy?");
            string fancy = Console.ReadLine();
            bool veryFancy = false;
            string[] bodyCount = new string[2] { "3", "3" };
            if (fancy == "yes" || fancy == "y" || fancy == "sure")
            {
                Console.WriteLine("how many robots and dinos?");
                Console.WriteLine("max count each 9999999999999999999999999");
                Console.WriteLine("robots 'enter' dinos");
                bodyCount = new string[2] { Console.ReadLine(), Console.ReadLine() };
                //Console.WriteLine(bodycount[0] + boltcount[1]);
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

                    Console.WriteLine(bodyCount[0] + bodyCount[1]);
                }

            }
                      
            Battlefield battlefield = new Battlefield(bodyCount, random, veryFancy);

            //Battlefield.Round1Fight();
         
        }
    }
}
