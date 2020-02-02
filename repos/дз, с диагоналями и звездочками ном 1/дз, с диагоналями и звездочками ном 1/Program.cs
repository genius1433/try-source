using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз__с_диагоналями_и_звездочками_ном_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int x = int.Parse(Console.ReadLine());
            string c = "";
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j >= 1; j--)
                {
                    if (i == j)
                    {
                        Console.Write("{0,4 }", j);
                    }
                    else Console.Write("{0,4 }", "*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
