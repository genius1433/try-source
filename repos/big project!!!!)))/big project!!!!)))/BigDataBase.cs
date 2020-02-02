using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace big_project_______
{
    static class BigDataBase
    {
        private static string Enigma(string x, int cdvig)
        {
            string al = "abcdefghijklmnopqrstuvwxyz0123456789!№;%:?*()-_=+@#$^&~`";
            string x1 = "";
            for (int i = 0; i < x.Length; i++) { x1 = x1 + al[(al.IndexOf(x[i]) + cdvig) % al.Length]; }
            return x1;
        }
        private static string DeEnigma(string x, int cdvig)
        {
            string al = "abcdefghijklmnopqrstuvwxyz0123456789!№;%:?*()-_=+@#$^&~`";
            string x1 = "";
            for (int i = 0; i < x.Length; i++) { x1 = x1 + al[(al.IndexOf(x[i]) - cdvig) % al.Length]; }
            return x1;
        }
        public static int CreateDataBase() //сделано, блокнот - users.txt 
        {
            string path = @"C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\users.txt";
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                string[] mass = {"admin1, apple, admin", "staff1, orange, staff", "customer1, lemon, customer"};
                for (int i = 0; i < 3; i++)
                {
                    sw.WriteLine(Enigma(mass[i], 2));
                }
            }
            return 1;
        }
        public static int AddToDataBase(string login, string password, string role) // вроде сделал
        {
            if (IsUserRegistred(login,password,role) == false)
            {
                string path = @"C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\users.txt";
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.Write(Enigma(login, 2) + ", " + Enigma(password, 2) + ", " + Enigma(role, 2));
                }
            }
            return 1;
        }
        private static List<string> ReaderLogins() //сделано, считка всех логинов в лист
        {
            string path = @"C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\users.txt";
            List<string> alllogins = new List<string>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    alllogins.Add(DeEnigma(line.Substring(0, line.IndexOf(",")), 2));
                }
            }
            return alllogins;
        }
        private static List<DataBase> ReaderAllDataBase() //считка всей базы юзеров, вродь сделано
        {
            List<DataBase> allDataBase = new List<DataBase>();
            string path = @"C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\users.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    DataBase obj = new DataBase(DeEnigma(line.Substring(0,line.IndexOf(",")), 2), DeEnigma(line.Substring(line.IndexOf(","), line.IndexOf(",", line.IndexOf(",") + 3)), 2), DeEnigma(line.Substring(line.IndexOf(",") + 3), 2));
                    allDataBase.Add(obj);
                }
            }
            return allDataBase;
        }
        private static bool IsUserRegistred(string login, string password, string role)
        {
            int islogin = -1;
            int ispassword = -1;
            int isrole = -1;
            int indexOfUser = 0;
            List<DataBase> alldatabase = ReaderAllDataBase();
            for (int i = 0; i < alldatabase.Count; i++)
            {
                if (alldatabase[i].Login == login)
                {
                    islogin = 1;
                    indexOfUser = i;
                }
            }
            if (islogin == 1 && alldatabase[indexOfUser].Password == password && alldatabase[indexOfUser].Role == role)
            {
                ispassword = 1;
                isrole = 1;
            }
            if (ispassword == -1 || islogin == -1 || isrole == -1){return false;}
            else return true;
        }
        public static bool Login(string login, string password, string role)
        {
            if (IsUserRegistred(login,password,role) == true)
            {
                return true;
            }
            else return false;
        }
    }
}
