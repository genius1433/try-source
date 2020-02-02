using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вывод_макс_числа_в_матрице_дз_ном_2
{
    class Program
    {
        static void Ran(int n, int[][] M)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i][j] = random.Next(100);
                }
            }
        }
        static void Matr(int n, int[][] M)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-10}", M[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Max(int n, int[][] M)
        {
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (M[j][i] > max)
                    {
                        max = M[j][i];
                    }              
                }
                Console.Write("{0,-10}", max);
                max = 0;
            }
            
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] M = new int[n][];
            for (int i = 0; i < n; i++)
            {
                M[i] = new int[n];
            }
            Ran(n, M);
            Matr(n, M);
            Console.WriteLine();
            Max(n, M);
            Console.ReadLine();
        }
    }
}
