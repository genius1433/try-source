using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урокehjr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 2;
            Console.Write(n+"="+1);
            while (n > 1)
            {
                while (n%m==0)
                {
                    Console.Write("*" + m);
                    n = n / m;
                }
                m++;
            }
            Console.ReadLine();
        }
    }
}
