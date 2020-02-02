using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace еще_рекурсии
{
    class Program
    {
        static int S2(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else return x * S2(x, y - 1);
        }
        static int S(int x, int y)
        {
            int r = 1;
            while (y >= 1)
            {
                r = r * x;
                y--;
            }
            return r;
        }
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(S2(x, y));
            Console.ReadLine();
        }
    }
}
