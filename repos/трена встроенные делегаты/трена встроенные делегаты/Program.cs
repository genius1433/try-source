using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krasavchik = System.Console;
using static System.Console;

namespace трена_встроенные_делегаты
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> action;
            action = (x, y) => Console.WriteLine(x + y);
            action(4, 5);
            Predicate<int> predicate;
            predicate = x => x > 0;
            WriteLine(predicate(-5));
            ReadLine();
        }
    }
}
