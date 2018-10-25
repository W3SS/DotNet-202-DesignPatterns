using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle.Receiver
{
    class Motorcycle : IVehicle
    {
        public Motorcycle(int mph)
        {
            MilesPerHour = mph;
        }

        public int MilesPerHour { get; set; }

        public void Brake()
        {
            MilesPerHour--;
            Console.WriteLine($"Slowing down the motorcycle to {MilesPerHour}");
        }

        public void SpeedUp()
        {
            MilesPerHour++;
            Console.WriteLine($"Speeding up the motorcycle to {MilesPerHour}");
        }

        public void Start()
        {
            Console.WriteLine("Starting the motorcycle");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the motorcycle");
        }
    }
}
