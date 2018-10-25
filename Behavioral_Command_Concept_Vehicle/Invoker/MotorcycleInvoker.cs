using Behavioral_Command_Concept_Vehicle.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle.Invoker
{
    class MotorcycleInvoker
    {
        private ICommand _command;

        public MotorcycleInvoker(ICommand command)
        {
            _command = command;
        }

        public void InvokeMotorcycleCommand()
        {
            _command.Execute();
        }
    }
}
