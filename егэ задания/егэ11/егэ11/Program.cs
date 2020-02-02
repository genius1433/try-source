using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[30];
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    result += n[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
