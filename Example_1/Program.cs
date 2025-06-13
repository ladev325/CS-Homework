using System;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString("Hello, this is a very long (not) string".ToCharArray());

            string substr = new string(str.Substring(7, 11));
            Console.WriteLine("Substring: " + substr);

            int index = str.IndexOf("string".ToCharArray());
            Console.WriteLine("IndexOf: " + index);

            str = new MyString("Hello, this is a very long (not) string".ToCharArray());
            str.Trim(' ');
            Console.WriteLine("Trim: " + new string(str.str));

            str = new MyString("Hello, this is a very long (not) string".ToCharArray());
            str.Replace("this".ToCharArray(), "THAT".ToCharArray());
            Console.WriteLine("Replace: " + new string(str.str));

            str.Concat("Hello ".ToCharArray(), "2".ToCharArray());
            Console.WriteLine("Concat: " + new string(str.str));

            str = new MyString("Hello, this is a very long (not) string".ToCharArray());
            str.Remove(1, 4);
            Console.WriteLine("Remove: " + new string(str.str));

            str = new MyString("Hello, this is a very long (not) string".ToCharArray());
            Console.WriteLine("CompareTo: " + str.CompareTo("very".ToCharArray(), "very".ToCharArray()));

            str.RemoveAll();
            Console.WriteLine("RemoveAll: " + new string(str.str));

            Console.ReadKey();
        }
    }
}
