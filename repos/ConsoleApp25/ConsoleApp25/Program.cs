using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int minV = int.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());
            int minresult = 100000;
            int tempresult = 100000000''
            int[] mass = new int[amount];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = amount;
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {

                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
//static bool F(int digit)
//{
//    bool result = true;
//    for (int i = 2; i < digit; i++)
//    {
//        if (i != digit && digit % i == 0)
//        {
//            result = false;
//            break;
//        }
//    }
//    return result;
//}
//static void Main(string[] args)
//{
//    int n = int.Parse(Console.ReadLine());
//    int tempn = n;
//    int result = 0;
//    int maxzero = 0;
//    int tempzero = 0;
//    int osn = 0;
//    int digit = 2;
//    while (digit < n)
//    {
//        if (tempn % digit == 0)
//        {
//            tempzero += 1;
//        }
//        tempn /= digit;
//        if (tempzero > maxzero)
//        {
//            maxzero = tempzero;
//            osn = digit;
//        }
//        if (tempn == 0)
//        {
//            tempn = n;
//            while (true)
//            {
//                digit++;
//                if (F(digit) == true)
//                {
//                    break;
//                }
//            }
//            tempzero = 0;
//        }
//    }
//    Console.WriteLine(osn);
//    Console.ReadLine();
