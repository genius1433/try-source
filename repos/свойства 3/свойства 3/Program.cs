using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace свойства_3
{
    class Person
    {
        //private int age;
        public Person(int age)
        {
            Age = age;
        }
        public int Age
        {
            get;
            set;
        }
        //public void SetAge(int age)
        //{
        //    if (age < 150 && age > 0) { this.age = age; } else this.age = 0;
        //}
        //public int GetAge()
        //{
        //    return this.age;
        //}
        //public int Age
        //{
        //    get
        //    {
        //        return this.age;
        //    }
        //    set
        //    {
        //        if (value < 150 && value > 0) { this.age = value; } else this.age = 0;
        //    }
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person(-12);
            obj.Age = 20;
            Console.WriteLine(obj.Age);
            Console.ReadLine();
        }
    }
}
