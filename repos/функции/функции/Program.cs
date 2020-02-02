using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace функции
{
    class Program
    {
        static double Ctepen(int n, int m)
        {
            int f = 1;
            if (m < 0)
            {
                f = 0;
                m = -m;
            }
            int s = 1;
            for (int i = 1; i <= m; i++)
            {
                s = (s * n);
            }
            if (f == 0)
            {
                return ((double)1 / s);
            }
            else return s;
        }
        static int Factorial(int n)
        {
            int c = 1;
            for (int i = n; i > 1; i--)
            {
                c = c * i;
            }
            return c;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double a = 0;
            double result = 0;
            for (int i = 0; i <= n; i++)
            {
                a = Math.Pow(-1,i) * Ctepen(2, 2 * i + 1) / Factorial(2 * i + 1);
                result = result + a;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
