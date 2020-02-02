using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсивный_факториал
{
    class Program
    {
        static int F(int n)
        {
            if (n > 1)
            {
                return n * F(n - 1);
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(F(n));
            Console.ReadLine();
        }
    }
}
