using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool q = true;
            int x = 5*3*6;
            Console.WriteLine("Введите значение выражения:" ,x);
            while(true)
            {
                int c = int.Parse(Console.ReadLine());                
                
                if  (c == 90 )
                {                  
                    Console.WriteLine("Ответ верный, красава");
                    break;
                }
                else
                    Console.WriteLine("Ответ неверный, возможно угадаешь в следующий раз");
            }
            Console.ReadLine();
        }
    }
}
