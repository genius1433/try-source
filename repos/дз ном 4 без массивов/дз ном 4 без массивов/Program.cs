using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_4_без_массивов
{
    class Program
    {
        static void Z( int N)
        {
            
            if (N > 0)
            {
                Console.WriteLine("Введите число");
                int f = int.Parse(Console.ReadLine());
                Z(N - 1);
                Console.Write("{0,-10}", f);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел должно быть?");
            int N = int.Parse(Console.ReadLine());
            Z( N);
            Console.ReadLine();
        }
    }
}
