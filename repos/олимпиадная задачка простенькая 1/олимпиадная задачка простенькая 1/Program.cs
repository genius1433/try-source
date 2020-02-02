using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace олимпиадная_задачка_простенькая_1
{
    class Program
    {
        //static public void F(int n, int ncent)
        //{
        //    if (ncent > 0)
        //    {
        //        for (int i = 0; i < n - ncent; i++)
        //        {
        //            Console.Write("1+");
        //            if (i == n - ncent - 1 && n - i + 1 != 0)
        //            {
        //                Console.WriteLine(n - i - 1);
        //            }
        //        }
        //        F(n,ncent - 1);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    int n = 6;
        //    F(n, n);
        //    Console.ReadLine();
        //}
        static int[] mass = new int[100];
        static public void F(int n, int ntemp, int k)
        {
            if (n < 0)
            {
                return;
            } else if(n == 0)
            {
                for (int i = 0; i < k; i++)
                {
                    if (mass[i] != 6 && i + 1 != k)
                    {
                        Console.Write(mass[i] + "+");
                    }
                    else if (mass[i] != 6) { Console.Write(mass[i]); }
                }
                Console.WriteLine();
            }
            else
            {
                if (n - ntemp >= 0)
                {
                    mass[k] = ntemp;
                    F(n - ntemp, ntemp, k + 1);
                }
                if (ntemp - 1 > 0)
                {
                    F(n, ntemp - 1, k);
                }
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = 0;
            }
            F(n, n, 0);
            Console.ReadLine();
        }
    }
}
