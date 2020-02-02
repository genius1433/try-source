using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_номер_3__но_это_не_точно_ном_1___с_ступ_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предел диапазона");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите предел рандомного массива");
            int m = int.Parse(Console.ReadLine());
            int[][] mass = new int[2][];
            mass[0] = new int[n];
            mass[1] = new int[m];
            Random g = new Random();
            int[] res = new int[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[0][n] = g.Next(0, m);
                    res[mass[0][n]]++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(i + ":" + res[i] + " " + (double)res[i] / (n * n) * 100 + "%");
            }
            Console.ReadLine();
        }
    }
}
