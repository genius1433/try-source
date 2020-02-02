using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace человек_школьник__наследование_и_полиморфизм
{
    class Human
    {
        protected string name;
        protected int id;
        public Human(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public Human()
        {
            name = "";
            id = 0;
        }
        public virtual bool IsProfi()
        {
            return true;
        }
        public virtual void Show()
        {
            Console.WriteLine(name + " " + id);
        }
    }
    class Teacher : Human
    {
        private int hours;
        public Teacher()
        {
            hours = 0;
        }
        public Teacher(string name, int id, int hours) : base(name, id)
        {
            this.hours = hours;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(hours);
        }
        public override bool IsProfi()
        {
            if (hours > 10)
            {
                return true;
            }
            return !true;
        }
    }
    class Cleaner : Human
    {
        private int windows;
        public Cleaner()
        {
            windows = 0;
        }
        public Cleaner(string name, int id, int windows) : base(name, id)
        {
            this.windows = windows;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(windows);
        }
        public override bool IsProfi()
        {
            if (windows > 10)
            {
                return true;
            }
            return !true;
        }

    }
    class Student : Human
    {
        private int[] marks;
        public Student()
        {

        }
        public Student(string name, int id, int[] marks) : base(name, id)
        {
            this.marks = new int[marks.Length];
            for (int i = 0; i < marks.Length; i++)
            {
                this.marks[i] = marks[i];
            }
        }
        public override void Show()
        {
            base.Show();
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("{0,-10}", marks[i]);
            }
            Console.WriteLine();
        }
        public override bool IsProfi()
        {
            double result = ((double)marks.Sum()) / marks.Length;
            if (result > 4)
            {
                return true;
            }
            return !true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 5, 5, 5, 5 };
            Human[] humen = { new Student("Vasya", 100, mass), new Cleaner("1",30,102), new Teacher("history",31,999999)};
            foreach(var element in humen)
            {
                if (element.IsProfi())
                {
                    element.Show();
                }
            }
            Console.ReadLine();
        }
    }
}
