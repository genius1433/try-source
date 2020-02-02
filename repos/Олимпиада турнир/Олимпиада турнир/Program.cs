using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Олимпиада_турнир
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            List<int> list = new List<int>();
            List<int> deleter = new List<int>();
            int tur = 2;
            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }
            while (list.Count > 1)
            {

                for (int i = 0; i < list.Count ; i += 2)
                {
                    temp = int.Parse(Console.ReadLine());
                    if (temp == 1)
                    {
                        deleter.Add(list[i]);
                    }
                    else deleter.Add(list[i + 1]);
                }
                //tur *= 2;
                list.Clear();
                for (int i = 0; i < deleter.Count; i++)
                {
                    list.Add(deleter[i]);
                }
                deleter.Clear();
            }
            Console.WriteLine(list[0]);
            Console.ReadLine();
        }
    }
}
