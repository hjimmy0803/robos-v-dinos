using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaurs_V_Robots
{
    class Robot
    {
        public string robotName;
        public double robotHealth;
        public double robotPowerLevel;
        public Weapon weapon;


        public Robot(string robotName, double robotHealth, double robotPowerLevel, Weapon weapon) {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.weapon = weapon;
        }

        
    }


    
}
