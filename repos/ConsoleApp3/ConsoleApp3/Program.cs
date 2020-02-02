using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = x; i > 1; i--)
            {
                c = c * i;            
            }
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
