using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y ; j++)
                {
                    
                    Console.Write("{0, 4 }",  i * j );
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
