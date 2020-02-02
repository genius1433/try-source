using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_2_ряд_фибоначи_с_рекурсией
{
    class Program
    {
        static void Fib(int s, int p, int v, int x,int i)
        {
            if (i<=x)
            {
                s = p + v;
                p = v;
                v = s;
                i++;
                Console.Write("{0,-10}", s);
                Fib(s, p, v, x, i);
            }
        }
        static void Main(string[] args)
        {
            int i = 3;
            int s = 0;
            int p = 1;
            int v = 1;
            Console.Write("x"+5);
            Console.ReadLine();
        }
    }
}
