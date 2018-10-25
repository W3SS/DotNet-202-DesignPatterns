using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Demo
{
    interface IModification
    {
        void Execute();
        Guid Id { get; set; }
        void Revert();
        Status Status { get; set; }
    }
}
