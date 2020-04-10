using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{
    class Robot
    {
        string model;
        int power;
        int health;
        Weapon Weapon;
        Random random;
        public Robot(Random random,string model)
        {
            this.model = model;
            this.random = random;
            this.Weapon = new Weapon();
            this.health = RoboHeatlh();
        }
        public int RoboHeatlh()
        {
            int hp = random.Next(1, 10000);
            return hp;
        }
        public int RoboPwr()
        {
            int pwr = random.Next(1, 10000);
            return pwr;
        }
    }
}
