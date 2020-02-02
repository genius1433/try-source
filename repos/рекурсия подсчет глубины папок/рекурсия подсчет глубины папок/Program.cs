using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace рекурсия_подсчет_глубины_папок
{
    class Program
    {
        static int F(string x, int result)
        {
            int max = 0;
            int current = 0;
            string[] dirs = Directory.GetDirectories(x);
            foreach (var item in dirs)
            {
                current = F(item, result);
                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            string firspath = @"C:\Users\user\source\folder";
            int result = 0;
            Console.WriteLine(F(firspath, result));
            Console.ReadLine();
        }
        //static int result = 0;
        //static int F(string x, int result)
        //{
        //    int max = 0;
        //    int current = 0;
        //    string[] dirs = Directory.GetDirectories(x);
        //    foreach (var item in dirs)
        //    {
        //        current = F(item, result + 1);

        //    }
        //    if (current > max)
        //    {
        //        max = current;
        //    }
        //    return max;
        //}
        //static void Main(string[] args)
        //{
        //    string firspath = @"C:\Users\user\source\folder";
        //    //int result = 0;
        //    Console.WriteLine(F(firspath, result));
        //    Console.ReadLine();
        //}
    }
}
