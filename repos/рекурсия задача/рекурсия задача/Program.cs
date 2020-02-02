using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсия_задача
{
    class Program
    {
        public static string Shower(int a, int b)
        {
            if (a > b)
            {
                return a + " " + Shower(a - 1,b) ;
            }
            return a.ToString();
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Shower(a, b));
            Console.ReadLine();
        }
    }
}
