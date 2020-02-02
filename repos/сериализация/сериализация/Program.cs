using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace сериализация
{
    [DataContract] public class Human
    {
        [DataMember]public string name;
        [DataMember]public int age;
        //[NonSerialized]public int l;
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Human(){        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human obj = new Human("Jon", 20);
            Human other = new Human("-", 0);
            Human[] mass = new Human[]{ obj, other };
            DataContractJsonSerializer bin = new DataContractJsonSerializer(typeof(Human[]));
            using (FileStream writer = new FileStream("file.json", FileMode.OpenOrCreate))
            {
                bin.WriteObject(writer, mass);
            }
            using (FileStream writer = new FileStream("file.json", FileMode.OpenOrCreate))
            {
                Human[] mass1 = (Human[])(bin.ReadObject(writer));
                foreach (var item in mass1)
                {
                    Console.WriteLine(item.name + item.age);
                }
            }
            Console.ReadLine();
        }
    }
}
