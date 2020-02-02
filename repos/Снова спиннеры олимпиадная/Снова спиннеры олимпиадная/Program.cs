using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Снова_спиннеры_олимпиадная
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fourth = n % 3;
            int three = (n - 4 * fourth) / 3;
            if (three < 0)
            {
                Console.WriteLine(0 + " "  + 0);
            }
            else Console.WriteLine(three + " " + fourth);
            Console.ReadLine();
        }
    }
}
