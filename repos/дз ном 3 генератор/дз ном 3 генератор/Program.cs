using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_ном_3_генератор
{
    class Program
    {
        static void Print(int[] mass, int N, ref int number)
        {
            //Console.Write(number + ":");
            number++;
            for (int i = 0; i < N; i++)
            {
                Console.Write( mass[i] + " ");
            }
            Console.WriteLine();
        }
        static bool Z(int[] mass,int N, int K)
        {
            int j = N - 1;
            while (j >= 0 && mass[j] == K)
            {
                j--;
            }
            if (j < 0)
            {
                return false;
            }
            
            mass[j]++;
            for (int i = j + 1; i < N ; i++)
            {
                mass[i] = 1;
            }
            return true;
        }
        //static void Rec(int[] mass, int N, int K, ref int number)
        //{
            
        //    Print(mass, N, ref number);
        //    int j = N - 1;
        //    while (j >= 0 && mass[j] == K)
        //    {
        //        j--;
        //    }
        //    if (j >=0)
        //    {
        //        mass[j]++;
        //        for (int i = j + 1; i < N; i++)
        //        {
        //            mass[i] = 1;
        //        }
        //        Rec(mass, N, K, ref number);
        //    }
                
        //}
        static void Main(string[] args)
        {
            int x = 1;
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] mass = new int[N];
            for (int i = 0; i < N; i++)
            {
                mass[i] = 1;
            }
            Print(mass, N, ref x);
            //Rec(mass, N, K, ref x);
            while (Z(mass, N, K))
            {
                Print(mass, N, ref x);
            }
            Console.ReadLine();
        }
    }
}
