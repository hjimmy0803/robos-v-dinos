using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaurs_V_Robots
{
    class Herd
    {
        public double herdHealth = 1575;
        public double herdAttakPower = 490;
        public double herdEnergyPower= 165;
        public List<Dinosaur> DinoList;
        public void GetDinosaurInit() {
            DinoList = new List<Dinosaur>()
            {
                new Dinosaur("Raptor",115,500,40),
                new Dinosaur("T-Rex",130,550,50),
                new Dinosaur("Triceratops",125,600,45),
                new Dinosaur("Baryonyx",120,400,30),
            };
            for (int i = 0; i < DinoList.Count; i++)
            {
                Console.WriteLine("" + DinoList[i].dinoType);
                
            }
            Console.ReadLine();
        }
    }
}
