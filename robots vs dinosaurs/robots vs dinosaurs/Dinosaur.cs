using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace robots_vs_dinosaurs
{
    class Dinosaur
    {
        public string Species;
        public int energy;
        public int attackpower;
        public int health;
        Random random;

        public Dinosaur(Random random)
        {
            this.random = random;
            Species = DinoBreed();

            health = DinoHealth();
            attackpower = PowerAttack();
            energy = DinoEnergy();

        }
        public string DinoBreed()
        {
            List<string> species = new List<string>()  { "t-rex", "Betty White", "Queen Elizabeth", "mosasaurus", "velociraptor", "utahraptor", "triceratops", "pachycephalosaurus", "allosaurus", "carnotorus", "long Neck", "spinosaurus", "baryonyx", "fire wevyrn", "lightning wevyrn", "gigantosaurus", "iguanodon", "ankylosaur", "Littlefoot", "Ducky", "Peitree", "demogorgon"};

            string dino;
            int egg = random.Next(0, species.Count);
            return dino = species[egg];

        }
        public string[] DinoAttack()
        {
            List<string> attack = new List<string>() { "fire breath", "tail whip", "quick attack", "hyper beam", "scratch", " bite", "claw", "body slam", };

            int strike = random.Next(0, attack.Count - 1);// is this right? or will straight count overflow?
            int damage = random.Next(0, 700);
            damage = damage * attackpower;
            string[] attacking = new string[] { attack[strike], damage.ToString() };
            return attacking;
        }
        public int DinoHealth()
        {
            int health = random.Next(1, 10000);
            return health;
        }
        public int DinoEnergy()
        {
            int pwr = random.Next(1, 20000);
            return pwr;
        }
        public int PowerAttack()
        {
            int pwr = random.Next(1, 4);
            return pwr;
        }

    }
}
