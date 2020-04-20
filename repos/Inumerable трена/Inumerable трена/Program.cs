using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloApp
{
    class MyIEnumerator : IEnumerator
    {
        List<string> listik;
        int position = -1;
        public MyIEnumerator(List<string> listik)
        {
            this.listik = listik;
        }
        public object Current
        {
            get 
            {
                if (position == -1 || position >= listik.Count)
                {
                    throw new InvalidOperationException();
                }
                return listik[position];
            }

        }
        public bool MoveNext()
        {
            if (position < listik.Count - 1)
            {
                position++;
                return true;
            }
            else return false;
        }
        public void Reset()
        {
            position = -1;
        }

    }
    class Week : IEnumerable
    {
        
        List<string> listik = new List<string>() {"Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday" };
        //public IEnumerator GetEnumerator()
        //{
        //    return listik.GetEnumerator();
        //}
        public IEnumerator GetEnumerator()
        {
            return new MyIEnumerator(listik);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var item in week)
            {
                Console.WriteLine(item);
            }
            
            //int[] numbers = { 0, 2, 4, 6, 8, 10 };
            //IEnumerator ie = numbers.GetEnumerator(); // получаем IEnumerator
            //while (ie.MoveNext())   // пока не будет возвращено false
            //{
            //    int item = (int)ie.Current;     // берем элемент на текущей позиции
            //    Console.WriteLine(item);
            //}
            //ie.Reset(); // сбрасываем указатель в начало массива
            Console.Read();
        }
    }
}
