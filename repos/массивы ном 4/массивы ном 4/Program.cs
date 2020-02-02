using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы_ном_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i * i * i;
            }
        }
    }
}
