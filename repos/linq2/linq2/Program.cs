using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
        public User()
        {
            Languages = new List<string>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
                        {
                         new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                              new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Том", Age=22, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            //            //var result = from item in users
            //            //             from lang in item.Languages
            //            //             where item.Age < 25 && lang == "английский"
            //            //             select item.Name;
            //            //foreach (var item in result)
            //            //{
            //            //    Console.WriteLine(item);
            //            //}
            //            var result = from item in users
            //                         orderby item.Name descending, item.Age descending
            //                         select item;
            //            var result1 = users.OrderByDescending(item => item.Name).ThenBy(item => item.Age);
            //            foreach (var item in result1)
            //            {
            //                Console.WriteLine(item.Name + item.Age);
            //            }

            //string[] mass = {"ll", "pp", "aa" };
            //string[] mass1 = {"oo","tt","pp" };
            //var result = mass.Union(mass1);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] mass2 = {1,2,9,0};
            //var result2 = mass2.Aggregate((x, y) => x + y);
            //Console.WriteLine(result2);
            //var result = users.Max(user => user.Age);
            //Console.WriteLine(result);
            int[] mass = { 1, 9, 77, 3 };
            var result = mass.Skip(2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
