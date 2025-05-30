using System;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            const int width = 3, height = 3;
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            //2
            int sum = 0;
            foreach (int x in matrix)
            {
                sum += x;
            }
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine();

            //3
            for (int i = 0; i < height; i++)
            {
                for (int j = i + 1; j < width; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (matrix[i, j] < 10) Console.Write(" ");
                }
                Console.WriteLine();
            }

            matrix = new int[,] {
              {1, 2, 3},
              {4, 5, 6},
              {7, 8, 9}
            };
            Console.WriteLine();

            //4

            int min = matrix[0, 0], max = matrix[0, 0];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (min > matrix[i, j]) min = matrix[i, j];
                    if (max < matrix[i, j]) max = matrix[i, j];
                }
            }
            Console.WriteLine($"min: {min}, max: {max}");
            Console.WriteLine();

            //5
            int[,] matrix2 =
            {
                { 10, 20, 30 },
                { 40, 50, 60 },
                { 70, 80, 90 }
            };

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j] * matrix2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //6
            int[] sum_cols = new int[height];
            int[] sum_rows = new int[width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sum_cols[i] += matrix[i, j];
                }
            }

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    sum_rows[j] += matrix[i, j];
                }
            }

            Console.Write($"Col sums: ");
            for (int i = 0; i < height; i++)
            {
                Console.Write($" {sum_cols[i]}");
            }
            Console.WriteLine();

            Console.Write($"Row sums: ");
            for (int i = 0; i < width; i++)
            {
                Console.Write($" {sum_rows[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //7
            for (int i = 0; i < height; i++)
            {
                for (int pass = 0; pass < width - 1; pass++)
                {
                    for (int j = 0; j < width - 1 - pass; j++)
                    {
                        if (matrix[i, j + 1] > matrix[i, j])
                        {
                            int tmp = matrix[i, j + 1];
                            matrix[i, j + 1] = matrix[i, j];
                            matrix[i, j] = tmp;
                        }
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (matrix[i, j] < 10) Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            matrix = new int[,] {
              {1, 2, 3},
              {4, 5, 6},
              {7, 8, 9}
            };


            //8
            int[] max_nums = new int[height];

            for (int i = 0; i < height; i++)
            {
                int maxn = matrix[i, 0];
                for (int j = 0; j < width; j++)
                {
                    if (maxn < matrix[i, j])
                    {
                        maxn = matrix[i, j];
                    }
                }
                max_nums[i] = maxn;
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (matrix[i, j] < 10) Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.Write($"Max in rows: ");
            for (int i = 0; i < height; i++)
            {
                Console.Write($"{max_nums[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //9
            bool symmetric = true;
            if (height != width)
            {
                symmetric = false;
            }

            else
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (matrix[i, j] != matrix[j, i])
                        {
                            symmetric = false;
                        }
                    }
                }
                Console.WriteLine($"Symmetric: {symmetric}");
            }
            Console.WriteLine();

            //10
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j] + matrix2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}