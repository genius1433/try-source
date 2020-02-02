using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пузырек
{
    class Program
    {
        static void Func(int[] x)
        {
            x[0] = x[0] + 1;
        }
        static void Main(string[] args)
        {
            //int[] Mass = { 5, 8, 1, 2, 7 };
            //for (int j = 0; j < Mass.Length - 1; j++)
            //{
            //    for (int i = 0; i < Mass.Length - 1 - j; i++)
            //    {
            //        if (Mass[i] > Mass[i + 1])
            //        {
            //            int temp = Mass[i];
            //            Mass[i] = Mass[i + 1];
            //            Mass[i + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < Mass.Length; i++)
            //{
            //    Console.Write("{0,-10}", Mass[i]);
            //}
            int[] y = { 10 };
            Func(y);
            Console.WriteLine(y[0]);
            Console.ReadLine();
        }
    }
}
