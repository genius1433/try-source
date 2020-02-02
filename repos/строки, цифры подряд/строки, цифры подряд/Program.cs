using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки__цифры_подряд
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "76473123aasdas62 dw66 wfdw6652fy78yy899999";
            int max = 0;
            int tempmax = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= '0' && n[i] <= '9')
                {
                    tempmax++;
                    if (tempmax > max)
                    {
                        max = tempmax;
                    }
                }
                else
                {
                    tempmax = 0;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
