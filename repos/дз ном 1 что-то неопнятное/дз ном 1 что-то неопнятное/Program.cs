using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_1_что_то_неопнятное
{
    class Program
    {
        static int A(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;

            }
            else if (m > 0 && n == 0)
            {
                return A(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return A(m - 1, A(m, n - 1));
            }
            else return 1;
        }
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(A(m, n));
            Console.ReadLine();
        }
    }
}
