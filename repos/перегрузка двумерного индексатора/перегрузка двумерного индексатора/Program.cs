using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка_двумерного_индексатора
{
    class MyArr
    {
        int[,] arr = new int[3,3];
        public int this[int i, int j]
        {
            get
            {
                return arr[i,j];
            }
            set
            {
                arr[i,j] = value;
            }
        }
        public int this[double i, double j]
        {
            get
            {
                return arr[(int)Math.Round(i), (int)Math.Round(j)];
            }
            set
            {
                arr[(int)Math.Round(i),(int)Math.Round(j)] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArr arr = new MyArr();
            arr[0,0] = 1;
            arr[0.2,2] = 6;
            arr[1.3,0.9] = 10;
            arr[2,2] = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write( "{0,-10}", arr[i,j]);
                }
                Console.WriteLine();
            }               
            Console.ReadLine();
        }
    }
}
