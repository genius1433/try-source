using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив_матрица_ref_или_out
{
    class Program
    {
        public static void Func(ref int min, ref int max, int[,] mass, int m, int indexermass2, int[] mass2 )
        {
            min = 999999;
            max = -99999;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mass[i, j] = m;
                    m++;
                }
            }
            m = 1;
            for (int i = 0; i < 3 - 1; i++)
            {
                for (int j = 0; j < 3 - i - 1; j++)
                {
                    mass2[indexermass2] = m;
                    indexermass2++;
                    m++;
                }
                m++;
            }
            for (int i = 0; i < mass2.Length; i++)
            {
                if (mass2[i] > max)
                {
                    max = mass2[i];
                }
                if (mass2[i] < min)
                {
                    min = mass2[i];
                }
            }
        }
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            int m = 1;
            int[] mass2 = new int[3];
            int indexermass2 = 0;
            int[,] mass = new int[3, 3];
            Func(ref min, ref max, mass, m, indexermass2, mass2);         
            Console.WriteLine(max + " " + min);
            Console.ReadLine();
        }
    }
}
