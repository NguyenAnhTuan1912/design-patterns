using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Builder_Pattern
{
    public static class BuilderExampleExecute
    {
        public static void Run()
        {
            NetworkCardBuilder netcBuilder = new NetworkCardBuilder();
            GraphicCardBuilder grapcBuilder = new GraphicCardBuilder();

            NetworkCardDirector netcDirector = new NetworkCardDirector();
            GraphicCardDirector grapcDirector = new GraphicCardDirector();

            NetworkCard netc = netcDirector.Build(netcBuilder);
            GraphicCard grapc = grapcDirector.Build(grapcBuilder);

            netc.Name = "Asus NetWork Adapter Gen1000";
            netc.Description = "Powerful & Fast NetWork Adapter";
            netc.Brand = "Asus";
            netc.Price = 340;
            netc.BandWidth = 96;

            grapc.Name = "NVidia RTX 3080Ti";
            grapc.Description = "Strong, Heavy and Fast";
            grapc.Brand = "NVidia";
            grapc.Price = 4500;
            grapc.Power = 3800;

            netc.PrintInformation();

            Console.WriteLine();

            grapc.PrintInformation();
        }
    }
}
