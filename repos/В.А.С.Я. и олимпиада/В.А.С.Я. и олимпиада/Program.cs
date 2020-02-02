using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace В.А.С.Я.и_олимпиада
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());
            int F = int.Parse(Console.ReadLine());
            int G = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < G; i++)
            {
                if (G != A && G != B && G != C)
                {
                    A++;
                    B++;
                    C++;
                }
            }
            for (int i = 0; i < D; i++)
            {
                if (D != G)
                {
                    A++;
                    B++;
                }
                
            }
            for (int i = 0; i < E; i++)
            {
                if (E != G)
                {
                    A++;
                    C++;
                }
            }
            for (int i = 0; i < F; i++)
            {
                if (F != G)
                {
                    B++;
                    C++;
                }
            }
            sum = A + B + C;
            Console.Write(sum);
            Console.ReadLine();
        }
    }
}
