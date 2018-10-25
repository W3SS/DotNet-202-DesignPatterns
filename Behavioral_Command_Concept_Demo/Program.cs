using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ModificationManager();

            var alice = new Character("Alice", 30, 24, 12);
            var bob = new Character("Bob");

            // Create some modifications for Alice.
            var agilityAlice = new Modification(alice, StatisticType.Agility, 8);
            var charismaAlice = new Modification(alice, StatisticType.Charisma, -4);
            var strengthAlice = new Modification(alice, StatisticType.Strength, 0.75m);

            // Create modifications for Bob.
            var agilityBob = new Modification(bob, StatisticType.Agility, 99.99m);
            var charismaBob = new Modification(bob, StatisticType.Charisma, -42);

            manager.AddModification(agilityAlice);
            manager.AddModification(strengthAlice);
            manager.AddModification(agilityBob);
            manager.AddModification(charismaBob);
            manager.AddModification(charismaAlice);

            manager.ProcessQueue();

            manager.RevertModification(agilityAlice);




        }
    }
}
