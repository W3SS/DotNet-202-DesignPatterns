using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle.Receiver
{
    interface IVehicle
    {
        void Start();
        void Stop();
        void Brake();
        void SpeedUp();
    }
}
