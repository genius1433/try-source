using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив_классов_сдвиг_влево
{
    class Bibika
    {
        public int v;
        public int m;
        public int a;
        public void Say()
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", v, m, a);
        }
        public Bibika(int v, int m, int a)
        {
            this.v = v;
            this.m = m;
            this.a = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bibika[] M = { new Bibika(10,1000,15), new Bibika(11, 1002, 178), new Bibika(111,99,4), new Bibika(99,24,10) };
            int s = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < M.Length - 1; j++)
                {
                    
                    Bibika Temp = M[j];
                    M[j] = M[j + 1];
                    M[j + 1] = Temp;
                }
            }
            for (int i = 0; i < M.Length; i++)
            {
                M[i].Say();
            }
            Console.ReadLine();
        }
    }
}
