using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Demo
{
    class ModificationManager
    {
        private readonly List<IModification> _queue = new List<IModification>();

        public bool HasQueue => _queue.Any(x =>
            x.Status == Status.Queued ||
            x.Status == Status.ExecuteFailed ||
            x.Status == Status.RevertFailed);

        public void AddModification(IModification modification)
        {
            _queue.Add(modification);
        }

        public void ProcessQueue()
        {
            foreach(var modification in _queue.Where(x =>
                x.Status == Status.Queued ||
                x.Status == Status.ExecuteFailed))
            {
                modification.Execute();
            }

            foreach(var modification in _queue.Where(x =>
                x.Status == Status.RevertFailed))
            {
                modification.Revert();
            }
        }

        public void RevertModification(IModification modification)
        {
            var match = _queue.FirstOrDefault(x => x == modification);

            if(match == null)
            {
                throw new ArgumentException("Modification not found");
            }
            if(match.Status != Status.ExecuteSucceeded)
            {
                throw new ArgumentException("Modification must be be...");
            }
            match.Revert();

            if(match.Status == Status.RevertSucceeded)
            {
                _queue.Remove(match);
            }
        }

        public void RevertModification(Guid id)
        {
            RevertModification(_queue.FirstOrDefault(x => x.Id == id));
        }
    }
}
