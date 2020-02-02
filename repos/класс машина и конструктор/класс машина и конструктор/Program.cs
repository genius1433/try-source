using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класс_машина_и_конструктор
{
    class Machina
    {
        public int v;
        public int a;
        public int m;
        public double mileage;
        public double benzinlit;
        public Machina(int v, int a, int m)
        {
            this.v = v;
            this.a = a;
            this.m = m;
        }
        public Machina()
        {
            this.mileage = 10.5;
            this.benzinlit = 1000.241;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Machina one = new Machina(0,10,666);
            Machina two = new Machina();
            Console.ReadLine();
        }
    }
}
