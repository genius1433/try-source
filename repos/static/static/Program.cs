using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    //class Circle
    //{
    //    public static double S(int r)
    //    {
    //        return Math.PI * r * r;
    //    }
    //}
    //class Class
    //{
    //    public int a;
    //    public static int b;
    //    static Class()
    //    {
    //        b = 0;
    //    }
    //    public Class()
    //    {
    //        a = 2;
    //        b++;
    //    }
    //}
    static class Math1
    {
        static public double Square(double x)
        {
            return x * x;
        }
        static public double Drob(double x)
        {
            return x - (int)x;
        }
        static public int Const = 666;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math1.Drob(6.8));
            //Class one = new Class();
            //Class two = new Class();
            //Console.WriteLine(Class.b);
            //Console.WriteLine(Circle.S(r));
            Console.ReadLine();
            
        }
    }
}
