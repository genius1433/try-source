using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_3_по_массивам_
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
                    if ((j+1)%2>0)
                    {
                        Console.Write("{0,-10}", i+1 + n * j);
                    }
                    else
                    {
                        Console.Write("{0,-10}", (j+1)*n-i);
                    }
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
