using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace числа_слево_направа_рекурсией
{
    class Program
    {
        static void F(int n)
        {
            while (n > 0)
            {
                Console.WriteLine(n % 10);
                n = n / 10;
            }
        }
        static void F1(int n)
        {
            if (n > 0)
            {
                F1(n / 10);
                Console.WriteLine(n % 10);
                //F1(n / 10);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            F1(n);
            Console.ReadLine();
        }
    }
}
