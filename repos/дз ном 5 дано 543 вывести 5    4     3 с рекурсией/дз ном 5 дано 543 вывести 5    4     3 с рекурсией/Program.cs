using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_5_дано_543_вывести_5____4_____3_с_рекурсией
{
    class Program
    {
        static void X(int x)
        {
            int m = 0;
            if (x > 0)
            {
                m = x % 10;
                x = x / 10;                             
                X(x);
                Console.Write("{0,-10}", m);         
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = int.Parse(Console.ReadLine());
            X(x);
            Console.ReadLine();
        }
    }
}
