using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        { 
            int x = int.Parse(Console.ReadLine());
            int p = 1;
            int v = 1;
            int s = 0;
            for (int i = 2; i < x; i++)
            {
                s = p + v;
                p = v;
                v = s;
            }
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
