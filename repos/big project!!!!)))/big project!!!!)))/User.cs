using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace big_project_______
{
    class User //Юзеры могут только искать, ничего изменят ьне могут, а также не могут смотреть историю чего-то?(
    {
        static private string ListToStr(List<Car> cars, string role)
        {
            string result = "";
            
            if (role == "User")
            {
                List<Car> tempCars = new List<Car>();
                for (int i = 0; i < cars.Count; i++)
                {
                    tempCars.Add(cars[i]);
                }
                for (int i = 0; i < tempCars.Count; i++)
                {
                    tempCars[i].AccidentHystory = "";
                }
                for (int i = 0; i < tempCars.Count; i++)
                {
                    result += tempCars[i].ToString() + "\n";
                }
            }
            else
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    result += cars[i].ToString() + "\n";
                }
            }
            return result;
        }
        static public string SearchColour(string colour, List<Car> cars, string role)
        {
            List<Car> tempCars = new List<Car>();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Colour == colour)
                {
                    tempCars.Add(cars[i]);
                }
            }
            return ListToStr(tempCars, role);
        }
        static public string SearchModelTRTP(string transmissionType, string model, List<Car> cars, string role)
        {
            List<Car> tempCars = new List<Car>();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == model && cars[i].TransmissionType1 == transmissionType)
                {
                    tempCars.Add(cars[i]);
                }
            }
            return ListToStr(tempCars, role);
        }
        static public string SearchSeats(string min, string max, List<Car> cars, string role)
        {
            List<Car> tempCars = new List<Car>();
            for (int i = 0; i < cars.Count; i++)
            {
                if (int.Parse(cars[i].NumSeats1) > int.Parse(min) && int.Parse(cars[i].NumSeats1) < int.Parse(max))
                {
                    tempCars.Add(cars[i]);
                }
            }
            return ListToStr(tempCars, role);
        }
        static public string SearchVanSize(string size, List<Car> cars, string role)
        {
            List<Car> tempCars = new List<Car>();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].BodyType1 == "van" && cars[i].Size1 == size)
                {
                    tempCars.Add(cars[i]);
                }
            }
            return ListToStr(tempCars, role);
        }
        static public bool LogIn(string login, string password, string role)
        {
            return BigDataBase.Login(login, password, role);
        }
    }
}
