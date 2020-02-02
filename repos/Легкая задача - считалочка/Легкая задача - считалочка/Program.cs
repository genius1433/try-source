using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Легкая_задача___считалочка
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int person = 0;
            if (n <= m)
            {
                person = n;
            }
            else person = m % n;
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
