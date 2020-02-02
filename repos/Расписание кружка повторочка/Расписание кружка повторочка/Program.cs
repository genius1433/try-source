using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расписание_кружка_повторочка
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            while (n <= 12)
            {
                Console.WriteLine(n + " " + k);
                k += 7;
                if (n == 10 || n == 12 && k > 31)
                {
                    n++;
                    k -= 31;
                }
                else if (n == 9 || n == 11 && k > 30)
                {
                    n++;
                    k -= 30;
                }
            }
            Console.ReadLine();
        }
    }
}
