using System.Drawing;

namespace Elves
{
    public class TempleKnight : ElvenKnight
    {
        public TempleKnight(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
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
            Console.WriteLine($"TempleKnight is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"TempleKnight sound!");
        }
    }

    public class Swordsinder : ElvenKnight
    {
        public Swordsinder(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
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
            Console.WriteLine($"Swordsinder is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"Swordsinder sound!");
        }
    }

    public class EvasTemplar : TempleKnight
    {
        public EvasTemplar(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
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
            Console.WriteLine($"EvasTemplar is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"EvasTemplar sound!");
        }
    }

    public class SwordMuse : Swordsinder
    {
        public SwordMuse(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
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
            Console.WriteLine($"EvasTemplar is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"EvasTemplar sound!");
        }
    }
}
