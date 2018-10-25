using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders

            Shop shop = new Shop();

            // Construct and display vehicles

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user

            Console.WriteLine("What would you like" +
                "1. A Car" +
                "2. A Motorcycle" +
                "3. A Scooter");

            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    builder = new CarBuilder();
                    break;
                case 2:
                    builder = new MotorCycleBuilder();
                    break;
                case 3:
                    builder = new ScooterBuilder();
                    break;
                default:
                    break;
            }
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();


        }
    }
}
