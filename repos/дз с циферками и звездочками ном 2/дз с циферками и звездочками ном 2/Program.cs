using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_с_циферками_и_звездочками_ном_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x;i++)
            {
                if (i == 1 || i == x)
                {
                    for (int j= 1; j <= x; j++)
                    {
                        Console.Write("{0,4}",i);
                    }
                }
                else 
                {
                    for (int j = 1; j <= x; j++)
                    {
                        if (j == 1 || j == x)
                        {
                            Console.Write("{0,4}", i);
                        }
                        else
                            Console.Write("{0,4}", "*");
                    }                    
                }
                

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
