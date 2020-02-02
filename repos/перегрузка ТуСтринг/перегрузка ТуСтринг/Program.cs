using System;
using 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка_ТуСтринг
{
    class Human
    {
        public string name;
        public int age;
        public Human()
        {
            this.name = "Axmed";
            this.age = 100;
        }
        public override string ToString()
        {
            return $"{name} имя {age} стар";
        }
        public override bool Equals(object obj)
        {
            Human human = obj as Human;
            if (human != null)
            {
                if (this.name == human.name)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(new Human());
            Console.ReadLine();
        }
    }
}
