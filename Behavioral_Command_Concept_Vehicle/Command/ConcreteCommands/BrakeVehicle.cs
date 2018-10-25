using Behavioral_Command_Concept_Vehicle.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle.Command.ConcreteCommands
{
    class BrakeVehicle : ICommand
    {
        private IVehicle _vehicle;

        public BrakeVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Execute()
        {
            _vehicle.Brake();
        }
    }
}
