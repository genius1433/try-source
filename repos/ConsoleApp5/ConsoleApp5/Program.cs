using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string c = "";
            for (int i = 0; i < x; i++)
            {
                c = c + "*";
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
