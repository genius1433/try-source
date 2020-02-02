using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фишки
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 2;
            int y = -1;
            Console.Write("{0,-10}", 1);
            for (int j = 0; j < n / 2; j++)
            {
                for (int i = 0; i < n - 1 - 2 * j; i++)
                {

                    Console.Write("{0,-10}", x);
                    if (y != -1 * (n - 2*j-1))
                    {
                        Console.Write("{0,-10}", y);
                    }
                    x++;
                    y--;
                    
                }
                if (!(j == n / 2 - 1 && n % 2 == 0))
                {
                    Console.Write("{0,-10}", 1);
                }
                x = 2;
                y = -1;
            }
            Console.ReadLine();
        }
    }
}
