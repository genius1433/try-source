using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кратное_трем
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во цифер в числе");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("Введите цифру");
                mass[i] = int.Parse(Console.ReadLine());
                sum = sum + mass[i];
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
