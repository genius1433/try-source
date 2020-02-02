using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трены_делегаты_и_события
{
    class Counter
    {
        public delegate void CounterDelegate();
        public event CounterDelegate OnCount;
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {                   
                    if (OnCount != null)
                    {
                        OnCount();
                    }
                }
            }
        }
    }
    class Listenner
    {
        public void Message()
        {
            Console.WriteLine("message");
        }
    }
    class Listenner2
    {
        public void Message()
        {
            Console.WriteLine("message 1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter obj1 = new Counter();
            Listenner listenner = new Listenner();
            Listenner2 listenner2 = new Listenner2();
            //obj1.OnCount += listenner.Message;
            //obj1.OnCount += listenner2.Message;
            obj1.Count();
            Console.ReadLine();
        }
    }
}
