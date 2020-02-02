using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_my_friend_cheating
{
    class Program
    {
        public static List<long[]> removNb(long n)
        {
            List<long[]> list = new List<long[]>();
            long sum = (1 + n) * n / 2;
            for (int i = 1; i < n + 1; i++)
            {
                double doublee = (sum - i) / (i + 1);
                if (doublee <= n && (sum - i) % (i + 1) == 0)
                {
                    list.Add(new long[2] {i, (long)(doublee) });
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            long n = 26;
            var result = removNb(n);
            foreach (var item in result)
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
            
            Console.ReadLine();
        }
    }
}
