using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace эксперимент_с_созданием_папок_и_записыванием
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\source\folder\trytwo.txt";
            string subpath = @"program\avalon";
            int i = 0;
            //DirectoryInfo dirInfo = new DirectoryInfo(path);
            //if (!dirInfo.Exists)a
            //{
            //    dirInfo.Create();
            //}
            //dirInfo.CreateSubdirectory(subpath);
            FileInfo fileInf = new FileInfo(path);
            if (!fileInf.Exists)
            {
                fileInf.Create();
            }
            string writePath = path;
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Созданный из программы текстовый файл хы");
            }
            Console.ReadLine();
        }
    }
}
