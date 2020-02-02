using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сенокосилки
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double sum = m;
            for (int i = 1; i < n; i++)
            {
                m = m + 10;
                sum = sum + m;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
