using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace format
{
    class Person
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person {name = "Vasya", age = 20 };
            Console.WriteLine("name = {0}, age = {1}", obj.name, obj.age);
            string st = string.Format("name = {0}, age = {1}", obj.name, obj.age);
            Console.WriteLine(st);
            double x = 510.242;
            st = string.Format("{0:f2}", x);
            Console.WriteLine(st);
            Console.ReadLine();
        }
    }
}
