using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace дз_по_рекурсии_ном_2
{
    class Program
    {
        static void N(int n ,int[] Mass, int i)
        {
            if (i < n)
            {
                Random k = new Random();
                Mass[i] = k.Next(100);
                Thread.Sleep(100);
                N(n, Mass, i + 1);
            }          
        }
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] Mass = new int[n];
            N(n, Mass, 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,-10}", Mass[i]);
            }
            Console.ReadLine();
        }
    }
}
