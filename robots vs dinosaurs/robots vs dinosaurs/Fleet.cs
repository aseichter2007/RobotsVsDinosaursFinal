using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{

    class Fleet
    {
        public int robots;
        public Random random;
        public List<Robot> robotList; 
        public Fleet(int robots, Random random)
        {
            this.robots = robots;
            this.random = random;
            robotList = new List<Robot>();
        }
        public void CreateBots()
        {
            List<string> robo = new List<string>() { "Assaultron", "Mechanaruto", "Mr. Handy", "Clippy", "HK47", "HK50", "Walt Disney", "Mechastreisand", "Megazord","R2D2", "protocol droid", "Robogodzilla", "Anna", "Teddy Ruxpin", "P90X", "Bigdog", "T-800", "T-1000", "Hillary Clinton", "Mark Zuckerberg", "Data", "Lore" };
            string model;
            int bolts=0;

            for (int i = 0; i < robots; i++)
            {
                bolts = random.Next(0, robo.Count - 1);// is this right? or will straight count overflow?
                model = robo[bolts];
                Robot robot = new Robot(random, model);
                robotList.Add(robot);

            }
        }

    }
}
