using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace второе_непонятное_дз_с_выводом_в_стрчоке
{
    class Program
    {
        static string Razlozenie(int f)
        {
            int m = 2;
            string str = "";
            while (f > 1)
            {
                while (f % m == 0)
                {
                    //Console.Write("*" + m);
                    f = f / m;
                    str = str + "*" + m;
                }
                m++;
            }
            return (str);
        }
        static void Main(string[] args)
        {            
            int f = int.Parse(Console.ReadLine());
            Console.Write(f + "=" + 1);
            Console.WriteLine(Razlozenie(f));
            Console.ReadLine();
        }
    }
}
