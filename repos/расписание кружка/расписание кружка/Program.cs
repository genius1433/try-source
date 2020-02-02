using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace расписание_кружка
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            while (m <= 12)
            {
                Console.WriteLine(m + " " + d);
                d = d + 7;
                if (m % 2 == 0 && d > 31)
                {
                    d = d - 31;
                    m++;
                }
                else if (m % 2 == 1 && d > 30)
                {
                    d = d - 30;
                    m++;
                }              
            }
            Console.ReadLine();
        }
    }
}
