using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace анонимные_делегаты_трена // анонимные методы
{
    class Program
    {
        delegate void Delegate(int x);
        static void Main(string[] args)
        {
            Delegate del = delegate (int x) { Console.WriteLine(x); };
            del(2);
            Fun(4, delegate (int x) { Console.WriteLine(x); });
            Fun(3, Fun1);
            Console.ReadLine();
        }
        static void Fun(int z, Delegate _del)
        {
            _del(z);

        }
        static void Fun1(int n)
        {
            Console.WriteLine(n);
        }
    }
}
