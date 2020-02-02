using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace делегаты_простая_трена
{
    delegate int del(int x, int y);
    class Program
    {
        static int Func(int x, int y)
        {
            Console.WriteLine("0");
            return x * y;
        }
        static int Func1(int x, int y)
        {
            Console.WriteLine("1");
            return x + y;
        }
        static int Func2(int x, int y)
        {
            Console.WriteLine("2");
            return x - y;
        }
        static int Func3(int x, int y)
        {
            Console.WriteLine("3");
            return x / y;
        }
        static void Main(string[] args)
        {
            del a = Func;
            a += Func1;
            a += Func1; //a += Func1; a += Func1; a += Func1; a += Func1; a += Func1; a += Func1; a += Func1; a += Func1; a += Func1; a += Func1;
            a += Func2;
            a += Func3; //a += Func3; a += Func3; a += Func3; a += Func3; a += Func3; a += Func3; a += Func3; a += Func3; a += Func3; a += Func3; a += Func3;
            Console.WriteLine(a(66, 6));
            Console.ReadLine();
        }
    }
}
