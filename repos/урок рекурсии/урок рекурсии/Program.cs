using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_рекурсии
{
    class Program
    {
        static void N(int n)
        {
            Console.Write("{0,-10}", n);
            if (n>0)
            {
                N(n - 1);
            }
            
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            N(n);            
            Console.ReadLine();
        }
    }
}
