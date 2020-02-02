using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_3_матрица_в_функции
{
    class Program
    {
        static void MATRICHA(int n, int[,] A)
        {
            
            int i = 1, j, k, p = n / 2;
            for (k = 1; k <= p; k++)/*Цикл по номеру витка*/
            {
                for (j = k - 1; j < n - k + 1; j++) A[k - 1, j] = i++;/*Определение значений верхнего гор столбца*/
                for (j = k; j < n - k + 1; j++) A[j, n - k] = i++;/* --//-- По правому вертикальному столбцу*/
                for (j = n - k - 1; j >= k - 1; --j) A[n - k, j] = i++;/* --//-- по нижнему горизонтальному столбцу*/
                for (j = n - k - 1; j >= k; j--) A[j, k - 1] = i++;/* --//-- по левому вертикальному столбцу*/
            }
            if (n % 2 == 1) A[p, p] = n * n;
        }
        static void MATRICHA2(int n, int[,] A)
        {
            
            int i = 1, j, k, p = n / 2;
            for (k = 1; k <= p; k++)/*Цикл по номеру витка*/
            {
                for (j = n - k; j >= k; --j) A[n - k, j] = i++;/* --//-- по нижнему горизонтальному столбцу*/
                for (j = n - k; j >= k; j--) A[j, k - 1] = i++;/* --//-- по левому вертикальному столбцу*/
                for (j = k - 1; j < n - k + 1; j++) A[k - 1, j] = i++;/*Определение значений верхнего гор столбца*/
                for (j = k; j < n - k; j++) A[j, n - k] = i++;/* --//-- По правому вертикальному столбцу*/
            }
            if (n % 2 == 1) A[p, p] = n * n;
        }
        static void MATRICHA3(int n, int[,] A)
        {
            
            int i = 1, j, k, p = n / 2;
            for (k = 1; k <= p; k++)/*Цикл по номеру витка*/
            {
                for (j = n - k; j >= k; --j) A[j, k - 1] = i++;/* --//-- по левому вертикальному столбцу*/
                for (j = k - 1; j < n - k + 1; j++) A[k - 1, j] = i++;/*Определение значений верхнего гор столбца*/
                for (j = k; j < n - k; j++) A[j, n - k] = i++;/* --//-- По правому вертикальному столбцу*/
                for (j = n - k; j >= k; --j) A[n - k, j] = i++;/* --//-- по нижнему горизонтальному столбцу*/

            }
            if (n % 2 == 1) A[p, p] = n * n;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];
            Console.WriteLine("Введите номер матрицы 1 2 или 3");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
               MATRICHA(n,A);
            }
            else if (x == 2)
            {
                MATRICHA2(n,A);
            }
            else if (x == 3)
            {
                MATRICHA3(n,A);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-10}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
