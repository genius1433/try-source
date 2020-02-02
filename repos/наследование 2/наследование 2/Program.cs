using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_2
{
    class A
    {
        public int x;
        public A(int x)
        {
            this.x = x;
        }
        public A()
        {
            x = 0;
        }
    }
    class B : A
    {
        public int y;
        public B(int x, int y) : base(x)
        {
            this.y = y;
        }
        public B()
        {
            this.y = 0;
        }
        public void Show()
        {
            Console.WriteLine(x + " " + y);
        }
    }
    class C
    {
        public int z;
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b= new B(2,7);
            A a = new A(6);
            C c = new C();
            a = b;
            Console.WriteLine(((B)a).y);
            Console.ReadLine();
        }
    }
}
