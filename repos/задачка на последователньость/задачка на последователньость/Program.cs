using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачка_на_последователньость
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);
            while (result != 153)
            {
                while (x > 0)
                {
                    result = result + (x % 10) * (x % 10) * (x % 10);
                    
                    if (x  > 10)
                    {
                        Console.Write(x % 10 + "^" + "3" + "+");
                    } else Console.Write(x % 10 + "^" + "3");
                    x = x / 10;

                }
                Console.WriteLine("=" + result);
                x = result;
                if (result != 153)
                {
                    result = 0;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
