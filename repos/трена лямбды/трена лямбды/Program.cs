using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трена_лямбды
{
    class Program
    {
        delegate int Del(int x, int y);
        delegate int Del1(int x);
        //static int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        static void Main(string[] args)
        {
            //Del obj1 = delegate(int x, int y) { return x + y; };
            Del obj1 = (x, y) => x + y;
            Del1 obj2 = x => x * x;
            Console.WriteLine(obj1(4, 5));
            Console.WriteLine(obj2(122));
            Console.ReadLine();
        }
    }
}
