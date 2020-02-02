using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ввод_вещ_чисел_в_массив_дз_ном_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[,] M = new int[n,3];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите вещественное число с 5 знаками после запятой");
                double r = double.Parse(Console.ReadLine());
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        M[i, j] = (int)r;
                    }
                    else if (j == 1)
                    {
                        M[i, j] = Math.Abs((int)((r-(int)r) * 100000)); 
                    }
                    else if (j == 2)
                    {
                        if (r > 0)
                        {
                            M[i, j] = 0;
                        }
                        else if (r < 0)
                        {
                            M[i, j] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,-10}", M[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
