using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследование
{
    class Car
    {
        protected string name;
        protected int year;
        //public Car(int year, string name)
        //{
        //    this.year = year;
        //    this.name = name;
        //}
        public void Show()
        {
            Console.WriteLine("{0,-10},{1,-10}",this.year, this.name);
        }
    }
    class LightCar : Car
    {
        private int a;
        public LightCar(string name,int year, int a)
        {
            this.name = name;
            this.a = a;
            this.year = year;
        }
        public void Change()
        {
            a++;
        }
    }
    class HeavyCar : Car
    {
        private int m;
        private int h;
        public HeavyCar(string name,int year,int m, int h)
        {
            this.name = name;
            this.year = year;
            this.m = m;
            this.h = h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LightCar x = new LightCar("1", 5, 10);
            x.Show();
            HeavyCar c = new HeavyCar("2", 3, 10000, 5);
            c.Show();
            Console.ReadLine();
        }
    }
}
