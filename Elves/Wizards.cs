using System.Drawing;

namespace Elves
{
    public class Summoner : ElvenWizard
    {
        public Summoner(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
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
            Console.WriteLine($"Summoner is summoning!");
        }
        public override void Sound()
        {
            Console.WriteLine($"Summoner sound!");
        }
    }

    public class Spellsinger : ElvenWizard
    {
        public Spellsinger(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
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
            Console.WriteLine($"Spellsinger is spelling!");
        }
        public override void Sound()
        {
            Console.WriteLine($"Spellsinger sound!");
        }
    }

    public class ElementalMaster : Summoner
    {
        public ElementalMaster(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
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
            Console.WriteLine($"ElementalMaster is macing total magic!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElementalMaster sound!");
        }
    }

    public class MysticMuse : Spellsinger
    {
        public MysticMuse(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
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
            Console.WriteLine($"MysticMuse is macing total magic!");
        }
        public override void Sound()
        {
            Console.WriteLine($"MysticMuse sound!");
        }
    }
}
