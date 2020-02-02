using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ7
{
    class Program // номер 5 из подмножеств
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double temp = 0;
            double min = 9999999;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                temp = double.Parse(Console.ReadLine());
                if (temp > 1)
                {
                    counter++;
                    if (temp < min)
                    {
                        min = temp;
                    }
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
