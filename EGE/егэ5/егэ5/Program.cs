using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxsev = 1;
            int maxnsev = 1;
            int writer = 0;
            int counter = 0;
            //while (true)
            //{
            //    writer = int.Parse(Console.ReadLine());
            //    if (writer != 0)
            //    {
            //        list.Add(writer);
            //    }
            //    else break;
            //}
            //int control = int.Parse(Console.ReadLine());
            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = 0; j < list.Count; j++)
            //    {
            //        if (i != j && list[i] * list[j] > max && list[i] * list[j] % 7 == 0 && list[i] * list[j] % 49 != 0)
            //        {
            //            max = list[i] * list[j];
            //        }
            //    }
            //}
            while (true)
            {
                writer = int.Parse(Console.ReadLine());
                if (writer != 0)
                {
                    counter++;
                    if (writer % 7 == 0 && writer % 49 != 0 && writer > maxsev)
                    {
                        maxsev = writer;
                    }
                    else if (writer % 7 != 0 && writer > maxnsev)
                    {
                        maxnsev = writer;
                    }
                }
                else break;
            }
            int control = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во принятых чисел:" + counter);
            Console.WriteLine("Принятое контрольное значение:" + control);
            Console.WriteLine("Вычисленное контрольное значение" + maxsev * maxnsev);
            if (control == maxnsev * maxsev)
            {
                Console.WriteLine("Значения совпали");
            }
            else Console.WriteLine("Значения не совпали");
            Console.ReadLine();
        }
    }
}
