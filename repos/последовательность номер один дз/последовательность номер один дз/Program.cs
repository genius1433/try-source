using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace последовательность_номер_один_дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = 0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                x = 1 / Math.Pow(2 * n, 2);
                sum = sum + x;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
