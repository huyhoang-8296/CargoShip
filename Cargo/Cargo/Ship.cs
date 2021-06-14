using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo
{
    class Ship
    {
        // constant values
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;

        const int MAX_WEIGHT = 10;
        
        // List of properties for my class
        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }

        Random random = new Random();

        // Functions
        public int getShipLoad()
        {
            // Calculate the total weight of the cargo ont the ship

            return CycleCount * CYCLE_WEIGHT + CarCount * CAR_WEIGHT + TruckCount * TRUCK_WEIGHT + TrainCarCount * TRAIN_WEIGHT;
        }

        // Constructors - automatically called when a new instance is created. Same name is the class

        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;

            //Capacity is a random number
            Capacity = random.Next(MAX_WEIGHT) * CYCLE_WEIGHT + random.Next(MAX_WEIGHT) * CAR_WEIGHT + random.Next(MAX_WEIGHT) * TRUCK_WEIGHT + random.Next(MAX_WEIGHT) * TRAIN_WEIGHT;
        }

        public int overUnder()
        {
            //return a value of how load the ship is

            return Capacity - getShipLoad();
        }

        public override string ToString()
        {
            return "Capacity = " + Capacity + ", CurrentLoad = " + getShipLoad();
        }

    }
}
