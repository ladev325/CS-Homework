using System;
using System.Linq;

namespace Example_1
{
    enum EnUm
    {
        a = 1,
        b = 2,
        c = 3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //14
            String str = "aboba";
            bool palindrom = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    palindrom = false;
            }
            if (palindrom) Console.WriteLine($"{str} is a palindrom");
            else Console.WriteLine($"{str} is NOT a palindrom");

            //15
            int[] arr = { 0, 1, 1, 2, 2, 3, 3, 4, 4 };
            List<int> numbers = new List<int> { }; // вектор для c#
            for (int i = 0; i < arr.Length; i++)
            {
                if (!numbers.Contains(arr[i]))
                    numbers.Add(arr[i]);
            }
            arr = numbers.ToArray();
            Console.WriteLine(string.Join(", ", arr));

            //16
            int sum = 0;
            foreach (int val in Enum.GetValues(typeof(EnUm)))
            {
                sum += val;
            }
            Console.WriteLine($"enum sum: {sum}");
            //17
            int a = 6;
            int b = 66;
            int nsd = 0;

            for (int i = Math.Min(a, b); i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    nsd = i;
                    break;
                }
            }

            Console.WriteLine($"nsd: {nsd}");

            //18
            int[] arr1 = { 0, 1, 2, 3 };
            int[] arr2 = { 0, 1, 2, -1 };
            if(arr1.SequenceEqual(arr2)) Console.WriteLine($"arr1 == arr2");
            else Console.WriteLine($"arr1 != arr2");

            //19
            int[] evenodd = {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> even = new List<int> { };
            List<int> odd = new List<int> { };
            for(int i = 0; i < evenodd.Length; i ++)
            {
                if (evenodd[i] % 2 == 0) even.Add(evenodd[i]);
                else odd.Add(evenodd[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"even: {string.Join(", ", even)}");
            Console.WriteLine($"odd: {string.Join(", ", odd)}");
            Console.WriteLine();

            //20
            String str2 = "hello this string has This word";
            bool has_cap_letter = false;
            for(int i = 0; i < str2.Length; i ++) {
                if (char.IsUpper(str2[i]) && (i == 0 || str2[i - 1] == ' '))
                {
                    has_cap_letter = true;
                    break;
                }
            }
            if (has_cap_letter) Console.WriteLine($"arr2 has a cap letter");
            else Console.WriteLine($"arr2 has no cap letters");

            //21
            Console.Write("Enter int number: ");
            String num = Console.ReadLine();
            int number = int.Parse(num);
            String str_num = "";

            if(number < 0) str_num += '-';
            number = Math.Abs(number);

            if (number == 0) str_num += "0";

            string digits = "";
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                digits = (char)('0' + digit) + digits;
            }

            str_num += digits;

            Console.WriteLine($"string: {str_num}");

        }
    }
}