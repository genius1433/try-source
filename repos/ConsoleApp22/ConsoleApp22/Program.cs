using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace страшная_еркурсия
{
    class Program
    {
        static bool S(int n)
        {
            if (n < 0) return false;
            else if (n == 1) return true;
            else
            {
                return (S(n - 3)) || (S(n - 5));
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            S(n);
            if (S(n) == true)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}

