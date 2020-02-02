using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вывести_цифры_числа_3_в_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[500];
            int a = 2;
            int step = 5;
            int temp = 0;
            int index = mass.Length - 1;
            int counter = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = 1;
            //}
            for (int i = 0; i < step; i++)
            {
                for (int j = mass.Length - 1; j > 0; j--)
                {
                    
                    if (mass[j] == 0 && mass[j - 1] == 0 && mass[j - 1] >= 0)
                    {
                        temp = 1 * a;
                    }
                    else temp = mass[index] * a;
                    while (temp > 0)
                    {
                        mass[index] = temp % 10;
                        temp = temp / 10;                        
                        index--;
                    }
                    if (mass[index] == 0 && mass[index--] == 0 && mass[index - 2] == 0)
                    {
                        break;
                    }
                    counter++;
                    index = mass.Length - (mass.Length - j) - counter; 

                }
                counter = 0;
                index = mass.Length - 1;
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
            }
            
            Console.ReadLine();
        }
    }
}
// orgiginal bad
//int[] mass = new int[500];
//int a = 2;
//int step = 3;
//int temp = 0;
//int index = mass.Length - 1;
//            //for (int i = 0; i < mass.Length; i++)
//            //{
//            //    mass[i] = 1;
//            //}
//            for (int i = 0; i<step; i++)
//            {
//                for (int j = mass.Length - 1; j > 0; j--)
//                {
//                    temp = mass[j] * a;
                    
//                    while(temp > 0)
//                    {
//                        mass[index] = temp % 10;
//                        temp = temp / 10;
//                        index--;
//                    }
//                    index = mass.Length - (mass.Length - j); 

//                }
//                index = mass.Length - 1;
//            }
//            for (int i = 0; i<mass.Length; i++)
//            {
//                Console.Write(mass[i]);
//            }
            
//            Console.ReadLine();
//        }
