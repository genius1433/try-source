using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы_задача_ном_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 2, -7, -6, 3, 4 };
            int x;
            for (int i = 0; i < mass.Length/2; i++)
            {
                x = mass[i];
                mass[i] = mass[mass.Length - i - 1];
                mass[mass.Length - i - 1] = x;
            }
            foreach(int item in mass)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
