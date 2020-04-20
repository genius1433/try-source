using System;

namespace Паттерны_трена_1
{
    class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType type)
        {
            switch (type)
            {
                case FanType.TableFan:
                    return new TableFan();
                case FanType.CeilingFan:
                    return new CeilingFan();
                case FanType.ExhaustFan:
                    return new ExhaustFan();
                default:
                    return new TableFan();
            }
        }

    }
    class TableFanFactory : IFanFactory {....}

    class CeilingFanFactory : IFanFactory {....}

    class ExhaustFanFactory : IFanFactory {....}
    interface IFanFactory
    {
        IFan CreateFan();
    }
    class Program
    {

        //The client code is as follows:
        static void Main(string[] args)
        {
            IFanFactory fanFactory = new PropellerFanFactory();

            // Creation of a Fan using Factory Method Pattern
            IFan fan = fanFactory.CreateFan();

            // Use created object
            fan.SwitchOn();

            Console.ReadLine();
        }
    }
}
