using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фигуры_и_наследование_дз
{
    abstract class Fig
    {
        protected string name;
        public Fig(string name)
        {
            this.name = name;
        }
        public Fig()
        {
            this.name = "";
        }
        public virtual void Show()
        {
            Console.WriteLine(name);
        }
        public abstract void P();
        public abstract void S();
    }
    abstract class Fourx : Fig
    {
        protected int a;
        protected int b;
        public Fourx(int a, int b, string name) : base(name)
        {
            this.a = a;
            this.b = b;
        }
        public Fourx()
        {
            a = 0;
            b = 0;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(a + " " + b);
        }
        public override void P()
        {
            Console.WriteLine("P" + "=" + (int)( a +  a + b + b));
        }

    }
    class Priamoygolnik : Fourx
    {
        public Priamoygolnik(int a, int b, string name) : base(a,b,name)
        {

        }
        public override void S()
        {
            Console.WriteLine("S" + "=" + (int)(a * b));
        }
    }
    class Parallelogram : Fourx
    {
        public int h;
        public Parallelogram(int h,int a, int b, string name) : base(a,b,name) 
        {
            this.h = h;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(h);
        }
        public override void S()
        {
            Console.WriteLine("S" + "=" + a * h);
        }
    }
    class Trapekia : Fourx
    {
        public int h;
        public Trapekia(int h,int a, int b, string name) : base(a,b,name)
        {
            this.h = h;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine( h);
        }
        public override void S()
        {
            Console.WriteLine("S" + "=" + ((a + b) / 2) * h);
        }
    }
    class Kryg : Fig
    {
        public double r;
        public Kryg(int r,string name) : base(name)
        {
            this.r = r;
        }
        public Kryg()
        {
            this.r = 0;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(r);
        }
        public override void S()
        {
            Console.WriteLine("S" + "=" + r * r * Math.PI);
        }
        public override void P()
        {
            Console.WriteLine("P" + "=" + r *  Math.PI * 2);
        }

    }
    class Treyg : Fig
    {
        protected int a;
        protected int b;
        protected int c;
        public Treyg(int a, int b, int c, string name) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Treyg()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(a + " " + b + " " + c);
        }
        public override void P()
        {
            Console.WriteLine("P" + "=" + (int)(a + b + c));
        }
        public override void S()
        {
            double p = (a + b + c) / 2;
            Console.WriteLine("S" + "=" + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Fig[] fig = {new Priamoygolnik(4,5,"пр"), new Parallelogram(3,5,7,"пар"), new Trapekia(2,11,4,"тра"), new Kryg(2,"кр"), new Treyg(5,4,3,"тр") };
            foreach (var element in fig)
            {
                element.Show();
                element.P();
                element.S();
            }
            Console.ReadLine();
        }
    }
}
