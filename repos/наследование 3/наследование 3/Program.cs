using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование_3
{
    class A
    {
        public int x;
        public A(int x)
        {
            this.x = x;
        }
        public virtual void Show()
        {
            Console.WriteLine("x" + x);
        }
    }
    class B : A
    {
        public int y;
        public B(int x, int y) : base(x)
        {
            this.y = y;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("y" + y);
        }
    }
    class C : A
    {
        public int z;
        public C(int x, int z) : base(x)
        {
            this.z = z;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("z" + z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A[] Mass = { new A(2), new B(5, 1), new C(8, 89) };
            foreach(var element in Mass)
            {
                element.Show();
            }
            Console.ReadLine();
        }
    }
}
