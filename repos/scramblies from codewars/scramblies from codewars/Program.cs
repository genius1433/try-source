using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scramblies_from_codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str1 = "scriptjavx";
            string str2 = "javascript";
            bool booler = false;
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1.IndexOf(str2[i], i) != -1) { count++; }
            }
            if (count == str2.Length)
            {
                booler = true;
            }
            else booler = false;
            Console.WriteLine(booler);
            Console.ReadLine();
        }
    }
}
