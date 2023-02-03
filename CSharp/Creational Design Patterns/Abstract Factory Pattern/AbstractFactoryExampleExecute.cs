using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Abstract_Factory_Pattern
{
    public static class AbstractFactoryExampleExecute
    {
        public static void Run()
        {
            PeopleFactory peopleFactory = new PeopleFactory();
            Student stdA = peopleFactory.CreateStudent("Sweet Johnson", "BasketBall", 20, 12);
            Worker wkrA = peopleFactory.CreateWorker("Carl Johnson", "Everything", 19, 12);
            Athlete athA = peopleFactory.CreateAthlete("Leonel Messi", "Football", 35, 41);

            stdA.Say();
            stdA.PrintInformation();

            Console.WriteLine();

            wkrA.Say();
            wkrA.PrintInformation();

            Console.WriteLine();

            athA.Say();
            athA.PrintInformation();
        }
    }
}
