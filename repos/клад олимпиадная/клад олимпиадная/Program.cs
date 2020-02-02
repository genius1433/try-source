using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace клад_олимпиадная
{
    class Program
    {
        public static int F(int i, string str)
        {
            int result = 0;
            int digitn = 1;
            while (str[i] != 'N' && str[i] != 'S' && str[i] != 'W' && str[i] != 'E')
            {
                result += (str[i] - '0') * digitn;
                digitn *= 10;
                if (i - 1 < 0)
                {
                    break;
                }
                else i--;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string str = "10N30W20N";
            int S = 0;
            int N = 0;
            int E = 0;
            int W = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'N')
                {
                    N += F(i - 1, str);
                }
                if (str[i] == 'S')
                {
                    S += F(i - 1, str);
                }
                if (str[i] == 'W')
                {
                    W += F(i - 1, str);
                }
                if (str[i] == 'E')
                {
                    E += F(i - 1, str);
                }
            }
            if (S > N)
            {
                Console.Write((S - N) + "S");
            }
            else if (S == N) { }
            else Console.Write((N - S) + "N");
            if (W > E)
            {
                Console.Write((W - E) + "W");
            }
            else if (W == E) { }
            else Console.Write((E - W) + "E");
            Console.ReadLine();
        }
    }
}
