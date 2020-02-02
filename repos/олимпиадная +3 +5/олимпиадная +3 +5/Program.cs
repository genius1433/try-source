using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace олимпиадная__3__5
{
    class Program
    {
        static string result = "NO";
        static void F(int n)
        {
            if (n > 1 && result != "YES")
            {
                F(n - 3);
                F(n - 5);
            }
            else if (n == 1)
            {
                result = "YES";
            }
               
        }
        static void Main(string[] args)
        {
            int n = 100000;
            F(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
