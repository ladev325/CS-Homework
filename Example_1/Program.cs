using System;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int height = 10;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //2
            bool state = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    state = !state;
                    if (state) Console.Write("X ");
                    else Console.Write("O ");

                }
                state = !state;
                Console.WriteLine("");
            }
            Console.WriteLine();

            //3
            for (int i = 0; i < 20; i +=2)
            {
                for(int j = 0; j < i; j ++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //4

            for (int i = 0; i < 10; i ++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i == j || 10 - i == j + 1) Console.Write("+ ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //5
            /*
            Random rnd = new Random();

            while (true)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if((j >= 15 && j <= 24 && i >= 12 && i <= 14) || (j == 25 && i == 13)) Console.Write("#");
                        else if(rnd.Next(50) == 1) Console.Write("*");
                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            */

            //6
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(j >= 3 && j <= 6 && i >= 3 && i <= 6) Console.Write("o ");
                    else if (i == j || 10 - i == j + 1) Console.Write("x ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //7
            /*Random rnd2 = new Random();

            while (true)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        if (rnd2.Next(50) == 1) Console.Write("|");
                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }*/

            //8
            Console.WriteLine("Enter height: ");
            int height1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < height1 + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("^");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}