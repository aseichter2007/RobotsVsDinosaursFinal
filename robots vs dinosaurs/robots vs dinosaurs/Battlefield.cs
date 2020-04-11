using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Schema;

namespace robots_vs_dinosaurs
{
    class Battlefield
    {
        public int robots =3;
        public int dinos =3;
        public Random random;
        public bool fancy = false;
        public Fleet fleet;
        public Herd  herd;
        public asciiart asciiart;
        
        public Battlefield(string[] bodycount, Random random, bool fancy)
        {
            this.robots = Convert.ToInt32(bodycount[0]);
            this.dinos = Convert.ToInt32(bodycount[1]);
            this.random = random;
            fleet = new Fleet(robots,random);
            herd = new Herd(dinos, random);
            this.fancy = fancy;
            this.asciiart = new asciiart();

        }
        public void Round1Fight()
        {
            int countR = 0;
            int countD = 0;
            fleet.CreateBots(random,robots);
            herd.Breed(dinos,random);
            while (fleet.robotList.Count > 0 && herd.dinoList.Count > 0)
            {
                if (countR < fleet.robotList.Count && countD < herd.dinoList.Count)
                {
                    RobotAttack(countR);
                    DinoAttack(countD);
                    countR++;
                    countD++;
                }
                else if (countR >= fleet.robotList.Count && countD < herd.dinoList.Count)
                {
                    DinoAttack(countD);
                    countD++;
                }
                else if (countD >= herd.dinoList.Count && countR < fleet.robotList.Count)
                {
                    RobotAttack(countR);
                    countR++;
                }
                else
                {
                    countR = 0;
                    countD = 0;
                }
                if (fancy == true)
                {
                    Thread.Sleep(1000);
                }
            }
            if (herd.dinoList.Count > fleet.robotList.Count)
            {
                Console.WriteLine("dinosaurs win");
            }
            else if (fleet.robotList.Count > herd.dinoList.Count)
            {
                Console.WriteLine("robots win");
            }

        }
        public void RobotAttack(int R)
        {
            int target = 0;
            string[] gettack = fleet.robotList[R].RoboAttack();
            if(fleet.robotList.Count != R)
            if (fancy == true)
            {
                asciiart.PrintAsciiArt("R");
            }
            if (fleet.robotList[R].power > 100)
            {
                fleet.robotList[R].power -= 100;
                if(herd.dinoList.Count > 1)
                {
                   target = (random.Next(1, herd.dinoList.Count - 1))-1;
                }
                Console.WriteLine(fleet.robotList[R].model + " is attacking " + herd.dinoList[target].Species + " with it's " + gettack[0] + " for " + gettack[1] + " damage.");
                herd.dinoList[target].health -= Convert.ToInt32(gettack[1]);
                if (herd.dinoList[target].health > 0)
                {
                    Console.WriteLine(herd.dinoList[target].Species + " has " + herd.dinoList[target].health + " health reamaining.");
                }
                else
                {
                    Console.WriteLine(herd.dinoList[target].Species + " has died.");
                    herd.dinoList.RemoveAt(target);
                    herd.dinoList.TrimExcess();
                    Console.WriteLine("there are " + herd.dinoList.Count + " dinosaurs left.");
                }
            }
            else
            {
                Console.WriteLine(fleet.robotList[R].model + " can't charge up its lazor.");
                fleet.robotList[R].power += 20;
            }

        }
        public void DinoAttack(int D)
        {
            int target = 0;
            string[] gettack = new string[2];
            if (herd.dinoList.Count != D)
            {

                gettack = herd.dinoList[D].DinoAttack();
                if (fancy == true)
                {
                    asciiart.PrintAsciiArt("D");
                }
                if (herd.dinoList[D].energy > 100)
                {
                    herd.dinoList[D].energy -= 100;
                    if (fleet.robotList.Count > 1)
                    {
                        target = (random.Next(1, fleet.robotList.Count - 1)) - 1;
                    }
                    Console.WriteLine(herd.dinoList[D].Species + " is attacking " + fleet.robotList[target].model + " with it's " + gettack[0] + " for " + gettack[1] + " damage.");
                    fleet.robotList[target].health -= Convert.ToInt32(gettack[1]);
                    if (fleet.robotList[target].health > 0)
                    {
                        Console.WriteLine(fleet.robotList[target].model + " has " + fleet.robotList[target].health + " health reamaining.");
                    }
                    else
                    {
                        Console.WriteLine(fleet.robotList[target].model + " has stopped functioning.");
                        fleet.robotList.RemoveAt(target);
                        fleet.robotList.TrimExcess();
                        Console.WriteLine("there are " + fleet.robotList.Count + " robots left.");
                    }
                }
                else
                {
                    Console.WriteLine(herd.dinoList[D].Species + " is too tired to fight");
                    herd.dinoList[D].energy += 20;
                }
            }
        }
        public void ChooseOpponent()
        {

        }
    }
}
