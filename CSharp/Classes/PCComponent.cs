using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public abstract class PCComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
    }
}
