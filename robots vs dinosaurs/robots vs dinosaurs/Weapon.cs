using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{
    class Weapon
    {
        string weapon;
        int damage;
        Random random = new Random();

        public Weapon()
        {
            this.weapon = WeaponRoulette();
            this.damage = weaponQuality();
        }
        public string WeaponRoulette()
        {
            string[] arsenal = new string[6] { "tazer", "sword", "sawblade", "machinegun", "minigun", "raygun" };

            int randweapon =random.Next(0, 6);
            return weapon = arsenal[randweapon];

        }
        public int weaponQuality()
        {
            int weaponPower = random.Next(1, 1000);
            return weaponPower;
        }
    }
}
