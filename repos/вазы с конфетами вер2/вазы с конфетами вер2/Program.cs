using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вазы_с_конфетами_вер2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min = Math.Min(Math.Min(a,b/2),c);
            a = a - min;
            b = b - 2 * min;
            c = c - min;
            if (a == 0)
            {
                Console.WriteLine(4 * min);
            }
            else if (b == 0)
            {
                Console.WriteLine(4 * min + 1);
            }
            else if (c == 0)
            {
                Console.WriteLine(4 * min + 2);
            }
            else Console.WriteLine(4 * min + 3);
            Console.ReadLine();
        }
    }
}
