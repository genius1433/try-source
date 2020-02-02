using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace паттерны_трена //стратегия
{
    interface IFlyBehaviour
    {
        void Fly();

    }
    class CanFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("нарушены законы физики");
        }
    }
    class CannotFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("мир спокоен");
        }
    }
    interface IVzlomchikBehaviour
    {
        void Vzlom();

    }
    class CanTalk : IVzlomchikBehaviour
    {
        public void Vzlom()
        {
            Console.WriteLine("кря-кря");
        }
    }
    class CannotTalk : IVzlomchikBehaviour
    {
        public void Vzlom()
        {
            Console.WriteLine("mute");
        }
    }
    class WierdTalk : IVzlomchikBehaviour
    {
        public void Vzlom()
        {
            Console.WriteLine("dotathebest");
        }
    }
    abstract class Duck
    {
        protected IFlyBehaviour fly1;
        protected IVzlomchikBehaviour vzlom1;
        public virtual void Vzlom() { vzlom1.Vzlom(); }
        public virtual void Swim() { Console.WriteLine("Я тону"); }
        public virtual void Fly() { fly1.Fly(); }
        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            fly1 = flyBehaviour;
        }
        public void SetVzlomchikBehaviour(IVzlomchikBehaviour vzlomBehaviour)
        {
            vzlom1 = vzlomBehaviour;
        }
        public abstract void Display();
    }
    class GreyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Серый");
        }
        public GreyDuck()
        {
            fly1 = new CanFly();
            vzlom1 = new WierdTalk();
        }
    }
    class WhiteDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("белый");
        }
        public WhiteDuck()
        {
            fly1 = new CanFly();
            vzlom1 = new CanTalk();
        }
    }
    class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("я подделка");
        }
        public RubberDuck()
        {
            fly1 = new CannotFly();
            vzlom1 = new WierdTalk();
        }

    }
    class WoodDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("я горючее");
        }
        public WoodDuck()
        {
            fly1 = new CannotFly();
            vzlom1 = new CannotTalk();
        }

    }
}
