using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    class Human
    {
        public string name, surname;
        public int age;
        public void Say()
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", name, surname, age);
        }
    }
    class Pri
    {
        public int a, b;
        public void S()
        {
            Console.WriteLine(a * b);
        }
        public void P()
        {
            Console.WriteLine(2 * a + 2 * b);
        }
    }

    class Program
    {
        static int M(int a, int b)
        {

        }
        static void Main(string[] args)
        {
            Human human = new Human("Man", "Men", 0);
            human.name = "Man";
            human.surname = "Men";
            human.age = 0;
            human.Say();
            Console.ReadLine();
            Pri pri = new Pri();
            pri.a = 4;
            pri.b = 5;
            Pri pre = new Pri();
            Pri[] L = { new Pri(), new Pri(), new Pri() };
            for (int i = 0; i < L.Length; i++)
            {
                L[i].a = 2 * i;
                L[i].b = 3 * i;
                L[i].S();
                L[i].P();
            }
            Console.ReadLine();
        }
    }
}
