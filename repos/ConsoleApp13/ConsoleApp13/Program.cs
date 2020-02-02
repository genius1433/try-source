using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5434;
            int c = 0;
            int v = 0;
            while (x>0)
            {
                c = x % 10;
                if (c % 2 == 0)
                {
                    Console.WriteLine(c + " четное");
                }
                else Console.WriteLine(c + " нечетное");
                x = x / 10;
            }
            Console.ReadLine();
        }
    }
}