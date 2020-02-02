using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_в_1000_попытка_2
{
    class Cloud
    {
        private const int x = 1000000000;
        private List<int> digits = new List<int>();
        private bool isNegative;
        int perexodMinus = 0;
        public int MinusHelper(int x1, int x2) // вычитает из 1 числа второе и если отрицательно то складывает с результатом 10^10
        {
            int result = 0;
            string tempstr = "10000000000";
            string tempresult = Math.Abs((x1 - x2)).ToString();
            if (x1 - x2 < 0)
            {
                for (int i = tempstr.Length - 1; i > 0; i--)
                {

                }
            }
            else result = int.Parse(tempresult);
            return result;
        }
        public void WriterToList(string x)
        {
            if (x.Length == 0)
            {
                isNegative = false;
            }
            else
            {
                if (x[0] == '-')
                {
                    x = x.Substring(1);
                    isNegative = true;
                }
                else isNegative = false;
            }
            for (int i = x.Length; i > 0; i -= 9)
            {
                if (i >= 9)
                {
                    digits.Add(int.Parse(x.Substring(i - 9, 9)));
                }
                else
                {
                    digits.Add(int.Parse(x.Substring(0, i)));
                }
            }
        }
        public static bool operator ==(Cloud x1, Cloud x2)
        {
            if ((x1.isNegative == true && x2.isNegative == false) || (x1.isNegative == false && x2.isNegative == true))
            {
                return false;
            }
            else if (x1.digits.Count != x2.digits.Count)
            {
                return false;
            }
            else
            {

                int temp = 0;
                for (int i = x1.digits.Count - 1; i >= 0; i--)
                {
                    if (x1.digits[i] != x2.digits[i])
                    {
                        temp = 1;
                        break;
                    }
                }
                if (temp == 1)
                {
                    return false;
                }
                else return true;
            }

        }
        public static bool operator !=(Cloud x1, Cloud x2)
        {
            return !(x1 == x2);
        }
        public static bool operator >(Cloud x1, Cloud x2)
        {
            if (x1.isNegative == true && x2.isNegative == false)
            {
                return false;
            }
            else if (x1.isNegative == false && x2.isNegative == true)
            {
                return true;
            }
            else if (x1.digits.Count < x2.digits.Count && x1.isNegative == true && x2.isNegative == true)
            {
                return true;
            }
            else if (x1.digits.Count > x2.digits.Count && x1.isNegative == true && x2.isNegative == true)
            {
                return false;
            }
            else if (x1.digits.Count > x2.digits.Count && x1.isNegative == false && x2.isNegative == false)
            {
                return true;
            }
            else if (x1.digits.Count < x2.digits.Count && x1.isNegative == false && x2.isNegative == false)
            {
                return false;
            }
            else if(x1.isNegative == true && x2.isNegative == true)
            {
                int temp = 0;
                for (int i = x1.digits.Count - 1; i >= 0; i--)
                {
                    if (x1.digits[i] < x2.digits[i])
                    {
                        temp = 1;
                        break;
                    }
                }
                if (temp == 1)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                int temp = 0;
                for (int i = x1.digits.Count - 1; i >= 0; i--)
                {
                    if (x1.digits[i] > x2.digits[i])
                    {
                        temp = 1;
                        break;
                    }
                }
                if (temp == 1)
                {
                    return true;
                }
                else return false;
            }
        }
        public static bool operator <(Cloud x1, Cloud x2)
        {
            return !(x1 > x2);
        }
        public static string operator +(Cloud x1, Cloud x2)
        {
            if (x1.digits.Count > x2.digits.Count)
            {
                int temp = 0;
                Cloud result = new Cloud("");
                //List<int> tempest = new List<int>();
                for (int i = 0; i < x1.digits.Count; i++)
                {
                    
                    if (x2.digits.Count - 1 >= i )
                    {
                        if ((x1.digits[i] + x2.digits[i]).ToString().Length > x1.digits[i].ToString().Length)
                        {
                            if (temp == 1)
                            {
                                result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                                temp = 0;
                            }
                            else result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)));
                            temp = 1;
                        }
                        else
                        {
                            if (temp == 1)
                            {
                                result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                                temp = 0;
                            }
                            else
                            {
                                result.digits.Add(x1.digits[i] + x2.digits[i]);
                            }
                        }
                    }
                }
                return result.Display();
            }
            else if (x1.digits.Count < x2.digits.Count)
            {
                int temp = 0;
                Cloud result = new Cloud("");
                //List<int> tempest = new List<int>();
                for (int i = 0; i < x2.digits.Count; i++)
                {

                    if (x1.digits.Count - 1 >= i)
                    {
                        if ((x1.digits[i] + x2.digits[i]).ToString().Length > x1.digits[i].ToString().Length)
                        {
                            if (temp == 1)
                            {
                                result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                                temp = 0;
                            }
                            else result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)));
                            temp = 1;
                        }
                        else
                        {
                            if (temp == 1)
                            {
                                result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                            }
                            else
                            {
                                result.digits.Add(x1.digits[i] + x2.digits[i]);
                            }
                        }
                    }
                }
                return result.Display();
            }
            else
            {
                int temp = 0;
                Cloud result = new Cloud("");
                //List<int> tempest = new List<int>();
                for (int i = 0; i < x1.digits.Count; i++)
                {

                    if ((x1.digits[i] + x2.digits[i]).ToString().Length > x1.digits[i].ToString().Length)
                    {
                        if (temp == 1)
                        {
                            result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                            temp = 0;
                        }
                        else result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)));
                        temp = 1;
                    }
                    else
                    {
                        if (temp == 1)
                        {
                            result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                        }
                        else
                        {
                            result.digits.Add(x1.digits[i] + x2.digits[i]);
                        }
                    }
                }
                return result.Display();
            }
        } //отрицание не влияет тк если один отр, то это отрицание будет, если 2 то сложение
        public static string operator -(Cloud x1, Cloud x2)
        {
            if (x1.digits.Count > x2.digits.Count)
            {
                int temp = 0;
                Cloud result = new Cloud("");
                //List<int> tempest = new List<int>();
                for (int i = 0; i < x1.digits.Count; i++)
                {

                    if (x2.digits.Count - 1 >= i)
                    {
                        if ((x1.digits[i] - x2.digits[i]).ToString().Length < 0)
                        {
                            if (temp == 1)
                            {
                                result.digits.Add(1000000000 - (x1.digits[i] - x2.digits[i]) - temp);
                                temp = 0;
                            }
                            else result.digits.Add(1000000000 - (x1.digits[i] - x2.digits[i]));
                            temp = 1;
                        }
                        else
                        {
                            if (temp == 1)
                            {
                                result.digits.Add((x1.digits[i] - x2.digits[i]) - temp);
                                temp = 0;
                            }
                            else
                            {
                                result.digits.Add(x1.digits[i] - x2.digits[i]);
                            }
                        }
                    }
                }
                return result.Display();
            }
            else if (x1.digits.Count < x2.digits.Count)
            {
                int temp = 0;
                Cloud result = new Cloud("");
                //List<int> tempest = new List<int>();
                for (int i = 0; i < x2.digits.Count; i++)
                {

                    if (x1.digits.Count - 1 >= i)
                    {
                        if ((x1.digits[i] + x2.digits[i]).ToString().Length > x1.digits[i].ToString().Length)
                        {
                            if (temp == 1)
                            {
                                result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                                temp = 0;
                            }
                            else result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)));
                            temp = 1;
                        }
                        else
                        {
                            if (temp == 1)
                            {
                                result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                            }
                            else
                            {
                                result.digits.Add(x1.digits[i] + x2.digits[i]);
                            }
                        }
                    }
                }
                return result.Display();
            }
            else
            {
                int temp = 0;
                Cloud result = new Cloud("");
                //List<int> tempest = new List<int>();
                for (int i = 0; i < x1.digits.Count; i++)
                {

                    if ((x1.digits[i] + x2.digits[i]).ToString().Length > x1.digits[i].ToString().Length)
                    {
                        if (temp == 1)
                        {
                            result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                            temp = 0;
                        }
                        else result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)));
                        temp = 1;
                    }
                    else
                    {
                        if (temp == 1)
                        {
                            result.digits.Add(int.Parse((x1.digits[i] + x2.digits[i]).ToString().Substring(1)) + 1);
                        }
                        else
                        {
                            result.digits.Add(x1.digits[i] + x2.digits[i]);
                        }
                    }
                }
                return result.Display();
            }
        }
        public string Display()
        {
            string result = "";
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                result += digits[i].ToString();
            }
            //char[] temp = result.ToCharArray();
            //Array.Reverse(temp);
            //result = new string(temp);
            return result;
        }
        public Cloud(string x)
        {
            WriterToList(x);
        }
        public Cloud(int x)
        {
            WriterToList(x.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = "1000000";
            int x2 = 1;
            Cloud one = new Cloud(x1);
            Cloud two = new Cloud(x2);
            Console.WriteLine(one - two);
            Console.WriteLine(one.Display());
            Console.ReadLine();
        }
    }
}
