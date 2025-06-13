using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    public class MyString
    {
        public char[] str { get; set; }
        public int length { get; }
        public MyString(char[] str)
        {
            this.str = str;
        }

        public char StartWith() => str[0];
        public char EndWith() => str[str.Length - 1];
        public char[] Substring(int startIndex, int endIndex)
        {
            //this.str = "Some text"
            //startIndex = 3
            //endIndex = 2
            //result = "e "
            if (startIndex < 0 || endIndex < 0)
                throw new Exception($"invalid index (from {startIndex} to {endIndex})");

            if(startIndex > endIndex)
            {
                int tmp = startIndex;
                startIndex = endIndex;
                endIndex = tmp;
            }

            char[] new_arr = new char[endIndex - startIndex];

            for(int i = startIndex; i < endIndex; i ++)
            {
                new_arr[i - startIndex] = str[i];
            }

            return new_arr;
        }
        public void Remove(int startIndex, int endIndex)
        {
            //this.str = "Some text"
            //startIndex = 1
            //endIndex = 3
            //result = "S text"
            if (startIndex < 0 || endIndex < 0)
                throw new Exception($"invalid index (from {startIndex} to {endIndex})");

            if (startIndex > endIndex)
            {
                int tmp = startIndex;
                startIndex = endIndex;
                endIndex = tmp;
            }

            int new_size = str.Length - (endIndex - startIndex);
            char[] new_arr = new char[new_size];

            int i = 0;
            int i_new = 0;
            while (i < new_size)
            {
                if(i < startIndex || i >= endIndex)
                {
                    new_arr[i_new] = str[i];
                    i_new++;
                }
                i++;
            }
            str = new_arr;
        }
        public void RemoveAll()
        {
            //this.str = "Some text"
            //this.str = ""
            str = new char[0];
        }
        public int IndexOf(char[] search)
        {
            //this.str = "My friend with hi"
            //search = "hi"
            //foundIndex = 15
            int foundIndex = -2;
            int start_with = 0;

            while (foundIndex == -2 && start_with <= str.Length - search.Length)
            {
                bool found_first = false;
                int i = start_with;
                while (!found_first && i <= str.Length - search.Length)
                {
                    if (str[i] == search[0]) found_first = true;
                    else i++;
                }
                if (found_first)
                {
                    bool ok = true;
                    for (int j = 0; j < search.Length; j ++)
                    {
                        if (str[i + j] != search[j])
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (!ok) start_with = i + 1;
                    else foundIndex = i;
                }
                else foundIndex = -1;
            }

            return foundIndex;
        }
        public void Concat(char[] str1, char[] str2)
        {
            int new_size = str1.Length + str2.Length;
            char[] new_arr = new char[new_size];

            for(int i = 0; i < new_size; i ++)
            {
                char this_sym;
                if (i < str1.Length) this_sym = str1[i];
                else this_sym = str2[i - str1.Length];
                new_arr[i] = this_sym;
            }
            str = new_arr;
        }
        public void Replace(char[] newValue)
        {
            //this.str = "Hi"
            //newValue = "Hello"
            //result = "Hello"
            str = newValue;
        }
        public void Replace(char[] oldValue, char[] newValue)
        {
            //oldValue = "Hi"
            //newValue = "Hello"
            //result = "Hello"
            int old_index = IndexOf(oldValue);
            if (old_index < 0)
                return;
            int new_size = str.Length - oldValue.Length + newValue.Length;
            char[] new_arr = new char[new_size];
            for (int i = 0; i < old_index; i++)
            {
                new_arr[i] = str[i];
            }

            for (int i = 0; i < newValue.Length; i++)
            {
                new_arr[old_index + i] = newValue[i];
            }

            for (int i = old_index + oldValue.Length; i < str.Length; i++)
            {
                new_arr[i] = str[i];
            }

            str = new_arr;
        }
        public void Trim(char ch)
        {
            //ch = ' '
            //this.str = "Hello, World!"
            //result = "Hello,World!"
            int new_size = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] != ch) new_size++;
            }
            char[] new_arr = new char[new_size];

            int i = 0;
            int old_i = 0;
            while(old_i < str.Length)
            {
                if (str[old_i] != ch) {
                    new_arr[i] = str[old_i];
                    i++;
                }
                old_i++;
            }
            str = new_arr;
        }
        public bool CompareTo(char[] str1, char[] str2)
        {
            //str1 = "Hello"
            //str2 = "Hello"
            bool ok = true;
            if (str1.Length != str2.Length) return false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    ok = false;
                    break;
                }
            }

            return ok;
        }
    }

}