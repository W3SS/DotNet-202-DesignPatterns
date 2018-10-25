using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Abstract_Factory_Project
{
    abstract class AbstractFactoryFastFood
    {
        public abstract AbstractMcDonalds CreateFoodA();
        public abstract AbstractBurgerKing CreateFoodB();

        internal AbstractBurgerKing CreateBKValueMeal()
        {
            throw new NotImplementedException();
        }

        internal AbstractMcDonalds CreateMCValueMeal()
        {
            throw new NotImplementedException();
        }
    }
}
