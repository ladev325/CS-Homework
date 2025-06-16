using System.Drawing;

namespace Elves
{
    public class ElvenElder : ElvenOracle
    {
        public ElvenElder(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
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
            Console.WriteLine($"ElvenElder is making magic!");
        }
        public override void Sound()
        {
            Console.WriteLine($"ElvenElder sound!");
        }
    }

    public class EvasSaint : ElvenElder
    {
        public EvasSaint(int Health, string Weapon, string Magic, string Karma, string MagicMethod) : base(Health, Weapon, Magic, Karma, MagicMethod)
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
            Console.WriteLine($"EvasSaint is making magic!");
        }
        public override void Sound()
        {
            Console.WriteLine($"EvasSaint sound!");
        }
    }
}
