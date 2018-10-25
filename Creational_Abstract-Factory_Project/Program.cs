using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Abstract_Factory_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory #1

            AbstractFactoryFastFood factory1 = new ConcreteMcDonalds();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2

            AbstractFactoryFastFood factory2 = new ConcreteBurgerKing();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input

            Console.ReadKey();
        }
    }
}
