using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_с_циферками_и_звездочками_ном_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double epsilon = Math.Pow(10,-33);
            int num = 0;
            double p = 3;
            double v = 8;
            double s = 1;
            while (s > epsilon)
            {
                s = p / v - (p + 1)/(v * 2);
                sum += s;
                p = p + 2;
                v = v * 4;
                num++;
            }
            Console.WriteLine(sum+" "+ num);
            Console.ReadLine();
            
        }
    }
}
