using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace king_of_delegates
{
    class Program
    {
        delegate int Operation(int x, int y);
        public static int Add(int x, int y) { return x + y; }
        static void Main(string[] args)
        {
            Operation operation = Add;
            operation -= Add;
            
            Console.WriteLine(operation?.Invoke(3,2));
            Console.ReadLine();
        }
    }
}
