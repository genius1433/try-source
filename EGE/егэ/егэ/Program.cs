using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxR = int.Parse(Console.ReadLine());
            int maxR2 = -1;
            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (i != j && mass[i] + mass[j] > maxR2 && (mass[i] + mass[j]) % 2 == 1)
                    {
                        maxR2 = mass[i] + mass[j];
                    }
                }
            }
            if (maxR == maxR2)
            {
                Console.WriteLine("Контроль пройден");

            }
            else Console.WriteLine("Контроль не пройден");
            Console.ReadLine();
        }
    }
}
