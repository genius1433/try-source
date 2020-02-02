using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mass = new string[]{ "Apple","Phone","Orange","Radiation","Pork"};
            //var result = new List<string>();
            //foreach (var item in mass)
            //{
            //    if (item.ToUpper().StartsWith("P"))
            //    {
            //        result.Add(item);
            //    }
            //}
            //result.Sort();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            ////var result = from item in mass
            ////             where item.ToUpper().StartsWith("P")
            ////             orderby item
            ////             select item;
            var result = mass.Where(item => item.ToUpper().StartsWith("P")).OrderBy(item => item);
            foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
        }
    }
}
