using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делимость
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ntemp = 1;
            int result = 0;
            while (ntemp <= n)
            {
                ntemp *= 2;
                result++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
