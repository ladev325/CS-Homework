using System.Drawing;

namespace Elves
{
    public class ElvenMystic : Elf
    {
        public string MagicMethod { get; set; }
        public ElvenMystic(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma)
        {
            this.MagicMethod = MagicMethod;
        }
        public override void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, MagicMethod: {MagicMethod}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, MagicMethod: {MagicMethod}";
        }
        public override void Attack()
        {
            Console.WriteLine($"ElvenMystic is making a total magic with {Weapon} using {MagicMethod}!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElvenMystic sound!");
        }
    }

    public class ElvenWizard : ElvenMystic
    {
        public ElvenWizard(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
        {
        }
        public override void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, MagicMethod: {MagicMethod}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, MagicMethod: {MagicMethod}";
        }
        public override void Attack()
        {
            Console.WriteLine($"ElvenWizard is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElvenWizard sound!");
        }
    }

    public class ElvenOracle : ElvenMystic
    {
        public ElvenOracle(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
        {
        }
        public override void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, MagicMethod: {MagicMethod}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, MagicMethod: {MagicMethod}";
        }
        public override void Attack()
        {
            Console.WriteLine($"ElvenOracle is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElvenOracle sound!");
        }
    }
}
