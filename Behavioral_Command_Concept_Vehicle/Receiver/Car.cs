using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle.Receiver
{
    class Car : IVehicle
    {
        public Car(int mph)
        {
            MilesPerHour = mph;
        }

        public int MilesPerHour { get; set; }

        public void Brake()
        {
            MilesPerHour--;
            Console.WriteLine($"Slowing down the car to {MilesPerHour}");
        }

        public void SpeedUp()
        {
            MilesPerHour++;
            Console.WriteLine($"Speeding up the car {MilesPerHour}");
        }

        public void Start()
        {
            Console.WriteLine("Starting the car");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the car");
        }
    }
}
