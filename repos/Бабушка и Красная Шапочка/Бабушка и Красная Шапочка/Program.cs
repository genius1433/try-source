using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Бабушка_и_Красная_Шапочка
{
    [Serializable]
    public class Road
    {
        public string name;
        public int[] houses;
        public static int operator !(Road obj)
        {
            return obj.houses.Length;
        }
        public static bool operator +(Road obj)
        {
            int counter = 0;
            for (int i = 0; i < obj.houses.Length; i++)
            {
                for (int j = 0; j < obj.houses.Length; i++)
                {
                    if (obj.houses[i] == obj.houses[j] + 1 || obj.houses[i] == obj.houses[j] - 1)
                    {
                        counter = 1;
                    }
                }
            }
            if (counter == 1)
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            List<int> list1 = new List<int>();
            for (int i = 0; i < houses.Length; i++)
            {
                list1.Add(houses[i]);
            }
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] roadNames = new string[n];
            int[] roadsArray = new int[15];
            string path = @"C:\Users\User\source\repos\Бабушка и Красная Шапочка\Бабушка и Красная Шапочка\data.txt";
            string alp = "abcdefghijklmnopqrstuvwxyz";
            Random ran = new Random();
            Random letter = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < ran.Next(4,10); j++)
                {
                    if (j == 0){roadNames[i] = string.Concat(roadNames, alp[letter.Next(0, alp.Length)]).ToUpper();}
                    else roadNames[i] = string.Concat(roadNames, alp[letter.Next(0, alp.Length)]);
                }               
            }
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default)) //чет затупил как считать пару символов
            {
                try
                {
                    string line = sr.ReadToEnd();
                    int m = 0;
                    if (line == null)
                    {
                        throw new Exception("Файл пустой");
                    }
                    for (int i = 0; i < roadsArray.Length; i++)
                    {
                        roadsArray[i] = int.Parse(line.Substring(m, line.IndexOf(" ")));
                        m = m + roadsArray[i].ToString().Length;
                        if (roadsArray[i] > 100)
                        {
                            throw new Exception("Домов с номером больше 100 не должно быть");
                        }
                        if (roadsArray[i] < 0)
                        {
                            throw new Exception("Домов с отрицательным номером не должно быть");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            Road[] roadsArray2 = new Road[15];
            Random ra = new Random();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line = "";
                int b = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] numbers = line.Split(new char[] { ' ' });                    
                    int[] numberstemp = new int[numbers.Length];
                    for (int i = 0; i < numberstemp.Length; i++)
                    {
                        numberstemp[i] = int.Parse(numbers[i]);
                        
                    }
                    roadsArray2[b].name = roadNames[ra.Next(0, roadNames.Length + 1)];
                    roadsArray2[b].houses = numberstemp;
                    b++;
                }
            }
            for (int i = 0; i < roadsArray2.Length; i++)
            {
                Console.WriteLine("Дорога:" + roadsArray2[i].name);
                for (int j = 0; j < roadsArray2[i].houses.Length; j++)
                {
                    Console.Write(roadsArray2[i].houses[j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
