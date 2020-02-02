using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());           
            int s = 1;
            for (int i = 1; i <= c; i++)
            {
                s = s * x;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
