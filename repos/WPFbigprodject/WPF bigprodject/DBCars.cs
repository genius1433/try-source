using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPF_bigprodject
{
    static class DBCars
    {
        //public Car(string numberPlate, string model, BodyTypes bodyType, Size size, string colour, string mileage,
                   //string accidentHistory, Transmissiontype transmissiontype, string price, string dateArrival,
                   //string dateSell) //дописать !!completed!!
        public static List<Car> ReadCatalog(string role)
        {
            string path = @"C:\Users\user\source\repos\WPFbigprodject\WPF bigprodject\cars_catalog.txt";
            List<Car> temp = new List<Car>();
            string[] tempstr = new string[] { ", " };
            using (StreamReader sw = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    //Saloon, Coupe, Hatchback, Van, SUV, MPV
                    //Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), (Size)Enum.Parse(typeof(Size), str[3]), str[4], str[5], str[6], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[7]), str[8], str[9], str[10]);
                    string[] str = line.Split(tempstr, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < str.Length; i++) //этот цикл добавлен в рамках трим мб
                    {
                        str[i].Trim();
                    }
                    if ((BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]) != BodyTypes.Van && str.Length == 9)
                    {
                        Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), str[3], str[4], str[5], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[6]), str[7], str[8]);
                        temp.Add(o);
                    }
                    else if ((BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]) != BodyTypes.Van && str.Length == 8)
                    {
                        Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), str[3], str[4], str[5], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[6]), str[7], DateTime.Today.ToString());
                        temp.Add(o);
                    }
                    else if ((BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]) != BodyTypes.Van)
                    {
                        Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), str[3], str[4], str[5], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[6]), str[7], str[8], str[9]);
                        temp.Add(o);
                    }
                    else if (str.Length == 10 )
                    {
                        //Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), (Size)Enum.Parse(typeof(Size), str[3]), str[4], str[5], str[6], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[7]), str[8], str[9]);
                        Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), (Size)Enum.Parse(typeof(Size), str[3]), str[4], str[5], str[6], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[7]), str[8], str[9]);

                        temp.Add(o);
                    }
                    else if (str.Length == 9)
                    {
                        Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), (Size)Enum.Parse(typeof(Size), str[3]), str[4], str[5], str[6], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[7]), str[8], DateTime.Today.ToString());
                        temp.Add(o);
                    }
                    else
                    { 
                        Car o = new Car(str[0], str[1], (BodyTypes)Enum.Parse(typeof(BodyTypes), str[2]), (Size)Enum.Parse(typeof(Size), str[3]), str[4], str[5], str[6], (Transmissiontype)Enum.Parse(typeof(Transmissiontype), str[7]), str[8], str[9], str[10]);
                        temp.Add(o);
                    }
                    
                }
            }
            return temp;
        }
        public static int WriteCatalog(List<Car> cars)
        {
            string writePath = @"C:\Users\user\source\repos\WPFbigprodject\WPF bigprodject\cars_catalog.txt"; //@"C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\cars_sorted.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    sw.WriteLine(cars[i]);
                }
            }
            return 1;
        }
    }
}
