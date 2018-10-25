using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Abstract_Factory_Project
{
    class BurgerKingA : AbstractBurgerKing
    {
        public override void CompareMeals(McDonaldsA a)
        {
            Console.WriteLine(this.GetType().Name +
        " interacts with " + a.GetType().Name);
        }
    }
}
