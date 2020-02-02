using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_subbarray_sum_codewars
{
    class Program
    {
        static int Func(int[] arr, int left, int right)
        {
            if (left == right)
            {
                return arr[left];
            }
            int middle = (left + right) / 2;
            return Math.Max(Math.Max(Func(arr,left,middle), Func(arr,middle + 1, right)), Func2(arr,left,middle,right));
        }
        static int Func2(int[] arr, int left, int middle, int right)
        {
            int sum = 0;
            int leftsum = int.MinValue;
            for (int i = middle; i >= left; i--)
            {
                sum = sum + arr[i];
                if (sum > leftsum)
                {
                    leftsum = sum;
                }
            }
            int rightsum = int.MinValue;
            sum = 0;
            for (int i = middle + 1; i <= right; i++)
            {
                sum = sum + arr[i];
                if (sum > rightsum)
                {
                   rightsum = sum;
                }
            }
            return rightsum + leftsum;
        }
        static void Main(string[] args)
        {
            int notplural = 0;
            int result = 0;
            int[] arr = {-2, 1, -3, 4};
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    notplural++;
                }
            }
            result = Func(arr, 0, arr.Length - 1);
            if (notplural == arr.Length)
            {
                Console.WriteLine(0);
            }
            else Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
