using CSharp.Creational_Design_Patterns.Abstract_Factory_Pattern;
using CSharp.Creational_Design_Patterns.Builder_Pattern;
using CSharp.Creational_Design_Patterns.Factory_Method_Pattern;
using CSharp.Creational_Design_Patterns.Singleton_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void PrintOption()
        {
            Console.WriteLine("1. Singleton Pattern example");
            Console.WriteLine("2. Factory Method Pattern example");
            Console.WriteLine("3. Abstract Factory Pattern example");
            Console.WriteLine("4. Builder Pattern example");
            Console.WriteLine("0. Stop");
        }

        static void RunOption(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Singleton Pattern Example");
                        Console.WriteLine("=====================================");
                        SingletonExampleExecute.Run();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Factory Method Pattern Example");
                        Console.WriteLine("=====================================");
                        FactoryMethodExampleExecute.Run();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Abstract Factory Pattern Example");
                        Console.WriteLine("=====================================");
                        AbstractFactoryExampleExecute.Run();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Builder Pattern Example");
                        Console.WriteLine("=====================================");
                        BuilderExampleExecute.Run();
                        break;
                    }
                case 0:
                default: break;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int option;
            do
            {
                PrintOption();
                option = int.Parse(Console.ReadLine());
                if (option == 0) break;
                RunOption(option);
            } while (option != 0);

            Console.WriteLine("Press any key to exist");
            Console.ReadKey();
        }
    }
}
