using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_по_ромбу
{
    class Program
    {       
        static int l = 4;
        static int stroka = 5;
        static int stolbik = 4;
        static void F(string[] str, int counter, string central)
        {
            
            for (int i = 0; i < counter; i++)
            {
                
                for (int j = 0; j < stroka; j++)
                {
                    Console.Write(" " + str[i] + str[i].Substring(0, str[i].IndexOf('*')));
                }
                Console.WriteLine();
            }            
            for (int j = 0; j < stroka; j++)
            {
                if (j + 1 != stroka)
                {
                    Console.Write(" " + central);
                }
                else Console.Write(" " + central);
            }
            Console.WriteLine();
            for (int i = counter - 1; i >= 0; i--)
            {
                for (int j = 0; j < stroka; j++)
                {
                    Console.Write(" " + str[i] + str[i].Substring(0, str[i].IndexOf('*')));
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            string[] str = new string[(l + 1 / 2) - 1];
            string central = "";
            int counter = 0;
            Console.WriteLine();
            for (int i = 0; i < l + l - 1; i++)
            {
                central += "*";
            }
            for (int i = 0; i < l; i++)
            {
                for (int d = 0; d <= l / 2 - i; d++)
                {
                    if (i + 1 != l)
                    {
                        str[counter] += " ";
                    }
                }
                for (int j = l / 2 - 1 - i; j < l / 2 + i; j++)
                {
                    if (i + 1 != l)
                    {
                        str[counter] += "*";
                    }
                }
                if (i + 1 != l)
                {
                    counter++;
                }
            }
            for (int i = 0; i < stolbik; i++)
            {
                F(str, counter, central);
                //Console.WriteLine();
            }                    
            Console.ReadLine();
        }
    }
}
