using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Demo
{
    class Character
    {
        public string Name { get; set; }
        public Agility Agility { get; set; } = new Agility();
        public Charisma Charisma { get; set; } = new Charisma();
        public Strength Strength { get; set; } = new Strength();

        public Character(string name)
        {
            Name = name;
        }

        public Character(string name, decimal agility, decimal charisma, decimal strength)
        {
            Name = name;
            Agility.Value = agility;
            Charisma.Value = charisma;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
