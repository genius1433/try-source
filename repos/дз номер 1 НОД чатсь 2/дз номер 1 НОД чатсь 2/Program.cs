using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_номер_1_НОД_чатсь_2
{
    class Program
    {
        static void N(int a, int b)
        {
            if (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
                N(a, b);
            } else Console.WriteLine(a);

        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            N(a, b);
            Console.ReadLine();
        }
    }
}
