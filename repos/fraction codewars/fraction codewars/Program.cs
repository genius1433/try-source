using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction_codewars
{
    public class Fraction
    {
        private long Top { get; set; }
        private long Bottom { get; set; }

        public Fraction(long numerator, long denominator)
        {
            Top = numerator;
            Bottom = denominator;
        }

        // Equality checking
        public override int GetHashCode() => this.GetHashCode(); // not actually used
        public override bool Equals(object o) => Compare(this, o as Fraction) == 0;
        public static bool operator ==(Fraction f1, Fraction f2) => Compare(f1, f2) == 0;
        public static bool operator !=(Fraction f1, Fraction f2) => Compare(f1, f2) != 0;
        private static long Compare(Fraction f1, Fraction f2) => f1.Top * f2.Bottom - f2.Top * f1.Bottom;

        public static string operator +(Fraction f1, Fraction f2)
        {
            long dresult = f1.Bottom * f2.Bottom;
            long nresult = f1.Top * f2.Bottom + f2.Top * f1.Bottom;
            long tempdresult = dresult;
            long tempnresult = nresult;
            while (tempdresult > 0 && tempnresult > 0)
            {
                if (tempdresult > tempnresult)
                {
                    tempdresult = tempdresult - tempnresult;
                }
                else
                {
                    tempnresult = tempnresult - tempdresult;
                }
            }
            dresult = dresult / Math.Max(tempnresult, tempdresult);
            nresult = nresult / Math.Max(tempnresult, tempdresult);
            Fraction result = new Fraction(nresult, dresult);
            return result.ToString();
        }
        public override string ToString()
        {
            return Top + "/" + Bottom;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 8);
            Fraction f2 = new Fraction(4, 5);           
            Console.WriteLine(f1 + f2);
            Console.ReadLine();
        }
    }
}
