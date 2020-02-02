using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace последвоательность_урок
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double a = 0;
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                a = 1.0 / (i * (i + 1));
                result = result + a;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
