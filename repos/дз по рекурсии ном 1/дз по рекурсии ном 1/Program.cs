using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_по_рекурсии_ном_1
{
    class Program
    {
        static void N(int n, int x)
        {
            
            Console.Write("{0,-10}", x);
            if (x < n)
            {
                N(n,x + 1);
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            N(n, x);
            Console.ReadLine();
        }
    }
}
