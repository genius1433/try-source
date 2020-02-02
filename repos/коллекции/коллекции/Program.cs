using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace коллекции
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList  a = new ArrayList();
            a.Add(0);
            a.Add("aa");
            a.AddRange(new int[] { 0,1,2,3});
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            //a.Reverse()



            LinkedList<int> lt = new LinkedList<int>();
            lt.AddLast(0);
            var x = lt.AddFirst(1);
            lt.AddBefore(lt.Last, 10);
            lt.AddAfter(lt.First, 8);
            Console.WriteLine(x.Next.Value);



            Queue<int> qu = new Queue<int>();
            qu.Enqueue(10); // первым извлечен
            qu.Enqueue(11);
            qu.Enqueue(40);
            int z = qu.Dequeue();



            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(11); // первый достанется
            st.Pop();
            Console.WriteLine(z);




            Console.ReadLine();
        }
    }
}
