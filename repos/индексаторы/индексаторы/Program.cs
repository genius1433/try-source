using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace индексаторы
{
    class MyArray
    {
        private int[] arr;
        private double[] arr2;
        public int length;
        public MyArray(int size)
        {
            arr2 = new double[size];
            arr = new int[size];
            length = size;
        }
        public int this[int index]
        {
            set
            {
                if (index < length && index >= 0)
                {
                    arr[index] = value;
                }
            }
            get
            {
                return arr[index];
            }
        }
        //public double this[double index]
        //{
        //    set
        //    {
        //        arr2[(int)(index)] = value;
        //    }
        //    get
        //    {
        //        return arr2[(int)(index)];
        //    }
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray object1 = new MyArray(7);
            Random random = new Random();
            object1[5] = 6;
            //object1[5.6] = 6.7;
            Console.WriteLine(object1[5]);
            Console.ReadLine();
        }
    }
}
