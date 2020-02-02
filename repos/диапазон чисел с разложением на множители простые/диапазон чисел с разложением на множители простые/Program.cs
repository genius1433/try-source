using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace диапазон_чисел_с_разложением_на_множители_простые
{
    class Program
    {
        static void Razlozenie(int f)
        {
            int m = 2;
            while (f > 1)
            {
                while (f % m == 0)
                {
                    Console.Write("*" + m);
                    f = f / m;
                }
                m++;
            }
        }
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            for (int i = f; f <= s; f++)
            {
                Console.Write(f + "=" + 1);
                Razlozenie(f);
                Console.WriteLine();
            } 
            Console.ReadLine();
        }
    }
}
