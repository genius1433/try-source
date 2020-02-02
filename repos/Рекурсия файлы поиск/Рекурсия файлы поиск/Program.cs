using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Рекурсия_файлы_поиск
{
    class Program
    {
        //static int result = 0;
        //static string firstname = "C:\\Users\\user\\source\\folder";
        //static void F(string x)
        //{
        //    string[] dirs = Directory.GetDirectories(x);
        //    string[] files = Directory.GetFiles(x);
        //    foreach (var item in files)
        //    {
        //        if (item.EndsWith("txt"))
        //        {
        //            result++;
        //        }
        //    }
        //    foreach (var item in dirs)
        //    {
        //        F(item);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    F(firstname);
        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
        
        static void F(string x, ref int result)
        {
            string[] dirs = Directory.GetDirectories(x);
            string[] files = Directory.GetFiles(x);
            foreach (var item in files)
            {
                if (item.EndsWith("txt"))
                {
                    result++;
                }
            }
            foreach (var item in dirs)
            {
                F(item, ref result);
            }
        }
        static void Main(string[] args)
        {
            int result = 0;
            string firstname = "C:\\Users\\user\\source\\folder";
            F(firstname,  ref result);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
