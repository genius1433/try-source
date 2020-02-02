using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_номер_один_max_product_if_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] M = new int[] { 10, 5, 2, 0, -5, -100, 4 };
            //int p = 0;
            //int x = 0;
            //int c = 0;
            //int n = 0;
            //int m = 0;
            //for (int i = 0; i < 7; i++)
            //{
            //    if (x < M[i])
            //    {
            //        if (M[i] > 0)
            //        {
            //            x = M[i];
            //        }                    
            //    }
            //    if (c < M[i] && M[i] != x)
            //    {
            //        if (M[i] > 0)
            //        {
            //            c = M[i];
            //        }
            //    }
            //    if (p < M[i] && M[i] != x && M[i] != c)
            //    {
            //        if (M[i] > 0)
            //        {
            //            p = M[i];
            //        }
            //    }
            //    if (n > M[i])
            //    {
            //        if (M[i] < 0)
            //        {
            //            n = M[i];
            //        }
            //    }
            //    if (m > M[i]) //&& M[i] != n)
            //    {
            //        if (M[i] < 0)
            //        {
            //            m = M[i];
            //        }
            //    }               
            //}
            //if (x * c > n * m)
            //{
            //    Console.Write("{0,-10}", x * c * p);
            //}
            //else Console.Write("{0,-10}", n * m * x);
            int[] M = new int[] {1,7,2,3,6};
            
            for (int i = 0; i < 2; i++)
            {
                int k = i;
                for (int j = i + 1; j < M.Length; j++)
                {
                    if (M[j] < M[k])
                    {
                        k = j;
                    }

                }
                int temp = M[i];
                M[i] = M[k];
                M[k] = temp;
            }
            for (int i = M.Length - 1; i >= M.Length - 3; i--)
            {
                int k = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (M[j] > M[k])
                    {
                        k = j;
                    }

                }
                int temp = M[i];
                M[i] = M[k];
                M[k] = temp;

            }
            int p = M[M.Length - 3];
            int q = M[M.Length - 2];
            if (M[0] * M[1] > M[M.Length-3] * M[M.Length - 2] && M[M.Length-1] > 0)
            {
                p = M[0];
                q = M[1];
            }
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write("{0,-10}", M[i]);
            }
            Console.WriteLine();
            Console.Write("{0,-10 }{1,-10 }{2,-10 }", p, q, M[M.Length - 1]);
            
            Console.ReadLine();
        }
        
    }
}
