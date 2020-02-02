using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кратное_трем_в2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = 0;
            int temp2 = n;
            while (temp2 > 0)
            {
                temp2 = temp2 / 10;
                size++;
            }
            int[] mass = new int[size];
            int sum = 0;
            int q = 0;
            while (n > 0)
            {               
                mass[q] = n % 10;
                n = n / 10;
                q++;
            }
            for (int i = 0; i < mass.Length / 2; i++)
            {
                int temp = mass[i];
                mass[i] = mass[size - i - 1];
                mass[size - i - 1] = temp;
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            if (sum % 3 == 0)
            {
                while (mass[0] + 3 <= 9)
                {
                    mass[0] = mass[0] + 3;
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write(mass[i]);
                }
            }
            else if (sum % 3 == 1)
            {
                mass[0] += 2;
                while (mass[0] + 3 <= 9)
                {
                    mass[0] = mass[0] + 3;
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write(mass[i]);
                }
            }
            else if (sum % 3 == 2)
            {
                mass[0] += 1;
                while (mass[0] + 3 <= 9)
                {
                    mass[0] = mass[0] + 3;
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write(mass[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
