using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[6];
            int temp1 = 10000000;
            int temp2 = 10000000;
            int temp3 = 0;
            int nomer = 6;
            for (int i = 0; i < 6; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = nomer; i < n; i++)
            {
                temp3 = int.Parse(Console.ReadLine());
                if (mass[i % nomer] < temp1)
                {
                    temp1 = mass[i % nomer];
                }
                if (temp3 * temp1 < temp2 && temp3 * temp1 % 2 == 0)
                {
                    temp2 = temp3 * temp1;
                }
                mass[i % nomer] = temp3;
            }
            if (temp2 == 10000000)
            {
                Console.WriteLine(-1);
            }
            else Console.WriteLine(temp2);
            Console.ReadLine();
        }
    }
}
