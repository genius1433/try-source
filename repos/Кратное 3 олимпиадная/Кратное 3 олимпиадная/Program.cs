using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кратное_3_олимпиадная
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string temp = n;
            int j = 0;
            int sumd = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sumd += n[i] - '0';
            }
            int ost = sumd % 3;
            //if (ost - 1 >= 0)
            //{
            //    ost--;
            //}
            for (int i = 0; i < n.Length; i++)
            {
                if ( n[i] - '0' + 9   < 10)
                {
                    n = n.Substring(0, i) + (9 - ost + (n[i] - '0')).ToString() + n.Substring(i + 1);
                    break;
                }
                else if (n[i] - '0' + 6 < 10)
                {
                    n = n.Substring(0, i) + (6 - ost + (n[i] - '0')).ToString() + n.Substring(i + 1);
                    break;
                }
                else if (n[i] - '0' + 3 < 10)
                {
                    n = n.Substring(0, i) + (3 - ost + (n[i] - '0')).ToString() + n.Substring(i + 1);
                    break;
                }
                else if (n[i] - '0' +  3 - ost < 10)
                {
                    n = n.Substring(0, i) + (3 - ost + (n[i] - '0')).ToString() + n.Substring(i + 1);
                    break;
                }
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
