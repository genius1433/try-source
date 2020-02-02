using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трена_памяти
{
    class Person
    {
        public string name;
        public int age;

    }
    class Program
    {
        static void Func(params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
        static void N(ref Person o1)
        {
            o1.name = "Peklo";
            o1 = new Person { name = "L" };
        }
        static void Main(string[] args)
        {
            //Person o1 = new Person {name = "Vadsya", age = 21};
            //N(ref o1);
            //Console.WriteLine(o1.name);
            int x  = 111;
            Func(1,3,5);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
