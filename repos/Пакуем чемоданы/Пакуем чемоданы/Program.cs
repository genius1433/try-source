using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пакуем_чемоданы
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int stemp = s;
            int box = 0;
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp <= s)
                {
                    s -= temp;
                }
                else box += temp;
            }
            Console.WriteLine(stemp - s);
            Console.WriteLine(box);
            Console.ReadLine();
        }
    }
}
