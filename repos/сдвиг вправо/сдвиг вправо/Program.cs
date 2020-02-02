using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сдвиг_вправо
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[] { 1, 2, 3, 4 };
            int s = int.Parse(Console.ReadLine());
            int temp = 0;
            for (int j = 0; j < s; j++)
            {
                for (int i = M.Length-1; i > 0; i--)
                {
                    temp = M[i];
                    M[i] = M[i - 1];
                    M[i - 1] = temp;
                }
            }
            for (int i = 0; i < M.Length; i++)
            {
                Console.WriteLine(M[i]);
            }
            Console.ReadLine();
        }
    }
}
