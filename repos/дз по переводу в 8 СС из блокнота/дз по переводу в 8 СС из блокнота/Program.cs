using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace дз_по_переводу_в_8_СС_из_блокнота
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static int FromTen(string number)
        {
            string tempresult1 = "";
            int tempnumber = int.Parse(number);
            for (int i = 0; i < number.Length + 1; i++)
            {
                tempresult1 = tempresult1 + (tempnumber % 8).ToString();
                tempnumber = tempnumber / 8;
            }
            tempresult1 = ReverseString(tempresult1);
            return int.Parse(tempresult1);
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\source\repos\дз по переводу в 8 СС из блокнота\дз по переводу в 8 СС из блокнота\числа.txt";
            int[] mass = new int[50];

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default)) //Обьяснения нужны
            {
                string line;
                for (int i = 0; i < mass.Length; i++)
                {
                    if ((line = sr.ReadLine()) != null)
                    {
                        mass[i] = int.Parse(line);
                    }
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = FromTen(mass[i].ToString());
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.ReadLine();
        }
    }
}
