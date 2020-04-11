using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{
    class Weapon
    {   
        
        public string weapon;
        public int damage;
        Random random;

        public Weapon(Random random)
        {
            this.random = random;
            this.weapon = WeaponRoulette(random);
            this.damage = weaponQuality(random);
        }
        public string WeaponRoulette(Random random)
        {
            string[] arsenal = new string[6] { "lazor", "sword", "sawblade", "machinegun", "minigun", "raygun" };

            int randweapon =random.Next(0, 5);
            return weapon = arsenal[randweapon];

        }
        public int weaponQuality(Random random)
        {
            int weaponPower = random.Next(1, 1000);
            return weaponPower;
        }
        
    }
}
