using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вазы_с_конфетами
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] mass = new int[3];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i > -1; i++)
            {
                if (mass[0] > 0)
                {
                    mass[0]--;
                    result++;
                }
                else break;
                if (mass[1] > 0)
                {
                    mass[1]--;
                    result++;
                }
                else break;
                if (mass[2] > 0)
                {
                    mass[2]--;
                    result++;
                }
                else break;
                if (mass[1] > 0)
                {
                    mass[1]--;
                    result++;
                }
                else break;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
