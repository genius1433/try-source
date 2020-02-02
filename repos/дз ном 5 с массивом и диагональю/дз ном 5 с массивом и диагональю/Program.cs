using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_5_с_массивом_и_диагональю
{
    class Program
    {
        static void Main(string[] args)
        {
            int u = 0;
            int n = 5;
            Random k = new Random();
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = k.Next(-10, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        u++;
                    }

                }

            }
            Console.WriteLine(u);
            Console.ReadLine();
        }
    }
}
