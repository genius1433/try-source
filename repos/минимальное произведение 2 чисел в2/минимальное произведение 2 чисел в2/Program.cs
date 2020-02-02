using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace минимальное_произведение_2_чисел_в2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = -40001;
            int max2 = -40001;
            int min = 40001;
            int min2 = 40001;
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max2 = max;
                    max = x;
                }
                else if(x > max2)
                {
                    max2 = x;
                }
                if (x < min)
                {
                    min2 = min;
                    min = x;
                }
                else if (x < min2)
                {
                    min2 = x;
                }
            }
            Console.WriteLine(Math.Min(Math.Min(min * max, min * min2), max2 * max));
            Console.ReadLine();
        }
    }
}
