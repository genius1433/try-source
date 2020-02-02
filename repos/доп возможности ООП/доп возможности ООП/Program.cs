    // статический импорт
//using static System.Console;
//using static System.Math;
//using static HelloApp.Geometry;
//namespace HelloApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double radius = 50;
//            double result = GetArea(radius); //Geometry.GetArea
//            WriteLine(result); //Console.WriteLine
//            Read(); // Console.Read
//        }
//    }

//    class Geometry
//    {
//        public static double GetArea(double radius)
//        {
//            return PI * radius * radius; // Math.PI
//        }
//    }
//}

    // методы расширения
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s = "Привет мир";
//        char c = 'и';
//        int i = s.WordCount(c);
//        Console.WriteLine(i);

//        Console.ReadLine();
//    }
//}

//public static class StringExtension
//{
//    public static int WordCount(this string str, char c)
//    {
//        int counter = 0;
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (str[i] == c)
//                counter++;
//        }
//        return counter;
//    }
//}



