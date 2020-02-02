using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace последовательност_ьурок_2
{
    class Program
    {
        static void Say(string str, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(str);
            }

        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Say("Я топ", 11);
            //Say("Говорю", 2);
            int x = Sum(2, 5);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
