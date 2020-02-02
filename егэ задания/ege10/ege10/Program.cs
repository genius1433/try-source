using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ege10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            N = int.Parse(Console.ReadLine());
            long min = -1000000001;
            int j = 0, k = 0, c = 0;
            for (int i = 1; i <= N; ++i)
            {
                int num;
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                    j = i;
                if (num < 0)
                {
                    c += 1;
                    if (min < num)
                    {
                        min = num;
                        k = i;
                    }
                }
            }
            for (int i = 1; i <= N; ++i)
            {
                if (i != j && (c % 2 == 0 || i != k))
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
