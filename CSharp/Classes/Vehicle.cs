using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Sound { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int TopSpeed { get; set; }

        public Vehicle() { }

        public abstract void Say();
    }
}
