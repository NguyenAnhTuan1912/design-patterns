using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Hobby { get; set; }
        public int Age { get; set; }

        public Human(string name = "", string hobby = "", int age = 0)
        {
            Name = name;
            Hobby = hobby;
            Age = age;
        }

        public abstract void Say();
    }
}
