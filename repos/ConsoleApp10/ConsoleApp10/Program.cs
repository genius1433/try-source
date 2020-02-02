using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int r = 0;
            int t = 1;
            while (x>0)
            {
                t = x % 10;
                r = r * 10 + t;
                x = x / 10;
            }
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
