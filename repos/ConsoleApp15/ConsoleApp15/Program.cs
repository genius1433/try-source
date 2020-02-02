using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string c = "";
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0,4 }", j);
                    }
                    else Console.Write("{0,4 }", "*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
