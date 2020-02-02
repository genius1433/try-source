using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int z = 0;
            int a = 0;
            for (int x = m; x <= n; x++)
            {
                string g = "";

                int c = 1;
                for (int i = 2; i <= x / 2; i++)
                {
                    if (x % i == 0)
                    {
                        c = 0;
                        g = g + i + " ";
                    }

                }
                if (c == 0)
                {
                    z = z + 1;
                    Console.WriteLine(x + "непростое" + g);
                }
                else
                {
                    a = a + 1;
                    Console.WriteLine(x + "простое");
                }
            }
            Console.WriteLine();
            Console.WriteLine(z + "сложных чисел");
            Console.WriteLine(a + "простых чисел");
            Console.ReadLine();
        }
    }
}
