﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_номер_4_по_масивам
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] A = new int[n, n];
            int i = 1, j, k, p = n / 2;
            for (k = 1; k <= p; k++)/*Цикл по номеру витка*/
            {
                for (j = k - 1; j < n - k + 1; j++) A[k - 1, j] = i++;/*Определение значений верхнего гор столбца*/
                for (j = k; j < n - k + 1; j++) A[j, n - k] = i++;/* --//-- По правому вертикальному столбцу*/
                for (j = n - k - 1; j >= k - 1; --j) A[n - k, j] = i++;/* --//-- по нижнему горизонтальному столбцу*/
                for (j = n - k - 1; j >= k; j--) A[j, k - 1] = i++;/* --//-- по левому вертикальному столбцу*/
            }
            if (n % 2 == 1) A[p, p] = n * n;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0,-10}", A[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
