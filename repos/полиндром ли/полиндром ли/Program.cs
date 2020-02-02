using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace полиндром_ли
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string M = "topot";
            for (int i = 0; i < M.Length/2; i++)
            {
                if (M[i] != M[M.Length - i - 1])
                {
                    x = 1;
                    break;
                }
            }
            if (x == 1)
            {
                Console.WriteLine("НЕ полиндром");
            }
            else Console.WriteLine("полиндром");
            Console.ReadLine();
        }
    }
}
