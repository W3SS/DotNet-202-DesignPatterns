using Behavioral_Command_Concept_Vehicle.Command.ConcreteCommands;
using Behavioral_Command_Concept_Vehicle.Invoker;
using Behavioral_Command_Concept_Vehicle.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle newVehicle = Vehicles.GetCar();
            StartVehicle start = new StartVehicle(newVehicle);
            StopVehicle stop = new StopVehicle(newVehicle);
            BrakeVehicle brake = new BrakeVehicle(newVehicle);
            SpeedUpVehicle speedUp = new SpeedUpVehicle(newVehicle);


            CarInvoker carInvoker = new CarInvoker(start);
            carInvoker.InvokeCarCommand();

            carInvoker = new CarInvoker(stop);
            carInvoker.InvokeCarCommand();

            carInvoker = new CarInvoker(brake);
            carInvoker.InvokeCarCommand();

            carInvoker = new CarInvoker(speedUp);
            carInvoker.InvokeCarCommand();

            carInvoker.InvokeCarCommand();
            carInvoker.InvokeCarCommand();
            carInvoker.InvokeCarCommand();
            carInvoker.InvokeCarCommand(); //---Notice MPH



            newVehicle = Vehicles.GetMotorcycle();

            StartVehicle startMotorCycle = new StartVehicle(newVehicle);
            MotorcycleInvoker motorcycleInvoker = new MotorcycleInvoker(startMotorCycle);
           
            motorcycleInvoker.InvokeMotorcycleCommand();




        }
    }
}
