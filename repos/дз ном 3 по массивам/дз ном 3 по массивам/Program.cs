using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_3_по_массивам
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            int y = 1;
            int[,] mass = new int[n, n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 > 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,4}", x);
                        x = x + 1;
                    }
                }
                else
                {
                    y = x + n - 1;
                    for (int j = 0; j < n ; j++)
                    {
                        Console.Write("{0,4}", y);
                        y--;
                        x++;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
