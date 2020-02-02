using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_1_по_массивам_с_исп.ступенчатого
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во чисел для диапазона");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько чисел в рандомном массиве?");
            int m = int.Parse(Console.ReadLine());
            Random k = new Random();
            int u = 0;
            int[][] myArr = new int[2][];
            myArr[0] = new int[n];
            myArr[1] = new int[m];
            for (int i = 0; i < m; i++)
            {
                myArr[0][i] = k.Next(100);
                for (int j = 0; j < n; i++)
                {
                    Console.WriteLine("Введите число диапазона");
                    int b = int.Parse(Console.ReadLine());
                    myArr[1][j] = b;
                    if (myArr[0][j] == myArr[1][i])
                    {
                        u = u + 1;
                    }
                }
            }
            Console.WriteLine( "Кол-во чисел входящих из диапазона в массив:" + u);
            Console.ReadLine();
            
        }
    }
}
