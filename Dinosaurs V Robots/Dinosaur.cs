using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaurs_V_Robots
{
    class Dinosaur
    {
        public string dinoType;
        public double dinoAttackPower;
        public double dinoHealth;
        public double dinoEnergy;

        public Dinosaur(string dinoType, double dinoAttackPower,double dinoHealth,double dinoEnergy) {
            this.dinoType = dinoType;
            this.dinoAttackPower = dinoAttackPower;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
        }
    }
}
