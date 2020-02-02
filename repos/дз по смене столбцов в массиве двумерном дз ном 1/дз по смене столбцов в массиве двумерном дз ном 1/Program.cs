using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_по_смене_столбцов_в_массиве_двумерном_дз_ном_1
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
        static void P(int n, int[][] M)
        {
            int min = Sum(n, M, 0);
            int max = Sum(n, M, 0);
            int minIndex = 0;
            int maxIndex = 0;           
            for (int i = 1; i < n; i++)
            {
                int sum = Sum(n, M, i);
                if (sum < min)
                {
                    min = sum;
                    minIndex = i;
                }
                if (sum > max)
                {
                    max = sum;
                    maxIndex = i;
                }
            }            
            Swap(M, minIndex, maxIndex, n);

        }
        static void Swap(int[][] M, int minIndex, int maxIndex, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = M[i][minIndex];
                M[i][minIndex] = M[i][maxIndex];
                M[i][maxIndex] = temp;
            }
        }
        static int Sum(int n, int[][] M, int index)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
               result = result + M[i][index];
            }
            return result;
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
            P(n, M);
            Console.WriteLine();
            Matr(n, M);
            Console.ReadLine();
        }
    }
}
