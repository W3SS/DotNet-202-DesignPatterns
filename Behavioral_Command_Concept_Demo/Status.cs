using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Demo
{
    enum Status
    {
        ExecuteFailed,
        ExecuteSucceeded,
        Queued,
        RevertFailed,
        RevertSucceeded
    }
}
