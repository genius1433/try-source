using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_3_нат.число_вычислить_сумму_цифр_с_рекурси
{
    class Program
    {
        static void X(int x, int m, int s)
        {
            if (x > 0)
            {
                m = x % 10;
                x = x / 10;
                s = s + m;
                X(x, m, s);

            }
            else Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = int.Parse(Console.ReadLine());
            int m = 0;
            int s = 0;
            X(x ,m,s);
            Console.ReadLine();
        }
    }
}
