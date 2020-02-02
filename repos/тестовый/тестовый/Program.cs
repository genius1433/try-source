using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тестовый
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int c = 0;
            int max = 0;
            int position = 0;
            int joker = 0;
            int clone = 0;
            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = 0;

            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mass[j] == 0)
                    {

                        c++;
                        max = Math.Max(max, c);

                    }
                    else
                    {
                        if (max == c)
                        {
                            position = j;
                        }
                        c = 0;
                    }
                }
                if (max == c)
                {
                    position = n;// - 1 + i;
                }
                mass[(position - max) + max / 2 ] = 1;
                joker = (position - max) + max / 2;               
                clone = max;
                max = 0;
                c = 0;
            }
            Console.WriteLine("Мест свободно справа" + " " + (position - joker - 1));
            Console.WriteLine("Мест свободно слева" + " " + (joker - (position - clone)));
            Console.ReadLine();
        }
    }
}
