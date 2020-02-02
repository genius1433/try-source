using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проработка
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int m = 10;
            int[,] mass = new int[n, n];
            int[] res = new int[m];
            Random g = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = g.Next(0,m);
                    res[mass[i, j]]++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(i + ":" + res[i] + " " + (double)res[i]/(n*n) * 100 + "%");
            }
            Console.ReadLine();
        }
    }
}
