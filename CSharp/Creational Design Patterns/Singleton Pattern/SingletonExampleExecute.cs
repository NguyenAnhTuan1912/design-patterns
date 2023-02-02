using CSharp.Creational_Design_Patterns.Factory_Method_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Singleton_Pattern
{
    public static class SingletonExampleExecute
    {
        public static void Run()
        {
            CarSingleton bmw = CarSingleton.GetIntance();
            CarSingleton ferrari = CarSingleton.GetIntance();
            CarSingleton lamborghini = CarSingleton.GetIntance();

            bmw.Brand = "BMW";
            bmw.Color = "White";
            bmw.Sound = "Grennnnn";
            bmw.NumberOfSeats = bmw.NumberOfWheels = 4;
            bmw.TopSpeed = 270;

            ferrari.Brand = "Ferrari";
            ferrari.Color = "Red";
            ferrari.Sound = "Ennnnn";
            ferrari.NumberOfSeats = ferrari.NumberOfWheels = 2;
            ferrari.TopSpeed = 380;

            lamborghini.Brand = "Lamborghini";
            lamborghini.Color = "Yellow";
            lamborghini.Sound = "Grunnnnn";
            lamborghini.NumberOfSeats = lamborghini.NumberOfWheels = 2;
            lamborghini.TopSpeed = 370;

            bmw.Say();
            bmw.PrintInformation();

            Console.WriteLine();

            ferrari.Say();
            ferrari.PrintInformation();

            Console.WriteLine();

            lamborghini.Say();
            lamborghini.PrintInformation();
        }
    }
}
