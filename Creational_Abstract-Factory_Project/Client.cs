using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Abstract_Factory_Project
{
    class Client
    {
        private AbstractMcDonalds _abstractProductA;
        private AbstractBurgerKing _abstractProductB;

        // Constructor

        public Client(AbstractFactoryFastFood factory)
        {
            _abstractProductB = factory.CreateBKValueMeal();
            _abstractProductA = factory.CreateMCValueMeal();
        }

        public void Run()
        {
            _abstractProductB.CompareMeals(_abstractProductA);
        }
    }
}
