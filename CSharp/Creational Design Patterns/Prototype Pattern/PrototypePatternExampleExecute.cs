using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Prototype_Pattern
{
    public static class PrototypePatternExampleExecute
    {
        public static void Run()
        {
            MachineGun ak47 = new MachineGun();
            Sword katana = new Sword();

            ak47.Name = "Ak-47";
            ak47.Damage = 68;
            ak47.Durability = 100;
            ak47.Mass = 3.47;
            ak47.Price = 3700;
            ak47.MagazineSize = 30;
            ak47.Stability = "Low";

            katana.Name = "Katana";
            katana.Damage = 49;
            katana.Durability = 100;
            katana.Mass = 1.67;
            katana.Price = 2200;
            katana.Length = 80;

            MachineGunPrototype mGunPrototype = new MachineGunPrototype(ak47);
            SwordPrototype swordPrototype = new SwordPrototype(katana);

            MachineGun defaultMachineGun = mGunPrototype.Clone();
            Sword defaultSword = swordPrototype.Clone();

            ak47.Name = "Co bi thay doi khong?";
            katana.Type = "Chac khong con bi thay doi dau";

            defaultMachineGun.PrintInformation();

            Console.WriteLine();

            defaultSword.PrintInformation();
        }
    }
}
