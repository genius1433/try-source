using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace квартирки__сложно
{
    class Program
    {
        static int Fu(int[] mass,int i)
        {
            if (mass[i] <= 36)
            {
                return (mass[i] - 1) / 4;
            }
            else
            {
                return 8 - (mass[i] - 37) / 2  ;
            }
        }
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите кол-во свободных мест");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int k = 0;
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("Введите номер свободного вагона до 54");
                mass[i] = int.Parse(Console.ReadLine());
                counter[Fu(mass, i)]++;
            }
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] == 6)
                {
                    k++;
                    max = Math.Max(max, k);
                }
                else
                {
                    k = 0;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
