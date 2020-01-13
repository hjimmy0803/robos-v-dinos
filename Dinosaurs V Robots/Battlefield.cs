using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinosaurs_V_Robots
{
    class Battlefield 
    {

        public string userInput;
        public string userSelection;
        public Fleet fleet = new Fleet();
        public Herd herd = new Herd();


        public void ManageGame() {
            GameInit();
        }
        public void GameInit() {
            Console.WriteLine(" Get Ready To Rumble ! Would you like to proceed ? Yes or No. ");
            userInput = Console.ReadLine().ToLower();
            UserOption();
        }

        public void DoBattle(Herd herd,Fleet fleet) // master method
        {
            while (herd.herdHealth > 0 && fleet.fleetHealth > 0) {
                FleetAttackResults(herd, fleet);
                if (herd.herdHealth > 0)
                {
                HerdAttackResults(fleet, herd);

                }


            }
            if (fleet.fleetHealth > 0)
            {
                Console.WriteLine("Winner is Team Robot ");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Winner is Team Dinosaur ");
                Console.ReadLine();
            }
           

            //Console.WriteLine(fleet.WarriorList[0].robotName);
        }

        public void FleetAttackResults(Herd herd, Fleet fleet) {
            herd.herdHealth = herd.herdHealth - fleet.fleetAttackPower;
            Console.WriteLine("Herd health = "+herd.herdHealth);
            Console.ReadLine();
           
        }

        public void HerdAttackResults(Fleet fleet, Herd herd) {
            fleet.fleetHealth = fleet.fleetHealth - herd.herdHealth;
            Console.WriteLine("Fleet health = "+fleet.fleetHealth);
            Console.ReadLine();
        }
        

        // TODO: LAter on
        public void UserOption() {
            if (userInput == "y" || userInput == "yes")
            {
                Console.WriteLine(" Lets Go !! ");
                Console.WriteLine("Choose Wisely.");
                Console.WriteLine("Enter (1) for Team Robot or (2) for Team Dinosaur ");
                userSelection = Console.ReadLine();
                if (userSelection == "1")
                {
                    Console.WriteLine("Welcome to Team Robot. ");
                    Console.WriteLine(" Robots Assemble! " + userSelection);
                    fleet.GetFleetInit();
                    Console.WriteLine("Ready to battle against ");
                    herd.GetDinosaurInit();
                    DoBattle(herd,fleet);
                }
                else if (userSelection == "2")
                {
                    Console.WriteLine("Welcome to Team Dinosaur. ");
                    Console.WriteLine("Rawr! " + userSelection);
                    herd.GetDinosaurInit();
                    Console.WriteLine("Ready to battle against ");
                    fleet.GetFleetInit();
                    DoBattle(herd, fleet);
                }
                else
                {
                    Console.WriteLine("Your only option is 1 or 2");
                    UserOption();
                }
            }
            else if (userInput == "n" || userInput == "no")
            {
                Console.WriteLine(" Maybe next time ");
                Console.ReadLine();
            }
             else {
                Console.WriteLine(" Please choose yes or no ");
                Console.ReadLine();
                GameInit();
            }
        }
    }
}
       

    
   


