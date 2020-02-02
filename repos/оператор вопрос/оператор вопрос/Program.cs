using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace оператор_вопрос
{
    class Program
    {
        static void Main(string[] args)
        {

            //double sinc(double x) => x != 0.0 ? Math.Sin(x) / x : 1;
            //Console.WriteLine(sinc(0.1));
            //Console.WriteLine(sinc(0.0));
            int input = new Random().Next(-5, 5);

            string classify;
            if (input >= 0)
            {
                classify = "nonnegative";
            }
            else
            {
                classify = "negative";
            }

            classify = (input >= 0) ? "nonnegative" : "negative"; // то же самое что и ифки то бишь вопрос спрашивает так ли это? если да то 1 варинат иначе после доветочия
            Console.ReadLine();
        }
    }
}
