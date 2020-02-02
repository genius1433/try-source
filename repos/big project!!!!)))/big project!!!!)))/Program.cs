using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_project_______
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Если присваиваю значение то сеттер иначе геттер
            Car car = new Car();
            car.NumberPlate = "1";
            Console.WriteLine(car.NumberPlate);
            Console.ReadLine();
        }
    }
}
