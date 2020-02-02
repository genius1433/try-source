using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace интересные_тапочки
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] M = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                M[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (M[i] - M[i-1] != 1)
                {
                    k++;
                }
            }
            Console.Write(k);
            Console.ReadLine();
        }
    }
}
