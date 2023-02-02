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
            Console.WriteLine("1. Singleton Example");
            Console.WriteLine("2. Singleton Example");
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
