using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ_из_варика
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mass = { 2, 3, 1, 5, 6, 4};
            //int max = -10000;
            //int result = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] > max)
            //    {
            //        max = mass[i];
            //    }
            //}
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] % 2 == max % 2)
            //    {
            //        result += mass[i];
            //    }
            //}
            //Console.WriteLine(result);
            //Console.ReadLine();           
            int[] mass = { 5, 4, 15, 24, 18, 60 };
            int maxresult = 0;
            int tempresult = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                int temp = mass[i];
                while (temp > 0)
                {
                    tempresult += temp % 10;
                    temp = temp / 10;
                }
                if (tempresult > maxresult)
                {
                    maxresult = tempresult;
                }
                tempresult = 0;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
