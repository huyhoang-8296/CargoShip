using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();

            string WelcomeMessage = "Welcome to Cargo Ship. The goal of this game is to load the ship to its maximum capacity by adding motorcycles, cars, trucks and train cars" +
                "A cycle takes 3 units of weight, car 5, truck 11, and train car 17";
            Console.WriteLine(WelcomeMessage);

            // repeat until the player gets the ship to full capacity
            while(ship.Capacity != ship.getShipLoad())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The ship capacity is: " + ship.Capacity);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The ship has: " + ship.CycleCount + " motorcycles on board.");
                Console.WriteLine("The ship has: " + ship.CarCount + " cars on board.");
                Console.WriteLine("The ship has: " + ship.TruckCount + " trucks on board.");
                Console.WriteLine("The ship has: " + ship.TrainCarCount + " train cars on board.");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The ship currently has: " + ship.getShipLoad() + " total units onboard");

                Console.ForegroundColor = ConsoleColor.White;
                int x;
                Console.WriteLine("How many motorcycles would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());

                ship.CycleCount = x;

                Console.WriteLine("How many cars would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());

                ship.CarCount = x;

                Console.WriteLine("How many trucks would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());

                ship.TruckCount = x;

                Console.WriteLine("How many train cars would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());

                ship.TrainCarCount = x;

                Console.WriteLine("The ship now has: " + ship.getShipLoad() + " total units weight on board");

                if (ship.overUnder() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("The ship is overloaded. Take some items off!");
                }
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("You loaded the ship successfully!");

            Console.ReadLine();
        }
    }
}
