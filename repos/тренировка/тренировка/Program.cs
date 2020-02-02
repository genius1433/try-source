using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тренировка
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "appple, tree, pencil";
            var result = x.Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
