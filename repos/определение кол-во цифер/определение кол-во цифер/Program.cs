using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace определение_кол_во_цифер
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[100];
            int size = 0;
            while (n > 0)
            {
                mass[size] = n % 10;
                n = n / 10;
                size++;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.ReadLine();
        }
    }
}
