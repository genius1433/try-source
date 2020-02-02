using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int f(int x) 
        { 
            return (Math.Abs(Math.Abs(x - 6) + Math.Abs(x + 6) - 16) + 2); 
        }

        static void Main(string[] args)
        {
            //    int[] mass = new int[]{ 2, 6, 12, 17, 3, 8 };
            //    int count = 0;
            //    if (mass.Sum() % 2 == 1)
            //    {
            //        for (int i = 0; i < mass.Length; i++)
            //        {
            //            if (mass[i] % 2 == 1)
            //            {
            //                count++;
            //            }
            //        }
            //    }
            //    else 
            //    {
            //        for (int i = 0; i < mass.Length; i++)
            //        {
            //            if (mass[i] % 2 == 0)
            //            {
            //                count++;
            //            }
            //        }
            //    }
            //    Console.WriteLine(count);
            // int a;
            //int b;
            //    int x = 501;
            //    a = 0; 
            //    b = 1;
            //    while (x > 0) 
            //    {       
            //    a = a+1;        
            //    b = b* (x%100);       
            //    x = x/100;   
            //    }
            //    Console.WriteLine(a + " " + b);

            int a; 
            int b;
            int t;
            int M;
            int R;
            a = -20;
            b = 20;
            M = a;
            R = f(a); 
            for (t = a; t <= b; ++t) 
            { 
                if (f(t) <= R) 
                { 
                    M = t; R = f(t); 
                } 
            }
            Console.WriteLine(M + R);
            Console.ReadLine();
        }
    }
}
