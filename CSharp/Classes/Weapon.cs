using CSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public abstract class Weapon : IInformation
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public int Durability { get; set; }
        public double Mass { get; set; }
        public int Price { get; set; }

        public virtual void PrintInformation()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Type: {0}", Type);
            Console.WriteLine("Damage: {0}", Damage);
            Console.WriteLine("Durability: {0}", Durability);
            Console.WriteLine("Mass: {0}", Mass);
            Console.WriteLine("Price: {0}", Price);
        }
    }
}
