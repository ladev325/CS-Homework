using System;
using Elves;

namespace Example_1
{
    internal class Program
    {
        static void InfoElf(Elf elf)
        {
            elf.Info();
        }

        static void ElfAttack(Elf elf)
        {
            elf.Attack();
        }

        static void ElfSound(Elf elf)
        {
            elf.Sound();
        }

        static void Main(string[] args)
        {
            // ------ я вже зробив що було в завданні тому просто додав поліморфні методи

            TempleKnight temple_knight = new TempleKnight(100, "Weapon", "Magic", "Karma", "AttackMethod");

            // взагалі з іншої гілки успадкування
            EvasSaint evas_saint = new EvasSaint(1000, "Weaponnnn", "Total magic", "Karma", "Magic method");


            InfoElf(temple_knight);
            ElfAttack(temple_knight);
            ElfSound(temple_knight);

            InfoElf(evas_saint);
            ElfAttack(evas_saint);
            ElfSound(evas_saint);
        }
    }
}
