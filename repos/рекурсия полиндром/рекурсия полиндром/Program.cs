using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсия_полиндром
{
    class Program
    {
        static void N(int x, string m, int i, ref bool count)
        {
              if (m[x] != m[i])
              {
                  count = false;                   
              }
              if (x < m.Length / 2 && count != false)
              {
                  N(x + 1, m, i - 1, ref count);
              }
        }
        static void Main(string[] args)
        {
            string m = "toppot";
            int i = m.Length - 1;
            int x = 0;
            bool count = true;
            N(x, m, i, ref count);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
