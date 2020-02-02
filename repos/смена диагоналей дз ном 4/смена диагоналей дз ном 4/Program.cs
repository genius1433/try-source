using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace смена_диагоналей_дз_ном_4
{
    class Program
    {
        static void Matr(int n, int[,] arr, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = m;
                    Console.Write("{0,-10}", arr[i, j]);
                    m++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x = 0;
            int m = 1;
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            Matr(n, arr, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        x = arr[i, j];
                        for (int k = 0; k < n; k++)
                        {
                            if (i == n-k-1)
                            {
                                arr[i, j] = arr[i, k];
                                arr[i, k] = x;
                                break;
                            }

                        }
                        break;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-10}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
