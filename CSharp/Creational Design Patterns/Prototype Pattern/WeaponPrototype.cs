using CSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Prototype_Pattern
{
    public class MachineGun : Weapon
    {
        public int MagazineSize { get; set; }
        public string Stability { get; set; }

        public MachineGun()
        {
            Type = "Machine Gun";
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine("Number of Bullets: {0}", MagazineSize);
            Console.WriteLine("Stability: {0}", Stability);
        }
    }

    public class Sword : Weapon
    {
        public int Length { get; set; }

        public Sword()
        {
            Type = "Sword";
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine("Length of sword: {0}", Length);
        }
    }

    public class MachineGunPrototype
    {
        private MachineGun prototype;

        public MachineGunPrototype(MachineGun prototype)
        {
            this.prototype = prototype;
        }

        public MachineGun Clone()
        {
            MachineGun mGun = new MachineGun();
            mGun.Name = prototype.Name;
            mGun.Type = prototype.Type;
            mGun.Damage = prototype.Damage;
            mGun.Durability = prototype.Durability;
            mGun.Mass = prototype.Mass;
            mGun.Price = prototype.Price;
            mGun.MagazineSize = prototype.MagazineSize;
            mGun.Stability = prototype.Stability;
            return mGun;
        }
    }

    public class SwordPrototype
    {
        private Sword prototype;

        public SwordPrototype(Sword prototype)
        {
            this.prototype = prototype;
        }

        public Sword Clone()
        {
            Sword sword = new Sword();
            sword.Name = prototype.Name;
            sword.Type = prototype.Type;
            sword.Damage = prototype.Damage;
            sword.Durability = prototype.Durability;
            sword.Mass = prototype.Mass;
            sword.Price = prototype.Price;
            sword.Length = prototype.Length;
            return sword;
        }
    }

}
