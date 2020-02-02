using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_стринг
{
    class Dop
    {
        public string a;
        public char b;
        public Dop(string a,char b)
        {
            int indexOfChar = a.IndexOf(b);
            string[] words = a.Split(new char[] { ' ' });
            for (int i = 0; i < words.length; i++)
            {

            }
            Console.WriteLine(a.IndexOf(b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dop a = new Dop("x/y",'/');            
            Console.ReadLine();
        }
    }
}
