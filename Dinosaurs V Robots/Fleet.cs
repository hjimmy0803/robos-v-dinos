using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaurs_V_Robots
{
    class Fleet
    {
        public double fleetHealth = 2150;
        public double fleetAttackPower = 445;
        public List<Robot> WarriorList;
        public void GetFleetInit()
        {
            WarriorList = new List<Robot>() {
                new Robot("Cyborg", 500, 45, new Weapon(" Ion Blaster ", 100)),
                new Robot(" Star Scream ", 500, 60, new Weapon(" Sword ", 100)),
                new Robot(" Killbot ", 550, 70, new Weapon(" Big Cannon ", 120)),
                new Robot(" Disruptor ", 600, 75, new Weapon(" Grenade Launcher ", 125))
            };

            for (int i = 0; i < WarriorList.Count; i++)
            {
                Console.WriteLine($"{i} {WarriorList[i].robotName} uses a {WarriorList[i].weapon.weaponType} ");
            }
            Console.ReadLine();
        }
    }
}













