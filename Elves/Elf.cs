using System.Drawing;

namespace Elves
{
    public class Elf
    {
        public int Health { get; set; }
        public string Weapon { get; set; }
        public string Magic { get; set; }
        public string Karma { get; set; }

        public Elf(int Health, string Weapon, string Magic, string Karma)
        {
            this.Health = Health;
            this.Weapon = Weapon;
            this.Magic = Magic;
            this.Karma = Karma;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}");
        }
        public override string ToString()
        {
            return $"Health: {Health}, Weapon: {Weapon}, Magic: {Magic}, Karma: {Karma}";
        }
        public virtual void Attack()
        {
            Console.WriteLine($"Elf is attacking with {Weapon}!");
        }
        public virtual void Sound()
        {
            Console.WriteLine($"Elf sound!");
        }
    }
}
