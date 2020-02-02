using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace найти_самое_длинное_слово
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "I am from Russia";
            string max = "";
            string[] words = n.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (max.Length < words[i].Length)
                {
                    max = words[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
