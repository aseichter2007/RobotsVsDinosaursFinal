using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{
    class Battlefield
    {
        decimal robots=3;
        decimal dinos=3;
        Random random;
        bool fancy = false;
        
        public Battlefield(string[] bodycount, Random random, bool fancy)
        {
            this.robots = Convert.ToDecimal(bodycount[0]);
            this.dinos = Convert.ToDecimal(bodycount[1]);
            this.random = random;
            Fleet fleet = new Fleet(robots,random);
            Herd herd = new Herd(dinos, random);
            this.fancy = fancy;

        }
        public Battlefield(Random random)
        {
            this.random = random;
            Fleet fleet = new Fleet(robots, random);
            Herd herd = new Herd(dinos, random);
        }
    }
}
