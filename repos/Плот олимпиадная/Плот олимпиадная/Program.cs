using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Плот_олимпиадная
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string result = "";
            if (y > y2)
            {
                result += "N"; 
            }
            if (y < y1)
            {
                result += "S";
            }
            if (x < x1)
            {
                result += "W";
            }
            if (x > x2)
            {
                result += "E";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
