using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_по_массимо_ном_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 2, -7, -6, 3, 4 };
            int m = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i]>0)
                {
                    m = m + mass[i];                 
                }
            }
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}
