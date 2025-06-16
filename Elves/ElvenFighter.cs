using Elves;
using System.Drawing;
using System.Reflection.PortableExecutable;

namespace Elves
{
    public class ElvenFighter : Elf
    {
        public string AttackMethod { get; set; }
        public ElvenFighter(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma)
        {
            this.AttackMethod = AttackMethod;
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
            Console.WriteLine($"ElvenFighter is attacking with {Weapon} using {AttackMethod}!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElvenFighter sound!");
        }
    }

    public class ElvenKnight : ElvenFighter
    {
        public ElvenKnight(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
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
            Console.WriteLine($"ElvenKnight is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElvenKnight sound!");
        }
    }


    public class ElvenScout : ElvenFighter
    {
        public ElvenScout(int Health, string Weapon, string Magic, string Karma, string AttackMethod) : base(Health, Weapon, Magic, Karma, AttackMethod)
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
            Console.WriteLine($"ElvenScout is attacking!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElvenScout sound!");
        }
    }
}