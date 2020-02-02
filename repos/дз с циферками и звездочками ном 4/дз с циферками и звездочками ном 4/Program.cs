using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_с_циферками_и_звездочками_ном_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i == x+1-j || i == j)
                    {
                        Console.Write("{0,4 }", i);
                    }
                    else Console.Write("{0,4 }", "*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
//for (int i = 1; i <= x; i++)
//            {
//                for (int j = x; j >= 1; j--)
//                {
//                    if (i == j)
//                    {
//                        Console.Write("{0,4 }", j);
//                    }
//                    else Console.Write("{0,4 }", "*");
//                }
//                Console.WriteLine();
//            }

