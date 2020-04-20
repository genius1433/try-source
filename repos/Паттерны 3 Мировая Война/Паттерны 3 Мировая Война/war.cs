using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Паттерны_3_Мировая_Война
{
    class War
    {
        private static War instance;
        public static List<Army> FirstUnion = new List<Army>();
        public static List<Army> SecondUnion = new List<Army>();
        static War GetInstance()
        {
            List<IFabricUnit> fabrics = new List<IFabricUnit>() { new ChinaFactory(), new CCCRFactory(), new EUFactory(), new USAFactory(), new AustraliaFactory() };
            FirstUnion = new List<Army>() { new Army(fabrics[0], "China"), new Army(fabrics[1], "CCCR"), new Army(fabrics[2], "EU")};
            SecondUnion = new List<Army>() { new Army(fabrics[3], "USA"), new Army(fabrics[4], "Australia") };
            if (instance == null)
            {
                instance = new War();
            }
            return instance;
        }
        
        private War() { }
        public static double SumAttack(int union, bool earth)
        {
            double result = 0;
            if (union == 1)
            {
                if (earth == true)
                {
                    for (int i = 0; i < FirstUnion.Count; i++)
                    {
                        result += FirstUnion[i].attackEarth;
                    }
                }
                else if (earth == false)
                {
                    for (int i = 0; i < FirstUnion.Count; i++)
                    {
                        result += FirstUnion[i].attackWater;
                    }
                }
                else throw new Exception();
            }
            else if (union == 2)
            {
                if (earth == true)
                {
                    for (int i = 0; i < SecondUnion.Count; i++)
                    {
                        result += SecondUnion[i].attackEarth;
                    }
                }
                else if (earth == false)
                {
                    for (int i = 0; i < SecondUnion.Count; i++)
                    {
                        result += SecondUnion[i].attackWater;
                    }
                }
                else throw new Exception();
            }
            else throw new Exception("Значение союза введено неправильно");
            return result;
        }
        public static void ShowWinOfUnion(int union)
        {
            if (union == 1)
            {
                Console.Write("Победа за первым Союзом: ");
                for (int j = 0; j < FirstUnion.Count; j++)
                {
                    Console.Write(FirstUnion[j].countryName + ", ");
                }
                Console.WriteLine();
            }
            else if (union == 2)
            {
                Console.Write("Победа за вторым Союзом: ");
                for (int j = 0; j < SecondUnion.Count; j++)
                {
                    Console.Write(SecondUnion[j].countryName + ", ");
                }
                Console.WriteLine();
            }
            else throw new Exception("Wrong number of Union in ShowWinOfUnion");
        }
        public static string UnionListToStr(int union)
        {
            string result = "";
            if (union == 1)
            {
                for (int i = 0; i < FirstUnion.Count; i++)
                {
                    result += FirstUnion[i].countryName;
                }
            }
            else if (union == 2)
            {
                for (int i = 0; i < SecondUnion.Count; i++)
                {
                    result += SecondUnion[i].countryName;
                }
            }
            else throw new Exception("Something went wrong in UnionListToStr");
            return result;
        }

        public static void Wars()
        {
            Random random = new Random();
            double ostFUE;
            double ostFUW;
            double ostSUE;
            double ostSUW;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Стадия №" + i);
                ostFUE = random.Next(10, 21) * 0.1;
                ostFUW = random.Next(10, 21) * 0.1;
                ostSUE = random.Next(10, 21) * 0.1;
                ostSUW = random.Next(10, 21) * 0.1;
                for (int j = 0; j < FirstUnion.Count; j++)
                {
                    FirstUnion[j].attackEarth = Math.Round(FirstUnion[j].attackEarth / ostFUE, 0);
                    FirstUnion[j].attackWater = Math.Round(FirstUnion[j].attackWater / ostFUW, 0);
                }
                for (int j = 0; j < SecondUnion.Count; j++)
                {
                    SecondUnion[j].attackEarth = Math.Round(SecondUnion[j].attackEarth / ostSUE, 0);
                    SecondUnion[j].attackWater = Math.Round(SecondUnion[j].attackWater / ostSUW, 0);
                }
                Console.WriteLine("Наземное Сражение");
                if (ostFUE > ostSUE)
                {
                    ShowWinOfUnion(1);
                }
                else if (ostFUE < ostSUE)
                {
                    ShowWinOfUnion(2);
                }
                else Console.WriteLine("Паритет");
                Console.WriteLine("Оставшиеся наземные силы первого союза:");
                for (int j = 0; j < FirstUnion.Count; j++)
                {
                    Console.WriteLine(FirstUnion[j].countryName + ": " + FirstUnion[j].attackEarth);
                }
                Console.WriteLine("Оставшиеся наземные силы второго союза:");
                for (int j = 0; j < SecondUnion.Count; j++)
                {
                    Console.WriteLine(SecondUnion[j].countryName + ": " + SecondUnion[j].attackEarth);
                }
                Console.WriteLine("Морское Сражение");
                if (ostFUW > ostSUW)
                {
                    ShowWinOfUnion(1);
                }
                else if (ostFUW < ostSUW)
                {
                    ShowWinOfUnion(2);
                }
                else Console.WriteLine("Паритет");
                Console.WriteLine("Оставшиеся морские силы первого союза:");
                for (int j = 0; j < FirstUnion.Count; j++)
                {
                    Console.WriteLine(FirstUnion[j].countryName + ": " + FirstUnion[j].attackWater);
                }
                Console.WriteLine("Оставшиеся морские силы второго союза:");
                for (int j = 0; j < SecondUnion.Count; j++)
                {
                    Console.WriteLine(SecondUnion[j].countryName + ": " + SecondUnion[j].attackWater);
                }
                Console.WriteLine();
                Thread.Sleep(2000);
            }
            double FirstUnionAttackEarth = SumAttack(1, true);
            double FirstUnionAttackWater = SumAttack(1, false);
            double SecondUnionAttackEarth = SumAttack(2, true);
            double SecondUnionAttackWater = SumAttack(2, false);
            Console.WriteLine("Финальная Стадия");
            Console.WriteLine("Генеральное наземное сражение");
            if (SumAttack(1, true) - SumAttack(2, true) > 0)
            {
                ShowWinOfUnion(1);
                FirstUnionAttackEarth = FirstUnionAttackEarth - SecondUnionAttackEarth;
                SecondUnionAttackEarth = 0;
            }
            else if (SumAttack(1, true) - SumAttack(2, true) < 0)
            {
                ShowWinOfUnion(2);
                FirstUnionAttackEarth = 0;
                SecondUnionAttackEarth = Math.Abs(FirstUnionAttackEarth - SecondUnionAttackEarth);
            }
            else
            {
                Console.WriteLine("Все наземные войска обоих сторон мертвы");
                FirstUnionAttackEarth = 0;
                SecondUnionAttackEarth = 0;
            }
            Console.WriteLine("Генеральное морское сражение");
            if (FirstUnionAttackWater - SecondUnionAttackWater > 0)
            {
                ShowWinOfUnion(1);
                FirstUnionAttackWater = FirstUnionAttackWater - SecondUnionAttackWater;
                SecondUnionAttackWater = 0;
            }
            else if (FirstUnionAttackWater - SecondUnionAttackWater < 0)
            {
                ShowWinOfUnion(2);
                FirstUnionAttackWater = 0;
                SecondUnionAttackWater = Math.Abs(FirstUnionAttackWater - SecondUnionAttackWater);
            }
            else
            {
                Console.WriteLine("Все морские войска обоих сторон мертвы");
                FirstUnionAttackWater = 0;
                SecondUnionAttackWater = 0;
            }
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.WriteLine("??????????");
            Thread.Sleep(3000);
            Console.WriteLine();
            if (FirstUnionAttackEarth != 0 && FirstUnionAttackWater != 0)
            {
                Console.WriteLine("Безоговорочная Победа Объединённых Сил СССР и Китая");
            }
            else if (FirstUnionAttackEarth == 0 && FirstUnionAttackWater == 0)
            {
                Console.WriteLine("Безоговорочная Победа Объединённых Сил Европы и Америки");
            }
            else if (FirstUnionAttackEarth != 0 && FirstUnionAttackWater == 0 && FirstUnionAttackEarth >= SecondUnionAttackWater * 2)
            {
                Console.WriteLine("Победа Объединённых Сил СССР и Китая");
                Console.WriteLine("На грани фола: Победили за счет огромного превосходства наземных войск над кораблями противника");
            }
            else if (FirstUnionAttackEarth == 0 && FirstUnionAttackWater != 0 && FirstUnionAttackWater * 2 > SecondUnionAttackEarth)
            {
                Console.WriteLine("Победа Объединённых Сил СССР и Китая");
                Console.WriteLine("На грани фола: Победили за счет оставшихся кораблей");
            }
            else if (SecondUnionAttackEarth != 0 && SecondUnionAttackWater == 0 && SecondUnionAttackEarth >= FirstUnionAttackWater * 2)
            {
                Console.WriteLine("Победа Объединённых Сил Европы и Америки");
                Console.WriteLine("На грани фола: Победили за счет огромного превосходства наземных войск над кораблями противника");
            }
            else if (SecondUnionAttackEarth == 0 && SecondUnionAttackWater != 0 && SecondUnionAttackWater * 2 > FirstUnionAttackEarth)
            {
                Console.WriteLine("Победа Объединённых Сил Европы и Америки");
                Console.WriteLine("На грани фола: Победили за счет оставшихся кораблей");
            }
            else if (SecondUnionAttackEarth == 0 && SecondUnionAttackWater == 0 && FirstUnionAttackEarth == 0 && FirstUnionAttackWater == 0)
            {
                Console.WriteLine("Земля Вымерла");
            }
            else throw new Exception("Something went wrong");
        }
    }
}
