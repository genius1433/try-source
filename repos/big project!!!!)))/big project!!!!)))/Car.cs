using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_project_______
{
    enum Transmissiontype { manual, automatic}; //manual - ручная коробка передач   
    enum Accessability { available, sold};
    enum BodyTypes { saloon, coupe, hatchback, van, SUV, MPV};
    enum NumSeats { two, three, four, fifth, seven};
    enum NumDoors { two, fifth};
    enum Size {small, large};
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
        //public string Size
        //{
        //    set
        //    {
        //        this.size = value;
        //    }
        //    get
        //    {
        //        return size;
        //    }
        //}
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
                return dateArrival.ToString();
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
                return dateSell.ToString();
            }
        }
        //public string DateArrival позже
        //{
        //    get
        //    {

        //    }
        //    set
        //    {

        //    }
        //}

        //public Transmissiontype TransmissionType
        //{
        //    set
        //    {
        //        this.transmissionType = value;
        //    }
        //    get
        //    {
        //        return transmissionType;
        //    }
        //}
        //public Accessability Accessability
        //{
        //    set
        //    {
        //        this.accessability = value;
        //    }
        //    get
        //    {
        //        return accessability;
        //    }
        //}
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
                if (value == "van")
                {
                    this.bodyType = BodyTypes.van;
                }
                else if (value == "saloon")
                {
                    this.bodyType = BodyTypes.saloon;
                }
                else if (value == "coupe")
                {
                    this.bodyType = BodyTypes.coupe;
                }
                else if (value == "hatchback")
                {
                    this.bodyType = BodyTypes.hatchback;
                }
                else if (value == "SUV")
                {
                    this.bodyType = BodyTypes.SUV;
                }
                esle if (value == "MPV")
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
        //public NumSeats NumSeats
        //{
        //    set
        //    {
        //        this.numSeats = value;
        //    }
        //    get
        //    {
        //        return numSeats;
        //    }
        //}
        //public NumDoors NumDoors
        //{
        //    set
        //    {
        //        this.numDoors = value;
        //    }
        //    get
        //    {
        //        return numDoors;
        //    }
        //}
        //public Size Size
        //{
        //    set
        //    {
        //        this.size = value;
        //    }
        //    get

        //    {
        //        return size;
        //    }
        //}
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
            this.bodyType = BodyTypes.saloon;
            this.accessability = Accessability.sold;
            this.transmissionType = Transmissiontype.manual;
            this.dateArrival = DateTime.Today;
            this.dateSell = new DateTime(); //вернет 01 01 01
        }
        //ниже про даты??
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
        public override string ToString()
        {
            string result = $"{NumberPlate}, {Model}, {BodyType1}, ";
            if (BodyType1 == "van" )
            {
                result += $"{Size1}, ";
                
            }
            result += $"{Colour}, {Mileage}, {AccidentHystory}, {TransmissionType1}, {Price}, {DateArrival} ";
            if (dateSell.Year != 1)
            {
                result += $"{dateSell}";
            }
            return result;
        }
    }
}
