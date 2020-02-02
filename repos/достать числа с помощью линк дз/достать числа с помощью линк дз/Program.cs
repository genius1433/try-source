using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace достать_числа_с_помощью_линк_дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 2, 11, 70, 40, 200, 99 };
            var result = from item in mass
                         where item > 10 && item < 100
                         orderby item
                         select item;
            var result1 = mass.Where(item => item > 10 && item < 100).OrderBy(item => item);
            //var result = mass.Where(item => item.ToUpper().StartsWith("P")).OrderBy(item => item);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
