using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Считалка_олимпиданая
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m % n == 0)
            {
                Console.WriteLine(n);
            } else Console.WriteLine(m % n);
            Console.ReadLine();
        }
    }
}
