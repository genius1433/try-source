using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы_задача_ном_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 2, 7, 6, 3, 4 };
            int m = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    m = m + 1;
                }
            }
            int[] mass2 = new int[m];
            int k = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    mass2[k] = mass[i];
                    k++;
                }
            }
            foreach (var item in mass2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
