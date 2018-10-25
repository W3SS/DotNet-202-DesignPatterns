using Behavioral_Command_Concept_Vehicle.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle.Command.ConcreteCommands
{
    class StartVehicle : ICommand
    {
        private IVehicle _vehicle;

        public StartVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Execute()
        {
            _vehicle.Start();
        }
    }
}
