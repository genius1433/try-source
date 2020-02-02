using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace двойной_факториал_дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int c = 1;
            if (x % 2 == 0)
            {
                for (int i = 2; i <= x;)
                {
                    c = c * i;
                    i = i + 2;
                }
            }
            else
            {
                for (int i = 1; i <= x;)
                {
                    c = c * i;
                    i = i + 2;
                }
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
