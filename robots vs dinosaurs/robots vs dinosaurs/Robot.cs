using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{
    class Robot
    {
        public string model;
        public int power;
        public int health;
        Weapon Weapon;
        Random random;
        public Robot(Random random,string model)
        {
            this.model = model;
            this.random = random;
            this.Weapon = new Weapon(random);
            this.health = RoboHeatlh();
            power = RoboPwr();
        }
        public int RoboHeatlh()
        {
            int hp = random.Next(1, 12000);
            return hp;
        }
        public int RoboPwr()
        {
            int pwr = random.Next(1, 10000);
            return pwr;
        }
        public string [] RoboAttack()
        {
            
            int attack = this.Weapon.damage;
            string weapon = this.Weapon.weapon;
            string damage = attack.ToString();
            string[] attacking = new string[2] {weapon, damage };
            return attacking;
        }
    }
}
