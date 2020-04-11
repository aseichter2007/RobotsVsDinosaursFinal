using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{
    class Herd
    {
        public int dinosaurs;
        public Random random;
        public List<Dinosaur> dinoList;
        public Herd(int dinocount, Random random)
        {
            dinosaurs = dinocount;
            this.random = random;
            dinoList = new List<Dinosaur>();
            
        }
        public void Breed(int count, Random random)

        {
            for(int i = 0; i < count; i++)
            {

                Dinosaur dinosaur = new Dinosaur(random);
                dinoList.Add(dinosaur);
            }
        }
           
    }
}
