using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace олимпиадная_школньая_парад
{
    class Program
    {
        public static bool F(int m, int i)
        {
            bool f = false;
            if (m % i == 0)
            {
                for (int j = 1; j < m / i; j++)
                {
                    if (j * j == m / i)
                    {
                        f = true;
                    }
                }
            }
            return f;
        }
        static void Main(string[] args)
        {
            int m = 81;
            int result = 1;
            for (int i = 1; i <= m; i++)
            {
                if (F(m, i) == true && result  <  Math.Sqrt(m / i))
                {
                    result = m / i;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
