using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int f = 1;
            if (c<0)
            {
                f = 0;
                c = -c;
            }
            int s = 1;
            for (int i = 1; i <= c; i++)
            {
                s = (s * x);           
            }
            if (f == 0)
            {
                Console.WriteLine((double)1 / s);
            }
            else Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
