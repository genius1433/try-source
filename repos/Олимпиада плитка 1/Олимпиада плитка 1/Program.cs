using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Олимпиада_плитка_1
{
    class Program
    {
        public void F(int x)
        {
            List<int> l = new List<int>();
        }
        static void Main(string[] args)
        {
            //int m = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int w = int.Parse(Console.ReadLine());
            //int h = int.Parse(Console.ReadLine());
            //int result = 0;
            //int left = x / m;
            //int right = (x + w - 1) / m;
            //int buttom = y / m;
            //int top = (y + h - 1) / m;
            //result = (right - left + 1) * (top - buttom + 1);
            //Console.WriteLine(result);
            List<int> l = new List<int>();
            string str = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i + 1 < str.Length && str[i] == 'I' && str[i + 1] == 'X')
                {
                    if (i + 3 < str.Length && str[i + 2] == 'C' && str[i + 3] == 'D')
                    {
                        result += 409;
                        i += 3;
                    }
                    else if (i + 3 < str.Length && str[i + 2] == 'C' && str[i + 3] == 'M')
                    {
                        result += 909;
                        i += 3;
                    }
                    else if (i + 2 < str.Length && str[i + 2] == 'L')
                    {
                        result += 41;
                        i += 2;
                    }
                    else if (i + 2 < str.Length && str[i + 2] == 'C')
                    {
                        result += 91;
                        i += 2;
                    }
                    else { result += 9; i += 1; }
                }
                else if (i + 2 < str.Length && str[i] == 'X' && str[i + 1] == 'C' && str[i + 2] == 'D')
                {
                    result += 410;
                    i += 2;
                }
                else if (i + 2 < str.Length && str[i] == 'X' && str[i + 1] == 'C' && str[i + 2] == 'M')
                {
                    result += 910;
                    i += 2;
                }
                else if (str[i] == 'I')
                {
                    if (i + 1 < str.Length && str[i + 1] == 'V')
                    {
                        result += 4;
                        i += 1;
                    }
                    else result += 1;
                }
                else if (str[i] == 'X')
                {
                    if (i + 1 < str.Length && str[i + 1] == 'L')
                    {
                        result += 40;
                        i += 1;
                    }
                    else if (i + 1 < str.Length && str[i + 1] == 'C')
                    {
                        result += 90;
                        i += 1;
                    }
                    else result += 10;
                }
                else if (str[i] == 'C')
                {
                    if (i + 1 < str.Length && str[i + 1] == 'D')
                    {
                        result += 400;
                        i += 1;
                    }
                    else if (i + 1 < str.Length && str[i + 1] == 'M')
                    {
                        result += 900;
                        i += 1;
                    }
                    else result += 100;
                }
                else if(str[i] == 'V')
                {
                    result += 5;
                }
                else if (str[i] == 'D')
                {
                    result += 500;
                }
                else if (str[i] == 'M')
                {
                    result += 1000;
                }
                else if (str[i] == 'L')
                {
                    result += 50;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
