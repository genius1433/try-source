using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace иерархия_классов_трена
{
    //Оркестр, Дирижер, Скрипка, Пианино, Гитара.
    abstract class Instruments
    {
        abstract public void Play();
    }
    class Orkestr
    {
        public Diriger diriger { get; }
        public List<Instruments> instruments { get; }
        public Orkestr(Diriger diriger)
        {
            this.diriger = diriger;
            instruments = new List<Instruments>();
        }
    }
    //3 скрипки, 2 гитары и пианино
    class Diriger
    {
        Orkestr orkestr;
        public Orkestr Create()
        {
            orkestr = new Orkestr(this);
            orkestr.instruments.AddRange(new Instruments[] { new Gitar(), new Gitar(), new Gitar(), new Skripka(), new Skripka(), new Piano() });
            return orkestr;
        }
        public void Play()
        {
            foreach (var item in orkestr.instruments)
            {
                item.Play();
            }
        }
    }
    class Skripka : Instruments
    {
        public override void Play()
        {
            Console.WriteLine("Скрыпка is plaing");
        }
    }
    class Piano : Instruments
    {
        public override void Play()
        {
            Console.WriteLine("Пианино is plaing");
        }
    }
    class Gitar : Instruments
    {
        public override void Play()
        {
            Console.WriteLine("Гитара is plaing");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Diriger diriger = new Diriger();
            var orkestr = diriger.Create();
            diriger.Play();
            Console.ReadLine();
        }
    }
}
