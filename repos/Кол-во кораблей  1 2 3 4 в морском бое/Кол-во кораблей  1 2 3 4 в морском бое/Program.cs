using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кол_во_кораблей__1_2_3_4_в_морском_бое
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> k = new List<int[]>();
            int[,] mass = new int[10, 10] { {0,0,0,0,0,0,0,0,0,1 },
                                            {0,0,0,0,0,0,0,0,0,1 },
                                            {1,1,1,1,0,0,0,1,0,0 },
                                            {0,0,0,0,0,1,0,0,0,0 },
                                            {1,0,0,0,0,1,0,0,1,0 },
                                            {1,0,0,0,0,0,0,0,0,0 },
                                            {0,0,0,0,0,0,0,0,0,0 },
                                            {1,1,1,1,0,0,0,0,0,0 },
                                            {0,0,0,0,0,0,0,0,0,0 },
                                            {0,0,0,0,0,0,0,0,0,0 }
                                          };
            int one = 0;
            int two = 0;
            int three = 0;
            int fourth = 0;
            int tempcounter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (mass[i,j] == 1)
                    {
                        tempcounter++;
                        mass[i, j] = 2;
                        if (i - 1 >= 0 && mass[i - 1, j] == 1)
                        {
                            tempcounter++;
                            mass[i - 1, j] = 2;
                            if (i - 2 >= 0 && mass[i - 2, j] == 1 )
                            {
                                tempcounter++;
                                mass[i - 2, j] = 2; 
                                if (i - 3 >= 0 && mass[i - 3, j] == 1)
                                {
                                    mass[i - 3, j] = 2;
                                    tempcounter++;
                                }
                            }
                        }
                        if (i + 1 <= 9 && mass[i + 1, j] == 1 )
                        {
                            tempcounter++;
                            mass[i + 1, j] = 2;
                            if (i + 2 <= 9 && mass[i + 2, j] == 1)
                            {
                                tempcounter++;
                                mass[i + 2, j] = 2;
                                if (i + 3 <= 9 && mass[i + 3, j] == 1)
                                {
                                    mass[i + 3, j] = 2;
                                    tempcounter++;
                                }
                            }
                        }
                        if (j - 1 >= 0 && mass[i, j - 1] == 1)
                        {
                            tempcounter++;
                            mass[i , j - 1] = 2;
                            if (j - 2 >= 0 && mass[i, j - 2] == 1)
                            {
                                tempcounter++;
                                mass[i, j - 2] = 2;
                                if (j - 3 >= 0 && mass[i, j - 3] == 1)
                                {
                                    mass[i, j - 3] = 2;
                                    tempcounter++;
                                }
                            }
                        }
                        if (j + 1 <= 9 && mass[i, j + 1] == 1)
                        {
                            tempcounter++;
                            mass[i, j +  1] = 2;
                            if (j + 2 <= 9 && mass[i, j + 2] == 1)
                            {
                                tempcounter++;
                                mass[i, j + 2] = 2;
                                if (j + 3 <= 9 && mass[i, j + 3] == 1)
                                {
                                    mass[i, j + 3] = 2;
                                    tempcounter++;
                                }
                            }
                        }
                        if (tempcounter == 1)
                        {
                            one++;
                        }
                        if (tempcounter == 2)
                        {
                            two++;
                        }
                        if (tempcounter == 3)
                        {
                            three++;
                        }
                        if (tempcounter == 4)
                        {
                            fourth++;
                        }
                    }
                    tempcounter = 0;
                }
            }
            Console.WriteLine("1: " + one);
            Console.WriteLine("2: " + two);
            Console.WriteLine("3: " + three);
            Console.WriteLine("4: " + fourth);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(mass[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
