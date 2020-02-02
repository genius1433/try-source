using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace минимальное_произведение
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int min = 1600000000;
            int temp = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (i != j)
                    {
                        temp = mass[i] * mass[j];
                        if (temp < min)
                        {
                            min = temp;
                        }
                    }
                }
            }
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
