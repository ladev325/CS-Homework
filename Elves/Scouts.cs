using System.Drawing;

namespace Elves
{
    public class Plainswalker : ElvenScout
    {
        public Plainswalker(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
        {
        }
        public override void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}";
        }
        public override void Attack()
        {
            Console.WriteLine($"Plainswalker is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"Plainswalker sound!");
        }
    }

    public class SilverRanger : ElvenScout
    {
        public SilverRanger(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
        {
        }
        public override void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}";
        }
        public override void Attack()
        {
            Console.WriteLine($"SilverRanger is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"SilverRanger sound!");
        }
    }

    public class WindRider : Plainswalker
    {
        public WindRider(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
        {
        }
        public override void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}";
        }
        public override void Attack()
        {
            Console.WriteLine($"SilverRanger is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"SilverRanger sound!");
        }
    }

    public class MoonlightSomething : SilverRanger
    {
        public MoonlightSomething(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
        {
        }
        public override void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}, AttackMethod: {AttackMethod}";
        }
        public override void Attack()
        {
            Console.WriteLine($"MoonlightSomething is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"MoonlightSomething sound!");
        }
    }
}
