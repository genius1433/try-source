using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Покупка_олимпиадная
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            k = 100 * k + p * k;
            Console.WriteLine(s * 100 / k);
            Console.ReadLine();
        }
    }
}
