using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace простыемножители
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int c = 1;
            int v = 0;
            for (int i = x; i > 1; i--)
            {
                c = c * i;
                for (int f = i; f < x; f++)
                {
                    v = x % i;
                    if (v == 0)
                    {

                        Console.WriteLine("заданное число - простое");
                    }
                    else
                        Console.WriteLine("Заданное число - простое");
                }
            }
        }
    }
}



