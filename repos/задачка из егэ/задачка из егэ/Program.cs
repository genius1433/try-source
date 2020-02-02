using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачка_из_егэ
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] n = {2,3,1,5,6,4 };
            //int m = 0;
            //int k = 1;
            //Random z = new Random();
            //for (int i = 0; i < n.Length; i++)
            //{
            //    //n[i] = z.Next(0, 1001);
            //    k = k * n[i];
            //}
            //for (int i = 0; i < n.Length; i++)
            //{
            //    if(k % 2 == n[i] % 2 && n[i] > m)
            //    {
            //        m = n[i];
            //    }
            //}
            //Console.WriteLine(m);
            int[] a = {80,91,162,250};
            int m = 0;
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 10 == a[i] % 16 && m < a[i])
                {
                    m = a[i];
                }
            }
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}
