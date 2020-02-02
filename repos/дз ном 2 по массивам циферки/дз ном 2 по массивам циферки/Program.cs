using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_2_по_массивам_циферки
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int n = int.Parse(Console.ReadLine());
            int[,] myArr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-10}", x+n*j);
                }
                Console.WriteLine();
                x++;
            }
            Console.ReadLine();
        }
    }
}
