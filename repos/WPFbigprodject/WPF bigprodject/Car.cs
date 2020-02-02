using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPF_bigprodject
{
    enum Transmissiontype { manual, automatic }; //manual - ручная коробка передач   
    enum Accessability { available, sold };
    enum BodyTypes { Saloon, Coupe, Hatchback, Van, SUV, MPV };
    enum NumSeats { two, three, four, fifth, seven };
    enum NumDoors { two, fifth };
    enum Size { small, large };
    class Car //just car, nothing interesting
    {
        private string numberPlate;
        private string colour;
        private string mileage;
        private string accidentHistory;
        private string price;
        private DateTime dateArrival;
        private DateTime dateSell;
        private Transmissiontype transmissionType;
        private Accessability accessability;
        private BodyTypes bodyType;
        private NumSeats numSeats;
        private NumDoors numDoors;
        private Size size;
        private DateTime ToDate(string date)
        {
            return Convert.ToDateTime(date);
        }
        public string NumberPlate
        {
            set
            {
                this.numberPlate = value;
            }
            get
            {
                return numberPlate;
            }
        }
        public string Model
        {
            get; set;
        }
        public string Colour
        {
            set
            {
                this.colour = value;
            }
            get
            {
                return colour;
            }
        }
        public string Mileage
        {
            set
            {
                this.mileage = value;
            }
            get
            {
                return mileage;
            }
        }
        public string AccidentHystory
        {
            set
            {
                this.accidentHistory = value;
            }
            get
            {
                return accidentHistory;
            }
        }
        public string Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return price;
            }
        }
        public string DateArrival
        {
            set
            {
                this.dateArrival = ToDate(value); //тот же метод возвращает дату
            }
            get
            {
                return dateArrival.ToString().Substring(0, 10);
            }
        }
        public string DateSell
        {
            set
            {
                this.dateSell = ToDate(value);
            }
            get
            {
                return dateSell.ToString().Substring(0, 10);
            }
        }
        public string TransmissionType1
        {
            set
            {
                if (value == "manual")
                {
                    this.transmissionType = Transmissiontype.manual;
                }
                else if (value == "automatic")
                {
                    this.transmissionType = Transmissiontype.automatic;
                }
            }
            get
            {
                return transmissionType.ToString();
            }
        }
        public string Accessability1
        {
            set
            {
                if (value == "available")
                {
                    this.accessability = Accessability.available;
                }
                else if (value == "sold")
                {
                    this.accessability = Accessability.sold;
                }
            }
            get
            {
                return accessability.ToString();
            }
        }
        public string BodyType1
        {
            set //итак далее для всех хреней в перчеслении а потом и во всех хренях с перечислениями, !!вроде сделал!!
            {
                if (value == "Van")
                {
                    this.bodyType = BodyTypes.Van;
                }
                else if (value == "Saloon")
                {
                    this.bodyType = BodyTypes.Saloon;
                }
                else if (value == "Coupe")
                {
                    this.bodyType = BodyTypes.Coupe;
                }
                else if (value == "Hatchback")
                {
                    this.bodyType = BodyTypes.Hatchback;
                }
                else if (value == "SUV")
                {
                    this.bodyType = BodyTypes.SUV;
                }
                else if (value == "MPV")
                {
                    this.bodyType = BodyTypes.MPV;
                }

            }
            get
            {
                return bodyType.ToString();
            }
        }
        public string NumSeats1
        {
            set
            {
                if (value == "two")
                {
                    this.numSeats = NumSeats.two;
                }
                else if (value == "three")
                {
                    this.numSeats = NumSeats.three;
                }
                else if (value == "four")
                {
                    this.numSeats = NumSeats.four;
                }
                else if (value == "fifth")
                {
                    this.numSeats = NumSeats.fifth;
                }
                else if (value == "seven")
                {
                    this.numSeats = NumSeats.seven;
                }
            }
            get
            {
                return numSeats.ToString();
            }
        }
        public string NumDoors1
        {
            set
            {
                if (value == "two")
                {
                    this.numDoors = NumDoors.two;
                }
                else if (value == "fifth")
                {
                    this.numDoors = NumDoors.fifth;
                }
            }
            get
            {
                return numDoors.ToString();
            }
        }
        public string Size1
        {
            set
            {
                if (value == "small")
                {
                    this.size = Size.small;
                }
                else if (value == "large")
                {
                    this.size = Size.large;
                }
            }
            get
            {
                return size.ToString();
            }
        }      
        public Car() //дописать, !!дописано наверно!!
        {
            this.numberPlate = "";
            this.colour = "";
            this.mileage = "";
            this.accidentHistory = "";
            this.price = "";
            this.size = Size.large;
            this.numDoors = NumDoors.two;
            this.numSeats = NumSeats.two;
            this.bodyType = BodyTypes.Saloon;
            this.accessability = Accessability.sold;
            this.transmissionType = Transmissiontype.manual;
            this.dateArrival = DateTime.Today;
            this.dateSell = new DateTime(); //вернет 01 01 01
        }
        public Car(string numberPlate, string model, BodyTypes bodyType, Size size, string colour, string mileage, string accidentHistory, Transmissiontype transmissiontype, string price, string dateArrival, string dateSell) //дописать !!completed!!
        {
            this.numberPlate = numberPlate;
            this.Model = model;
            this.bodyType = bodyType;
            this.size = size;
            this.colour = colour;
            this.mileage = mileage;
            this.accidentHistory = accidentHistory;
            this.transmissionType = transmissiontype;
            this.price = price;
            this.dateArrival = ToDate(dateArrival);//вызво метода преобразвоания
            this.dateSell = ToDate(dateSell);
        }

        public Car(string numberPlate, string model, BodyTypes bodyType,  string colour, string mileage, string accidentHistory, Transmissiontype transmissiontype, string price, string dateArrival, string dateSell) //дописать !!completed!!
        {
            this.numberPlate = numberPlate;
            this.Model = model;
            this.bodyType = bodyType;
            this.colour = colour;
            this.mileage = mileage;
            this.accidentHistory = accidentHistory;
            this.transmissionType = transmissiontype;
            this.price = price;
            this.dateArrival = ToDate(dateArrival);//вызво метода преобразвоания
            this.dateSell = ToDate(dateSell);
        }
        public Car(string numberPlate, string model, BodyTypes bodyType, string colour, string mileage, string accidentHistory, Transmissiontype transmissiontype, string price, string dateArrival) //дописать !!completed!!
        {
            this.numberPlate = numberPlate;
            this.Model = model;
            this.bodyType = bodyType;
            this.colour = colour;
            this.mileage = mileage;
            this.accidentHistory = accidentHistory;
            this.transmissionType = transmissiontype;
            this.price = price;
            this.dateArrival = ToDate(dateArrival);//вызво метода преобразвоания            
        }

        public Car(string numberPlate, string model, BodyTypes BodyType1, Size Size1, string colour, string mileage, string accidentHistory, Transmissiontype transmissiontype, string price, string dateArrival) //дописать !!completed!!
        {
            this.numberPlate = numberPlate;
            this.Model = model;
            this.bodyType = BodyType1;
            this.size = Size1;
            this.colour = colour;
            this.mileage = mileage;
            this.accidentHistory = accidentHistory;
            this.transmissionType = transmissiontype;
            this.price = price;
            this.dateArrival = ToDate(dateArrival);//вызво метода преобразвоания
        }

        //public Car(string numberPlate, string model, BodyTypes bodyType, Size size, string colour, string mileage, string accidentHistory, Transmissiontype transmissiontype, string price, string dateArrival) //дописать !!completed!!
        //{
        //    this.numberPlate = numberPlate;
        //    this.Model = model;
        //    this.bodyType = bodyType;
        //    this.size = size;
        //    this.colour = colour;
        //    this.mileage = mileage;
        //    this.accidentHistory = accidentHistory;
        //    this.transmissionType = transmissiontype;
        //    this.price = price;
        //    this.dateArrival = ToDate(dateArrival);//вызво метода преобразвоания
        //}

        // 3 v
        public Car(string numberPlate, string model, BodyTypes bodyType, string colour, string mileage, string accidentHistory, Transmissiontype transmissiontype, string price) //дописать !!completed!!
        {
            this.numberPlate = numberPlate;
            this.Model = model;
            this.bodyType = bodyType;
            this.colour = colour;
            this.mileage = mileage;
            this.accidentHistory = accidentHistory;
            this.transmissionType = transmissiontype;
            this.price = price;
        }

        public Car(string numberPlate, string model, BodyTypes bodyType, Size size, string colour, string mileage, string accidentHistory, Transmissiontype transmissiontype, string price) //дописать !!completed!!
        {
            this.numberPlate = numberPlate;
            this.Model = model;
            this.bodyType = bodyType;
            this.size = size;
            this.colour = colour;
            this.mileage = mileage;
            this.accidentHistory = accidentHistory;
            this.transmissionType = transmissiontype;
            this.price = price;
        }
        public override string ToString()
        {
            string result = $"NumberPlate: {NumberPlate}, Model: {Model}, BodyType: {BodyType1}, ";
            if (BodyType1 == "van")
            {
                result += $"Size: {Size1}, ";

            }
            result += $"Colour: {Colour}, Mileage: {Mileage}, AccidentHystory: {AccidentHystory}, TransmissionType: {TransmissionType1}, Price: {Price}, DateArrival: {DateArrival} ";
            if (dateSell.Year != 1)
            {
                result += $", DateSell: {DateSell}";
            }
            return result;
        }
    }
}
