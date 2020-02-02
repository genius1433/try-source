using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[4];
            int temp1 = 100000;
            int temp2 = 100001;
            int temp3 = 0;
            int nomer = 4;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - nomer; i++)
            {
                temp3 = int.Parse(Console.ReadLine());
                if (mass[i % nomer] < temp1 && temp1 != temp2)
                {
                    temp1 = mass[i % nomer];
                }
                if (mass[i % nomer] < temp2 && temp1 != temp2)
                {
                    temp2 = mass[i % nomer];
                }
                mass[i % nomer] = temp3;
            }
            Console.WriteLine(temp1 + temp2);
            Console.ReadLine();
        }
    }
}
