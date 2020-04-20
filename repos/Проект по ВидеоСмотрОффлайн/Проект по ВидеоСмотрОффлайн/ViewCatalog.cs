using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Проект_по_ВидеоСмотрОффлайн
{
    class ViewCatalog
    {
        static string dirName = @"D:\аниме";
        public static void Shower()
        {
            List<string> dirs = new List<string>();      
            dirs = Directory.EnumerateDirectories(dirName).ToList();
            for (int i = 0; i < dirs.Count; i++)
            {
                dirs[i] = dirs[i].Substring(dirs[i].LastIndexOf(@"\") + 1);
            }
            string path = @"C:\Users\user\source\repos\Проект по ВидеоСмотрОффлайн\Проект по ВидеоСмотрОффлайн\CatalogOfAnime.txt";//C:\Users\User\source\repos\big project!!!!)))\big project!!!!)))\users.txt";
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var item in dirs)
                {
                    sw.WriteLine(item);
                }
            }
            //using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        alllogins.Add(DeEnigma(line.Substring(0, line.IndexOf(",")), 2).Trim());
            //        //alllogins.Add(DeEnigma(line.Substring(0, line.IndexOf(",")), 2));
            //    }
            //}
            static public string ListToStr(List<Car> cars, string role)
            {
                string result = "";

                if (role == "user")
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
        }
    }
}
