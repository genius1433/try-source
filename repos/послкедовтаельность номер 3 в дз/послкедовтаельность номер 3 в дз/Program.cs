using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace послкедовтаельность_номер_3_в_дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                sum = sum + i;
                result = result * sum;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
