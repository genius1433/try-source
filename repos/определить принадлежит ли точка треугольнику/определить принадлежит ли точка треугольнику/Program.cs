using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace определить_принадлежит_ли_точка_треугольнику
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mass = { { 3, 8 }, { 3, 2 }, { 10, 2 } };
            double[] mas2 = new double[3];
            double x = 7;
            double y = 3;
            double Sor = Math.Abs((mass[1,0] - mass[0,0]) * (mass[2,1] - mass[0,1]) - (mass[2,0] - mass[0,0]) * (mass[1,1] - mass[0,1])) / 2;
            mas2[0] = Math.Abs((mass[1, 0] - x) * (mass[2, 1] - y) - (mass[2, 0] - x) * (mass[1, 1] - y)) / 2;
            mas2[1] = Math.Abs((x - mass[0, 0]) * (mass[2, 1] - mass[0, 1]) - (mass[2, 0] - mass[0, 0]) * (y - mass[0, 1])) / 2;
            mas2[2] = Math.Abs((mass[1, 0] - mass[0, 0]) * (y - mass[0, 1]) - (x - mass[0, 0]) * (mass[1, 1] - mass[0, 1])) / 2;
            Console.WriteLine(mas2.Sum() + " " + Sor);
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.WriteLine(mas2[i]);
            }
            if (mas2.Sum() == Sor)
            {
                Console.WriteLine("+");
                
            }
            else Console.WriteLine("-");
            Console.ReadLine();
        }
    }
}
