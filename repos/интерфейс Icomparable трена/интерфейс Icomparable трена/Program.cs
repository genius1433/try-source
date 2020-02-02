using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace интерфейс_Icomparable_трена
{
    class Human : IComparable <Human>
    {
        public string name;
        public int age;
        public int CompareTo(Human o)
        {
            return this.name.CompareTo(o.name);
        }
    }
    class HumanComprarer : IComparer<Human>
    {
        public int Compare(Human h1, Human h2)
        {
            if (h1.name.Length > h2.name.Length)
            {
                return 1;
            }
            else if (h1.name.Length < h2.name.Length)
            {
                return -1;
            }
            else return 0;
        }
    }
    class HumanComprarer1 : IComparer<Human>
    {
        public int Compare(Human h1, Human h2)
        {
            if (h1.age > h2.age)
            {
                return 1;
            }
            else if (h1.age < h2.age)
            {
                return -1;
            }
            else return 0;
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            int[] mass = { 0, 3, 2, 8, 9 };
            Array.Sort(mass);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);

            }
            Human o1 = new Human { name = "noname", age = 0};
            Human o2 = new Human { name = "vetya", age = 333 };
            Human o3 = new Human { name = "pacya", age = 2 };
            Human[] humen = new Human[] {o1, o2, o3 };
            Array.Sort(humen, new HumanComprarer1());
            for (int i = 0; i < humen.Length; i++)
            {
                Console.WriteLine(humen[i].name);
            }
            Console.ReadLine();
        }
    }
}
