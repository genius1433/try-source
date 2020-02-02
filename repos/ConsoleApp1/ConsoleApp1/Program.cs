using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //комментарий 
            /* многострочный коммент
             */
            //int x = 10;
            //int y = 100;
            //int z = y * x;
            //char u = '(';
            //double i = 2.5;
            //string o = "rasrra";
            //bool p = true;
            //var a = 5.4;
            ////
            ////Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(z);
            //int x = 10;
            //if (x>0)
            //{
            //    Console.WriteLine("сообщение");
            //}
            //else if(x<0)
            //{
            //    Console.WriteLine("сообщение2");
            //}
            //else
            //{
            //    Console.WriteLine("Сщбщение0");
            //}
            //for (int i = 0; i<100; i++)
            //{
            //    Console.WriteLine("Вася");

            //}
            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i * i);
            //}
            //Console.ReadLine();
            //for (int i = 10; i > 0; i=i-2)
            //{
            //    Console.WriteLine(i);
            //}
            //int x = int.Parse(Console.ReadLine());
            //string c = "";
            //for (int i = 0; i < x; i++)
            //{
            //    c = c + "*";
            //}
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine(c);

            //}
            int a = 2;
            int b = 10;
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                s = s + i;
               
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
