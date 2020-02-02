using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace свойства
{
    class UserInfo
    {
        private int a;
        string s = "Alex";

        // Создадим свойство, управляющее
        // доступом к переменной a
        public void seta(int a)
        {
            if (a >= 0)
            {
                this.a = a;
            }
            else Console.WriteLine("Дебил");
        }
        public int Age
        {
            get
            {
                if (a <= 0)
                    return 1;
                return a;
            }

            set
            {
                if (value >= 0)
                {
                    this.a = value;
                }
                else Console.WriteLine("Дибил");
            }
        }

        // Свойство только для чтения
        // переменной s
        // аксессор set отсутствует
        public string Name
        {
            get
            {
                return s;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInfo object1 = new UserInfo();
            object1.Age = -10;
            Console.ReadLine();
        }
    }
}
