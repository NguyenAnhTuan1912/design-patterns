using CSharp.Classes;
using CSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Factory_Method_Pattern
{
    public class Ferrari : Vehicle, IInformation
    {
        private Ferrari() : base()
        {
            this.Brand = "Ferrari";
        }

        public static Ferrari GetNewFerrariInstance()
        {
            return new Ferrari();
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

    public abstract class AbstactFerrariFactory
    {
        public abstract Ferrari createFerrari();
    }

    public class FerrariFactory : AbstactFerrariFactory
    {
        public override Ferrari createFerrari()
        {
            return Ferrari.GetNewFerrariInstance();
        }
    }
}
