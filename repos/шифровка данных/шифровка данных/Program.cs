using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шифровка_данных
{
    class Program
    {
        public static string Enigma(string x, int cdvig)
        {
            string al = "abcdefghijklmnopqrstuvwxyz0123456789!№;%:?*()-_=+@#$^&~`";
            string x1 = "";
            for (int i = 0; i < x.Length; i++) { x1 = x1 + al[(al.IndexOf(x[i]) + cdvig) % al.Length]; }                   
            return x1;
        }
        static void Main(string[] args)
        {
            string x = "abcd123";                 
            int cdvig = 1000000000;
            Console.WriteLine("Было:" + " " + x + " " + "Сдвиг:" + " " + cdvig + " ");
            Console.WriteLine("Стало:" + " " + Enigma(x,cdvig));
            Console.ReadLine();
        }
    }
}
