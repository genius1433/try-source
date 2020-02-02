using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсия_на_отрицательную_степень
{
    class Program
    {
        static double N(double x,int n)
        {
            if (n > 0)
            {                
                return x * N(x, n - 1);               
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(">0");
            double x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            bool t = true;
            if (n < 0)
            {
                t = false;
            }
            if (t == true)
            {
                Console.WriteLine(N(x, Math.Abs(n)));
            }
            else
            {
                Console.WriteLine(1 / N(x, Math.Abs(n)));
            }           
            Console.ReadLine();
        }
    }
}
