using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Factory_Method_Pattern
{
    public static class FactoryMethodExampleExecute
    {
        public static void Run()
        {
            FerrariFactory ferrariFactory = new FerrariFactory();
            Ferrari ferrari1 = ferrariFactory.createFerrari();
            Ferrari ferrari2 = ferrariFactory.createFerrari();

            ferrari1.Color = "Red";
            ferrari1.Sound = "Ennnnn";
            ferrari1.NumberOfSeats = ferrari1.NumberOfWheels = 2;
            ferrari1.TopSpeed = 380;

            ferrari2.Color = "Yellow";
            ferrari2.Sound = "Ennnnn";
            ferrari2.NumberOfSeats = ferrari2.NumberOfWheels = 2;
            ferrari2.TopSpeed = 320;

            ferrari1.Say();
            ferrari1.PrintInformation();

            Console.WriteLine();

            ferrari2.Say();
            ferrari2.PrintInformation();
        }
    }
}
