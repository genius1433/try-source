using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace егэ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxx = 0;
            int maxy = 0;
            double result = 0;
            string reader = "";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                reader = Console.ReadLine();
                int tempx = Math.Abs(int.Parse(reader.Substring(0, reader.IndexOf(" "))));
                int tempy = Math.Abs(int.Parse(reader.Substring(reader.IndexOf(" "))));
                if (tempx + tempy > maxx + maxy && tempx != 0 && tempy != 0)
                {
                }
                else if (tempx > maxx) { maxx = tempx; }
                else if(tempy > maxy)  { maxy = tempy; }
            }
            result = maxx * maxy / 2;            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
