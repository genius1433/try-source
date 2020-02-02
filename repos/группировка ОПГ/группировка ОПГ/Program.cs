using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace группировка_ОПГ
{
    class Program
    {
        class Phone
        {
            public string Name { get; set; }
            public string Company { get; set; }
        }
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>
            {
                new Phone {Name="Lumia 430", Company="Microsoft" },
                new Phone {Name="Mi 5", Company="Xiaomi" },
                new Phone {Name="LG G 3", Company="LG" },
                new Phone {Name="iPhone 5", Company="Apple" },
                new Phone {Name="Lumia 930", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple" },
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="LG G 4", Company="LG" }
            };
            //var groups = from phone in phones
            //             group phone by phone.Company;
            //foreach (var item in groups)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1.Name);
            //    }
            //}
            var groups = from phone in phones
                         group phone by phone.Company into g
                         select new { name = g.Key, count = g.Count() };
            foreach (var item in groups)
            {
                Console.WriteLine(item.name + item.count);
            }
            Console.ReadLine();
        }
    }
}
