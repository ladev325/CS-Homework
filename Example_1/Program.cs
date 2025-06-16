using System;
using Elves;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempleKnight temple_knight = new TempleKnight(100, "Weapon", "Magic", "Karma", "AttackMethod");
            temple_knight.Info();
            temple_knight.Attack();
            temple_knight.Sound();
        }
    }
}
