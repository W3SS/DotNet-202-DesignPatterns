using Behavioral_Command_Concept_Vehicle.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle.Invoker
{
    class CarInvoker
    {
        private ICommand _command;

        public CarInvoker(ICommand command)
        {
            _command = command;
        }

        public void InvokeCarCommand()
        {
            _command.Execute();
        }
    }
}
