using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_рекурсии_2
{
    class Program
    {
        static int F2(int n)
        {
            if (n >= 2)
            {
                return F2(n - 1) * n;
            }
            else return 1;
        }
        static int F(int n)
        {
            int f = 1;
            for (int i = 2; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(F2(n));
            Console.ReadLine();
        }
    }
}
