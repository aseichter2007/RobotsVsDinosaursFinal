using System;
using System.Collections.Generic;
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
            Species = DinoBreed(random);
            this.random = random;
            health = DinoHealth(random);
            attackpower = PowerAttack();
            energy = DinoEnergy(random);

        }
        public string DinoBreed(Random random)
        {
            List<string> species = new List<string>()  { "t-rex", "Hillary Clinton", "mosasaurus", "velociraptor", "utahraptor", "triceratops", "pachycephalosaurus", "allosaurus", "Carnotorus", "Long Neck", "Spinosaurus", "baryonyx", "fire wevyrn", "lightning wevyrn", "gigantosaurus", "iguanodon", "ankylosaur"};

            string dino;
            int egg = random.Next(0, species.Count);
            return dino = species[egg];

        }
        public string[] DinoAttack()
        {
            List<string> attack = new List<string>() { "fire breath", "tail whip", "quick attack", "hyper beam", "scratch", " bite" };

            int strike = random.Next(0, attack.Count - 1);// is this right? or will straight count overflow?
            int damage = random.Next(0, 500);
            damage = damage * attackpower;
            string[] attacking = new string[] { attack[strike], damage.ToString() };
            return attacking;
        }
        public int DinoHealth(Random random)
        {
            int health = random.Next(1, 10000);
            return health;
        }
        public int DinoEnergy(Random random)
        {
            int pwr = random.Next(1, 20000);
            return pwr;
        }
        public int PowerAttack()
        {
            int pwr = random.Next(1, 3);
            return pwr;
        }

    }
}
