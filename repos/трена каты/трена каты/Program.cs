using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трена_каты
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 39;
            long result = n;
            long tempresult = 1;
            long tempn = n;
            int result1 = 0;
            while (result > 9)
            {
                while (tempn > 0)
                {
                    tempresult = tempresult * (tempn % 10);
                    tempn = tempn / 10;
                }
                result1++;
                result = tempresult;
                tempn = tempresult;
                tempresult = 1;
            }
            Console.WriteLine(result1);
            Console.ReadLine();
        }
    }
}
