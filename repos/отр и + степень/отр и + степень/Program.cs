using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace отр_и___степень
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double result = 1;
            bool t = true;
            if (n > 0)
            {         }
            else
            {
                t = false;
            }
            for (int i = 0; i < Math.Abs(n); i++)
            {
                result = result * x;
            }
            if (t == true)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(1 / result);
            }
            Console.ReadLine();
        }
    }
}
