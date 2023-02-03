using CSharp.Classes;
using CSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Builder_Pattern
{
    public class Card : PCComponent
    {
        public List<string> Parts = new List<string>();

        public Card()
        {
            Type = "Card";
        }
    }

    public class NetworkCard : Card, IInformation
    {
        public int BandWidth { get; set; }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Type: {0}", Type);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Max BandWidth: {0}", BandWidth);
            Console.WriteLine("==============================");
            Console.WriteLine("My parts: ");
            int index = 1;
            foreach (string part in Parts)
            {
                Console.WriteLine("{0}. {1}", index, part);
                index += 1;
            }
            Console.WriteLine("==============================");
        }
    }

    public class GraphicCard : Card, IInformation
    {
        public int Power { get; set; }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Type: {0}", Type);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Max Power: {0}", Power);
            Console.WriteLine("==============================");
            Console.WriteLine("My parts: ");
            int index = 1;
            foreach(string part in Parts) {
                Console.WriteLine("{0}. {1}", index, part);
                index += 1;
            }
            Console.WriteLine("==============================");
        }
    }

    public abstract class CardBuilder
    {
        public abstract void Prepare();
        public abstract void AddCore();
        public abstract void AddElectricCircuit();
        public abstract void AddCase();
    }

    public class NetworkCardBuilder : CardBuilder
    {
        private NetworkCard netc;

        public override void Prepare()
        {
            netc = new NetworkCard();
        }

        public override void AddCore()
        {
            netc.Parts.Add("NetWork Core");
        }

        public override void AddElectricCircuit()
        {
            netc.Parts.Add("NetWork Electric Circuit");
        }

        public void AddPort()
        {
            netc.Parts.Add("NetWork Port");
        }

        public override void AddCase()
        {
            netc.Parts.Add("NetWork Case");
        }

        public NetworkCard GetResult()
        {
            return netc;
        }
    }

    public class GraphicCardBuilder : CardBuilder
    {
        private GraphicCard grapc;

        public override void Prepare()
        {
            grapc = new GraphicCard();
        }

        public override void AddCore()
        {
            grapc.Parts.Add("Graphic Core");
        }

        public override void AddElectricCircuit()
        {
            grapc.Parts.Add("Graphic Electric Circuit");
        }

        public void AddTransistor()
        {
            grapc.Parts.Add("Graphic Transistor 7nm");
        }

        public override void AddCase()
        {
            grapc.Parts.Add("Graphic Case");
        }

        public GraphicCard GetResult()
        {
            return grapc;
        }
    }

    public class NetworkCardDirector
    {
        public NetworkCard Build(NetworkCardBuilder builder)
        {
            builder.Prepare();
            builder.AddCore();
            builder.AddElectricCircuit();
            builder.AddPort();
            builder.AddCase();
            return builder.GetResult();
        }
    }

    public class GraphicCardDirector
    {
        public GraphicCard Build(GraphicCardBuilder builder)
        {
            builder.Prepare();
            builder.AddCore();
            builder.AddElectricCircuit();
            builder.AddTransistor();
            builder.AddCase();
            return builder.GetResult();
        }
    }
}
