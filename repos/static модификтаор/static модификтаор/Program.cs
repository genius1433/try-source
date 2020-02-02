using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_модификтаор
{
    class Account
    {
        public int Id;
        public int currentSum;
        public static int bonus;
        public void Change()
        {
            currentSum += bonus;
            Console.WriteLine(currentSum);
        }
        
    }
    class MyMath
    {
        public static int Module(int number)
        {
            if (number < 0)
            {
                return number * -1;
            }
            else return number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account() {Id = 100, currentSum = 0 };
            Account obj1 = new Account() { Id = 2, currentSum = 20 };
            Account.bonus = 1000;
            obj.Change();
            Console.WriteLine(MyMath.Module(-2));
            Console.ReadLine();
        }
    }
}
