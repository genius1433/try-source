using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ряд_чисел_олимпиадная
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 40;
            string result = "";
            if (n % 4 == 1 || n % 4 == 2)
            {
                Console.WriteLine("NET");
            }
            else if (n % 4 == 3)
            {
                result += "--+";
                for (int i = 0; i < (n - 3) / 4; i++)
                {
                    result += "+--+";
                }
                Console.WriteLine(result);
            }
            else if (n % 4 == 0)
            {
                for (int i = 0; i < n / 4; i++)
                {
                    result += "+--+";
                }
                Console.WriteLine(result);
            }
            
            Console.ReadLine();
        }
    }
}
