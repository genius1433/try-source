using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string c = "*";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }
            for (int i = 1; i <= x; i++)
            {
                for (int j = i; j <= x; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= x; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(c);
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            for (int i = 1; i < x; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(" ");
                }
                for (int j = x; j > i; j--)
                {
                    Console.Write(c);
                }
                for (int j = i; j < x - 1; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
