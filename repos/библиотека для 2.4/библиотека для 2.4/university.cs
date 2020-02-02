using System;
using System.Runtime.InteropServices;

namespace university
{
    public abstract class Student
    {
        protected readonly string name;
        protected readonly string surName;
        protected readonly int course;
        protected readonly double mean;
        protected double communication;
        protected double rating;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string SurName
        {
            get
            {
                return surName;
            }
        }
        public int Course
        {
            get
            {
                return course;
            }
        }
        public double Mean
        {
            get
            {
                return mean;
            }
        }
        public abstract double Communication
        {
            get; set;
        }
        public abstract double Rating
        {
            get; set;
        }
        public Student(string name, string surName, int course, double mean)
        {

            if (course > 6 || course < 1)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else this.course = course;
            if (mean < 0 || mean > 10)
            {
                throw new System.ArgumentException();
            }
            else this.mean = mean;
            this.surName = surName;
            this.name = name;
            this.Communication = 0;
            this.Rating = 0;
        }
        public int compareCourse(Student b)
        {
            if (this.Course > b.Course)
            {
                return 1;
            }
            else if (this.Course < b.Course)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return "Имя: " + this.Name + " Фамилия: " + this.SurName + " Курс: " + this.Course + " Средний балл: " + Math.Round(this.Mean, 2);
        }
    }
    public class BadStudent : Student
    {
        readonly string hairStyle;
        public string HairStyle
        {
            get
            {
                return hairStyle;
            }
        }
        public BadStudent(string name, string surName, int course, double mean, string hairStyle) : base(name, surName, course, mean)
        {
            this.hairStyle = hairStyle;
        }
        public override string ToString()
        {
            return base.ToString() + " Стиль прически: " + HairStyle;
        }
        public override double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = Math.Abs(Mean * Course / Communication);
            }
        }
        public override double Communication
        {
            get
            {
                return communication;
            }
            set
            {
                if (HairStyle == "Chubby")
                {
                    communication = Math.Abs(0.5 * Mean * Course);
                }
                else communication = Math.Abs(Mean * Course % 12);
            }
        }
    }
    public class GoodStudent : Student
    {
        readonly string glasses;
        public string Glasses
        {
            get
            {
                return glasses;
            }
        }
        public GoodStudent(string name, string surName, int course, double mean, string glasses) : base(name, surName, course, mean)
        {
            this.glasses = glasses;
        }
        public override string ToString()
        {
            return base.ToString() + " Тип очков: " + Glasses;
        }
        public override double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = Math.Abs(Mean * Communication / Course);
            }
        }
        public override double Communication
        {
            get
            {
                return communication;
            }
            set
            {
                if (Glasses == "Round")
                {
                    communication = Math.Abs(Mean) + 10;
                }
                else communication = Math.Abs(10 - Mean) % 11;
            }
        }
    }
}
