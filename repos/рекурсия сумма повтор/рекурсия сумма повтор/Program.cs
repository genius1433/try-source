using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсия_сумма_повтор
{
    class Program
    {
        //static int F(int i, int[] mass)
        //{
        //    if (i < mass.Length)
        //    {

        //        return mass[i] + F(i + 1, mass);
        //    }
        //    else return 0;
        //}
        static bool F(int i, string str)
        {
            if (str == "")
            {
                return false;
            }
            if (str.Length / 2 > i)
            {
                return F(i + 1, str);
            }
            else if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
            else return true;

        }
        static void Main(string[] args)
        {

            //int i = 0;
            //int[] mass = { 3, 4, 8, 1 };
            //Console.WriteLine(F(i, mass));
            string str = "";
            int i = 0;
            Console.WriteLine(F(i, str));
            Console.ReadLine();
        }
    }
}
