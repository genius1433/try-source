using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_4_сложное_или_не_тс_рекурсией
{
    class Program
    {
        static void P(int x, int i, int c)
        {
            if (i <= x/2)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("сложное");
                    c = 0;
                }
                else 
                {
                    P(x, i + 1, 1);
                    c = 0;
                }
            }
            if (c == 1)
            {
                Console.WriteLine("простое");
            }
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            P(x, 2, 0);
            Console.ReadLine();
        }
    }
}
