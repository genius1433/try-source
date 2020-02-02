using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int number = 0;
            int positive = 0;
            int negative = 0;
            int zero = 0;
            for (int i = 1; i <= x ; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    positive++;
                }
                else if (number < 0)
                {
                    negative++;
                }
                else
                    zero++;
            }
            Console.WriteLine(positive + " " + negative + " " + zero);
            Console.ReadLine();
        }
    }
}
