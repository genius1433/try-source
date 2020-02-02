using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строчки___разминка
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string result = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (result.IndexOf(x[i]) == -1 && x[i] != ' ')
                {
                    result = result + x[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
