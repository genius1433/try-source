using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace испытание_BigProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetTempFileName();
            FileInfo file = new FileInfo(path);
            using (StreamWriter l = file.CreateText())
            {
                l.WriteLine("dasdsa");
            }
            Console.ReadLine();
        }
    }
}
