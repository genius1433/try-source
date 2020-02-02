using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Минимальное_произведение_олимпиадная
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int neg1 = int.MaxValue;
            int neg2 = int.MaxValue;
            int pos1 = int.MinValue;
            int pos2 = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp > pos1)
                {
                    pos2 = pos1;
                    pos1 = temp;
                    
                }
                else if (temp > pos2)
                {
                    pos2 = temp;
                }
                if (temp < neg1)
                {
                    neg2 = neg1;
                    neg1 = temp;
                }
                else if (temp < neg2)
                {
                    neg2 = temp;
                }
            }
            int result = Math.Min(Math.Min(neg2 * neg1, pos1 * pos2 ), pos1 * neg1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
