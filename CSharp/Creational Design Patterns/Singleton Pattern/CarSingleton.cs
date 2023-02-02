using CSharp.Classes;
using CSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Singleton_Pattern
{
    public class CarSingleton : Vehicle, IInformation
    {
        private static object _Lock = new object();
        private static CarSingleton _Intance = null;

        private CarSingleton() : base()
        {

        }

        public static CarSingleton GetIntance()
        {
            if(_Intance == null)
            {
                lock(_Lock)
                {
                    if(_Intance == null)
                    {
                        _Intance = new CarSingleton();
                    }
                }
            }
            return _Intance;
        }

        public override void Say()
        {
            Console.WriteLine("This vehicle says: {0}", this.Sound);
        }

        public void PrintInformation()
        {
            Console.WriteLine("Brand: {0}", this.Brand);
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Sound: {0}", this.Sound);
            Console.WriteLine("Number of Seats: {0}", this.NumberOfSeats);
            Console.WriteLine("Number of Wheels: {0}", this.NumberOfWheels);
            Console.WriteLine("Top speed: {0}", this.TopSpeed);
        }
    }
}
