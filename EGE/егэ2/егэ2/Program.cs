using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[8];
            int temp1 = 0;
            int temp2 = 0;
            int temp3 = 0;
            int nomer = 8;
            for (int i = 0; i < 8; i++)
            {               
                mass[i] = int.Parse(Console.ReadLine());               
            }
            for (int i = nomer; i < n; i++)
            {
                temp3 = int.Parse(Console.ReadLine());
                if (mass[i % nomer] > temp1)
                {
                    temp1 = mass[i % nomer];
                }
                if (temp3 * temp1 > temp2)
                {
                    temp2 = temp3 * temp1;
                }
                mass[i % nomer] = temp3;
            }
            Console.WriteLine(temp2);
            Console.ReadLine();
        }
    }
}
