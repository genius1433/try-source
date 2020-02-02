using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace паттерны_трена
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new WoodDuck();
            
            duck.Fly();
            duck.Vzlom();
            duck.SetFlyBehaviour(new CanFly());
            duck.Fly();
            Console.ReadLine();
        }
    }
}
