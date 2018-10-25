using Behavioral_Command_Concept_Vehicle.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle
{
    class Vehicles
    {
        public static IVehicle GetCar()
        {
            return new Car(5); //<-- Random number for mph
        }

        public static IVehicle GetMotorcycle()
        {
            return new Motorcycle(10);
        }
    }
}
