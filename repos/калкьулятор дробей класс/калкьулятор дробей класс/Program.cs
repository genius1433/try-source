using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калкьулятор_дробей_класс
{
    class Drobi
    {

        private int x;
        private int y;
        private int NOD(int x, int y)
        {
            if (y == 0)
            {
                return x;

            }
            return NOD(y, x % y);
        }
        private void Sokr()
        {
            int nod = NOD(x, y);
            x = x / nod;
            y = y / nod;
        }
        public Drobi(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Drobi()
        {
            this.x = 0;
            this.y = 1;
        }
        public Drobi(string a)
        {
            int position = a.IndexOf("/");
            string strin = a.Substring(0, position);
            string strin2 = a.Substring(position + 1);
            x = int.Parse(strin);
            y = int.Parse(strin2);
        }
        public void Dele(Drobi drobi)
        {
            if (drobi.y == 0)
            {
                drobi.y = 1;
            }
            Drobi result = new Drobi(drobi.y, drobi.x);            
            Mult(result);
        } // ненужен
        public static Drobi operator /(Drobi one,Drobi two)
        {
            Drobi result = new Drobi();
            result.x = one.x * two.y;
            result.y = one.y * two.x;
            result.Sokr();
            return result;
        }
        public static Drobi operator /(Drobi one, int n)
        {
            Drobi result = new Drobi();
            result.x = one.x * 1;
            result.y = one.y * n;
            result.Sokr();
            return result;
        }
        public static Drobi operator /(int n, Drobi two)
        {
            Drobi result = new Drobi();
            result.x = two.y * n;
            result.y = two.x * 1;
            result.Sokr();
            return result;
        }
        public void Mult(Drobi drobi) // ненужен
        {
            Drobi result = new Drobi();
            if (drobi.y == 0)
            {
                drobi.y = 1;
            }
            result.x = x * drobi.x;
            result.y = y * drobi.y;
            result.Sokr();
            result.Show();
        }
        public static Drobi operator *(Drobi one,Drobi two)
        {
            Drobi result = new Drobi();
            result.x = one.x * two.x;
            result.y = one.y * two.y;
            result.Sokr();
            return result;
        }
        public static Drobi operator *(Drobi one, int n)
        {
            Drobi result = new Drobi();
            result.x = one.x * n;
            result.y = one.y * 1;
            result.Sokr();
            return result;
        }
        public static Drobi operator *(int n, Drobi two)
        {
            Drobi result = new Drobi();
            result.x = n * two.x;
            result.y = 1 * two.y;
            result.Sokr();
            return result;
        }
        public void Sum(Drobi drobi)
        {
            Drobi result = new Drobi();
            if (y == drobi.y)
            {
                result.x = x + drobi.x;
                result.y = y;
            }
            else
            {
                result.x = x * drobi.y + drobi.x * y;
                result.y = y * drobi.y;
            }
            result.Sokr();
            result.Show();
        } // ненужен
        public static Drobi operator +(Drobi one, Drobi two)
        {
            Drobi result = new Drobi();
            if (one.y == two.y)
            {
                result.x = one.x + two.x;
                result.y = one.y;
            }
            else
            {
                result.x = one.x * two.y + two.x * one.y;
                result.y = one.y * two.y;
            }
            return result;
        }
        public void Minus(Drobi drobi)
        {
            Drobi result = new Drobi();
            if (y == drobi.y)
            {
                result.x = x - drobi.x;
                result.y = y;
            }
            else
            {
                result.x = x * drobi.y - drobi.x * y;
                result.y = y * drobi.y;
            }
            result.Sokr();
            result.Show();
        } // ненужен
        public static Drobi operator -(Drobi one, Drobi two)
        {
            Drobi result = new Drobi();
            if (one.y == two.y)
            {
                result.x = one.x - two.x;
                result.y = one.y;
            }
            else
            {
                result.x = one.x * two.y - two.x * one.y;
                result.y = one.y * two.y;
            }
            return result;
        }
        public void Power(int n)
        {
            
            Drobi result = new Drobi(1,1);
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result.x = result.x * x;
                    result.y = result.y * y;
                }
            }
            else if (n < 0)
            {
                for (int i = 0 ; i < Math.Abs(n); i++)
                {
                    result.x = result.x * x;
                    result.y = result.y * y;
                }
                int temp = result.x;
                result.x = result.y;
                result.y = temp;
            }
            result.Sokr();
            result.Show();
        } // ненужен
        public static Drobi operator ^(Drobi one,int n)
        {
            Drobi result = new Drobi(1,1);
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result.x = result.x * one.x;
                    result.y = result.y * one.y;
                }
            }
            else if (n < 0)
            {
                for (int i = 0; i < Math.Abs(n); i++)
                {
                    result.x = result.x * one.x;
                    result.y = result.y * one.y;
                }
                int temp = result.x;
                result.x = result.y;
                result.y = temp;
            }

            return result;
        }
        public static bool operator ==(Drobi one,Drobi two)
        {
            Drobi oneCopy = new Drobi (one.x,one.y);
            Drobi twoCopy = new Drobi (two.x,two.y);
            oneCopy.Sokr();
            twoCopy.Sokr();
            if (oneCopy.x == twoCopy.x && oneCopy.y == twoCopy.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Drobi one, Drobi two)
        {
            return !(one == two);
        }
        public static bool operator >(Drobi one, Drobi two)
        {
            return (double)one > (double)two;
        }
        public static bool operator <(Drobi one, Drobi two)
        {
            return !(one > two);
        }
        public static implicit operator string(Drobi one)
        {
            return one.x + "/" + one.y;
        }
        public static implicit operator double(Drobi one)
        {
            return ((double)one.x) / one.y;
        }
        public void Show()
        {
            int temp = 0;
            if (x > y)
            {
                temp = x / y;
                x = x % y;
                Console.WriteLine(temp + " " + x + "/" + y);
            }
            else if (x == y)
            {
                Console.WriteLine(1);
            }
            else Console.WriteLine(x + "/" + y);
        }               
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drobi a = new Drobi("6/9");
            Drobi b = new Drobi(6, 3);
            Console.WriteLine(a < b);
            Console.WriteLine((double)a);
            //int q = 1;
            //q += 3;
            Console.ReadLine();
        }
    }    
}
