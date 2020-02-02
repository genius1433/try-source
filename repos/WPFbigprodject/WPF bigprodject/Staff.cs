using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPF_bigprodject
{
    class Staff : User //персонал может искать в каталоге,добавлять что-то в него, модифицировать - изменять.
    {
        static public int PrintCars(List<Car> cars)
        {
            cars.Sort(new DateComparer());
            string writePath = @"C:\Users\user\source\repos\WPFbigprodject\WPF bigprodject\cars_sorted.txt"; //@"C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\cars_sorted.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    sw.WriteLine(cars[i]);
                }
            }
            return 1;
        }
        static public int AddCar(string carInf, List<Car> cars)
        {
            int temp = 1;
            Car car = new Car();
            carInf = carInf.Replace(", ", ",");
            string[] carInformation = carInf.Split(',');
            car.NumberPlate = carInformation[0];
            car.Model = carInformation[1];
            car.BodyType1 = carInformation[2];
            if (carInformation[2] == "van")
            {
                temp--;
                car.Size1 = carInformation[3];
            }
            car.Colour = carInformation[4 - temp];
            car.Mileage = carInformation[5 - temp];
            car.AccidentHystory = carInformation[6 - temp];
            car.TransmissionType1 = carInformation[7 - temp];
            car.Price = carInformation[8 - temp];
            if (9 - temp < carInformation.Length)
            {
                car.DateArrival = carInformation[9 - temp];
            }
            if (10 - temp < carInformation.Length)
            {
                car.DateSell = carInformation[10 - temp];
            }
            cars.Add(car);
            return 1; //дописать что бы выводилось удалось добавление или нет машины
        }
        static public int AddCars(List<Car> cars)
        {
            string path = @"C:\Users\user\source\repos\WPFbigprodject\WPF bigprodject\cars_catalog.txt"; //@"C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\cars_catalog.txt";
            int result = 0;
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default)) //Обьяснения нужны
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        result = AddCar(line, cars); //если из эдкара вернулся ноль выкинуть исключение, сделать как нибудь
                    }
                }
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
            return 1;
        }
        static public int SellCar(String numberPlate, List<Car> cars)
        {
            string sellDate = DateTime.Today.ToString();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].NumberPlate == numberPlate && cars[i].DateSell != null)
                {
                    cars[i].DateSell = sellDate;
                }
            }
            return 1;
        }
        static public int CalculateRevenue(string sellingDate, List<Car> cars)
        {
            int sum = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].DateSell == sellingDate)
                {
                    sum += int.Parse(cars[i].Price);
                }
            }
            return sum;
        }
        //при преобразовании в дату я смогу юзануть .Month + .Year
        static public int CalculateRevenue1(string sellingDate, List<Car> cars) //добавил единичкку, но нужен перегруз
        {
            int sum = 0;
            DateTime tempDate = Convert.ToDateTime(sellingDate);
            string sellMonth = tempDate.Month.ToString();
            string sellYear = tempDate.Year.ToString();
            string tempSellMonth = "";
            string tempSellYear = "";
            for (int i = 0; i < cars.Count; i++)
            {
                tempSellMonth = Convert.ToDateTime(cars[i].DateSell).Month.ToString();
                tempSellYear = Convert.ToDateTime(cars[i].DateSell).Year.ToString();
                if (sellMonth == tempSellMonth && sellYear == tempSellYear)
                {
                    sum += int.Parse(cars[i].Price);
                }
            }
            return sum;
        }
    }
}
