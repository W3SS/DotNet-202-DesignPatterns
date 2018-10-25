using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Abstract_Factory_Project
{
    class ConcreteBurgerKing : AbstractFactoryFastFood
    {
        public override AbstractMcDonalds CreateFoodA()
        {
            throw new NotImplementedException();
        }

        public override AbstractBurgerKing CreateFoodB()
        {
            throw new NotImplementedException();
        }
    }
}
