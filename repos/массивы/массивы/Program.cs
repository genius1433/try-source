using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[3];
            mas[0] = 3;
            mas[1] = 4;
            mas[2] = 5;
            int[] mas1 = new int[] { 4, 5, 2, 3 };
            int[] mas2 = { 4, 5, 5, 5, 5 };
            string[] mas3 = { "saasfsa", "gsdgds", "fdafs" };
            object[] mas4 = { 4, "52", 5.4 };
            var x = 3;
            int[,] mas5 =
            {
                {2,3,4},
                {5,6,0}
            };
            int[][] mas6= new int[3][];
            mas6[0] = new int [2]{1,2};

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            foreach(int item in mas)
            {
                Console.WriteLine(item);
            }
            foreach(object item in mas4)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
