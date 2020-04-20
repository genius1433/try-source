using System;
using System.Collections.Generic;
using System.Text;

namespace Паттерны_3_Мировая_Война
{
    class trash
    {
        //from program
        //Random random = new Random();
        //int ChinaSoldiersAttack;
        //int CCCRSoldiersAttack;
        //int EUSoldiersAttack;
        //int USASoldiersAttack;
        //int ChinaPlanesAttack;
        //int CCCRPlanesAttack;
        //int EUPlanesAttack;
        //int USAPlanesAttack;
        //int ChinaShipsAttack;
        //int CCCRShipsAttack;
        //int EUShipsAttack;
        //int USAShipsAttack;
        //int ChinaTanksAttack;
        //int CCCRTanksAttack;
        //int EUTanksAttack;
        //int USATanksAttack;
        //IFabricUnit ChinaUnits = new ChinaFactory();
        //IFabricUnit CCCRUnits = new CCCRFactory();
        //IFabricUnit EUUnits = new EUFactory();
        //IFabricUnit USAUnits = new USAFactory();
        //ISoldier[] ChinaSoldiers = new ISoldier[random.Next(100, 200)];
        //ISoldier[] CCCRSoldiers = new ISoldier[random.Next(150, 250)];
        //ISoldier[] EUSoldiers = new ISoldier[random.Next(120, 220)];
        //ISoldier[] USASoldiers = new ISoldier[random.Next(160, 260)];
        //IPlane[] ChinaPlanes = new IPlane[random.Next(10, 20)];
        //IPlane[] CCCRPlanes = new IPlane[random.Next(15, 25)];
        //IPlane[] EUPlanes = new IPlane[random.Next(12, 22)];
        //IPlane[] USAPlanes = new IPlane[random.Next(16, 26)];
        //IShip[] ChinaShips = new IShip[random.Next(40, 80)];
        //IShip[] CCCRShips = new IShip[random.Next(60, 100)];
        //IShip[] EUShips = new IShip[random.Next(48, 88)];
        //IShip[] USAShips = new IShip[random.Next(64, 104)];
        //ITank[] ChinaTanks = new ITank[random.Next(5, 10)];
        //ITank[] CCCRTanks = new ITank[random.Next(6, 10)];
        //ITank[] EUTanks = new ITank[random.Next(8, 12)];
        //ITank[] USATanks = new ITank[random.Next(4, 14)];
        //for (int i = 0; i < ChinaSoldiers.Length; i++)
        //{
        //    ChinaSoldiers[i] = ChinaUnits.GetSoldier();
        //}
        //for (int i = 0; i < CCCRSoldiers.Length; i++)
        //{
        //    CCCRSoldiers[i] = CCCRUnits.GetSoldier();
        //}
        //for (int i = 0; i < EUSoldiers.Length; i++)
        //{
        //    EUSoldiers[i] = EUUnits.GetSoldier();
        //}
        //for (int i = 0; i < USASoldiers.Length; i++)
        //{
        //    USASoldiers[i] = USAUnits.GetSoldier();
        //}
        //for (int i = 0; i < ChinaPlanes.Length; i++)
        //{
        //    ChinaPlanes[i] = ChinaUnits.GetPlane();
        //}
        //for (int i = 0; i < CCCRPlanes.Length; i++)
        //{
        //    CCCRPlanes[i] = CCCRUnits.GetPlane();
        //}
        //for (int i = 0; i < EUPlanes.Length; i++)
        //{
        //    EUPlanes[i] = EUUnits.GetPlane();
        //}
        //for (int i = 0; i < USAPlanes.Length; i++)
        //{
        //    USAPlanes[i] = USAUnits.GetPlane();
        //}
        //for (int i = 0; i < ChinaShips.Length; i++)
        //{
        //    ChinaShips[i] = ChinaUnits.GetShip();
        //}
        //for (int i = 0; i < CCCRShips.Length; i++)
        //{
        //    CCCRShips[i] = CCCRUnits.GetShip();
        //}
        //for (int i = 0; i < EUShips.Length; i++)
        //{
        //    EUShips[i] = EUUnits.GetShip();
        //}
        //for (int i = 0; i < USAShips.Length; i++)
        //{
        //    USAShips[i] = USAUnits.GetShip();
        //}
        //for (int i = 0; i < ChinaTanks.Length; i++)
        //{
        //    ChinaTanks[i] = ChinaUnits.GetTank();
        //}
        //for (int i = 0; i < CCCRTanks.Length; i++)
        //{
        //    CCCRTanks[i] = CCCRUnits.GetTank();
        //}
        //for (int i = 0; i < EUTanks.Length; i++)
        //{
        //    EUTanks[i] = EUUnits.GetTank();
        //}
        //for (int i = 0; i < USATanks.Length; i++)
        //{
        //    USATanks[i] = USAUnits.GetTank();
        //}
        //ChinaSoldiersAttack = ChinaSoldiers.Length * ChinaSoldiers[0].Attack();
        //CCCRSoldiersAttack = CCCRSoldiers.Length * CCCRSoldiers[0].Attack();
        //EUSoldiersAttack = EUSoldiers.Length * EUSoldiers[0].Attack();
        //USASoldiersAttack = USASoldiers.Length * USASoldiers[0].Attack();
        //ChinaPlanesAttack = ChinaPlanes.Length * ChinaPlanes[0].Attack();
        //CCCRPlanesAttack = CCCRPlanes.Length * CCCRPlanes[0].Attack();
        //EUPlanesAttack = EUPlanes.Length * EUPlanes[0].Attack();
        //USAPlanesAttack = USAPlanes.Length * USAPlanes[0].Attack();
        //ChinaShipsAttack = ChinaShips.Length * ChinaShips[0].Attack();
        //CCCRShipsAttack = CCCRShips.Length * CCCRShips[0].Attack();
        //EUShipsAttack = EUShips.Length * EUShips[0].Attack();
        //USAShipsAttack = USAShips.Length * USAShips[0].Attack();
        //ChinaTanksAttack = ChinaTanks.Length * ChinaTanks[0].Attack();
        //CCCRTanksAttack = CCCRTanks.Length * CCCRTanks[0].Attack();
        //EUTanksAttack = EUTanks.Length * EUTanks[0].Attack();
        //USATanksAttack = USATanks.Length * USATanks[0].Attack();
        //double CCCRandChinaAttackEarth;
        //double CCCRandChinaAttackWater;
        //double EUandUSAAttackEarth;
        //double EUandUSAAttackWater;
        //double ostCCE;
        //double ostCCW;
        //double ostESE;
        //double ostESW;            
        //CCCRandChinaAttackEarth = ChinaSoldiersAttack + CCCRSoldiersAttack + ChinaPlanesAttack + CCCRPlanesAttack +
        //                          ChinaTanksAttack + CCCRTanksAttack;
        //CCCRandChinaAttackWater = ChinaShipsAttack + CCCRShipsAttack;
        //EUandUSAAttackEarth = EUSoldiersAttack + USASoldiersAttack + EUPlanesAttack + USAPlanesAttack +
        //                      EUTanksAttack + USATanksAttack;
        //EUandUSAAttackWater = EUShipsAttack + USAShipsAttack;
        //for (int i = 1; i < 5; i++)
        //{
        //    Console.WriteLine("Стадия №" + i);
        //    ostCCE = random.Next(10, 21) * 0.1;
        //    ostCCW = random.Next(10, 21) * 0.1;
        //    ostESE = random.Next(10, 21) * 0.1;
        //    ostESW = random.Next(10, 21) * 0.1;
        //    CCCRandChinaAttackEarth = Math.Round(CCCRandChinaAttackEarth / ostCCE, 0);
        //    EUandUSAAttackEarth = Math.Round(EUandUSAAttackEarth / ostESE, 0);
        //    CCCRandChinaAttackWater = Math.Round(CCCRandChinaAttackWater / ostCCW, 0);
        //    EUandUSAAttackWater = Math.Round(EUandUSAAttackWater / ostESW, 0);
        //    Console.WriteLine("Наземное Сражение");
        //    if (ostCCE > ostESE)
        //    {
        //        Console.WriteLine("Победа за Союзом СССР и Китая");
        //    }
        //    else if (ostCCE < ostESE)
        //    {
        //        Console.WriteLine("Победа за Союзом Европы и Америки");
        //    }
        //    else Console.WriteLine("Паритет");
        //    Console.WriteLine("Оставшиеся наземные силы:");
        //    Console.WriteLine("СССР и Китай: " + CCCRandChinaAttackEarth);
        //    Console.WriteLine("Европа и Америка: " + EUandUSAAttackEarth);
        //    Console.WriteLine("Морское Сражение");
        //    if (ostCCW > ostESW)
        //    {
        //        Console.WriteLine("Победа за Союзом СССР и Китая");
        //    }
        //    else if (ostCCW < ostESW)
        //    {
        //        Console.WriteLine("Победа за Союзом Европы и Америки");
        //    }
        //    else Console.WriteLine("Паритет");
        //    Console.WriteLine("Оставшиеся морские силы:");
        //    Console.WriteLine("СССР и Китай: " + CCCRandChinaAttackWater);
        //    Console.WriteLine("Европа и Америка: " + EUandUSAAttackWater);
        //    Console.WriteLine();
        //    Thread.Sleep(2000);
        //}
        //Console.WriteLine("Финальная Стадия");
        //Console.WriteLine("Генеральное наземное сражение");
        //if (CCCRandChinaAttackEarth - EUandUSAAttackEarth > 0)
        //{
        //    Console.WriteLine("Победа за СССР и Китаем");
        //    CCCRandChinaAttackEarth = CCCRandChinaAttackEarth - EUandUSAAttackEarth;
        //    EUandUSAAttackEarth = 0;
        //}
        //else if (CCCRandChinaAttackEarth - EUandUSAAttackEarth < 0)
        //{
        //    Console.WriteLine("Победа за Европой И Америкой");
        //    CCCRandChinaAttackEarth = 0;
        //    EUandUSAAttackEarth = Math.Abs(CCCRandChinaAttackEarth - EUandUSAAttackEarth);
        //}
        //else
        //{
        //    Console.WriteLine("Все наземные войска обоих сторон мертвы");
        //    CCCRandChinaAttackEarth = 0;
        //    EUandUSAAttackEarth = 0;
        //}
        //Console.WriteLine("Генеральное морское сражение");
        //if (CCCRandChinaAttackWater - EUandUSAAttackWater > 0)
        //{
        //    Console.WriteLine("Победа за СССР и Китаем");
        //    CCCRandChinaAttackWater = CCCRandChinaAttackWater - EUandUSAAttackWater;
        //    EUandUSAAttackWater = 0;
        //}
        //else if (CCCRandChinaAttackWater - EUandUSAAttackWater < 0)
        //{
        //    Console.WriteLine("Победа за Европой И Америкой");
        //    CCCRandChinaAttackWater = 0;
        //    EUandUSAAttackWater = Math.Abs(CCCRandChinaAttackWater - EUandUSAAttackWater);
        //}
        //else
        //{
        //    Console.WriteLine("Все морские войска обоих сторон мертвы");
        //    CCCRandChinaAttackWater = 0;
        //    EUandUSAAttackWater = 0;
        //}
        //Console.WriteLine();
        //Thread.Sleep(3000);
        //Console.WriteLine("??????????");
        //Thread.Sleep(3000);
        //Console.WriteLine();
        //if (CCCRandChinaAttackEarth != 0 && CCCRandChinaAttackWater != 0)
        //{
        //    Console.WriteLine("Безоговорочная Победа Объединённых Сил СССР и Китая");
        //}
        //else if (CCCRandChinaAttackEarth == 0 && CCCRandChinaAttackWater == 0)
        //{
        //    Console.WriteLine("Безоговорочная Победа Объединённых Сил Европы и Америки");
        //}
        //else if (CCCRandChinaAttackEarth != 0 && CCCRandChinaAttackWater == 0 && CCCRandChinaAttackEarth >= EUandUSAAttackWater * 2)
        //{
        //    Console.WriteLine("Победа Объединённых Сил СССР и Китая");
        //    Console.WriteLine("На грани фола: Победили за счет огромного превосходства наземных войск над кораблями противника");
        //}
        //else if (CCCRandChinaAttackEarth == 0 && CCCRandChinaAttackWater != 0 && CCCRandChinaAttackWater * 2 > EUandUSAAttackEarth)
        //{
        //    Console.WriteLine("Победа Объединённых Сил СССР и Китая");
        //    Console.WriteLine("На грани фола: Победили за счет оставшихся кораблей");
        //}
        //else if (EUandUSAAttackEarth != 0 && EUandUSAAttackWater == 0 && EUandUSAAttackEarth >= CCCRandChinaAttackWater * 2)
        //{
        //    Console.WriteLine("Победа Объединённых Сил Европы и Америки");
        //    Console.WriteLine("На грани фола: Победили за счет огромного превосходства наземных войск над кораблями противника");
        //}
        //else if (EUandUSAAttackEarth == 0 && EUandUSAAttackWater != 0 && EUandUSAAttackWater * 2 > CCCRandChinaAttackEarth)
        //{
        //    Console.WriteLine("Победа Объединённых Сил Европы и Америки");
        //    Console.WriteLine("На грани фола: Победили за счет оставшихся кораблей");
        //}
        //else if (EUandUSAAttackEarth == 0 && EUandUSAAttackWater == 0 && CCCRandChinaAttackEarth == 0 && CCCRandChinaAttackWater == 0)
        //{
        //    Console.WriteLine("Земля Вымерла");
        //}
        //else Console.WriteLine("Что-то не так");



        //public static void War()
        //{
        //    List<IFabricUnit> fabrics = new List<IFabricUnit>() {new ChinaFactory(), new CCCRFactory(), new EUFactory(), new USAFactory()};
        //    List<Army> armiesOne = new List<Army>() { new Army(fabrics[0], "China"), new Army(fabrics[1], "CCCR")};
        //    List<Army> armiesTwo = new List<Army>() { new Army(fabrics[2], "EU"), new Army(fabrics[3], "USA") };
        //    Random random = new Random();
        //    double FirstUnionAttackEarth = chinaArmy.attackEarth + CCCRArmy.attackEarth;
        //    double FirstUnionAttackWater = chinaArmy.attackWater + CCCRArmy.attackWater;
        //    double SecondUnionAttackEarth = EUArmy.attackEarth + USAArmy.attackEarth;
        //    double SecondUnionAttackWater = EUArmy.attackWater + USAArmy.attackWater;
        //    double ostCCE;
        //    double ostCCW;
        //    double ostESE;
        //    double ostESW;
        //    for (int i = 1; i < 5; i++)
        //    {
        //        Console.WriteLine("Стадия №" + i);
        //        ostCCE = random.Next(10, 21) * 0.1;
        //        ostCCW = random.Next(10, 21) * 0.1;
        //        ostESE = random.Next(10, 21) * 0.1;
        //        ostESW = random.Next(10, 21) * 0.1;
        //        FirstUnionAttackEarth = Math.Round(FirstUnionAttackEarth / ostCCE, 0);
        //        SecondUnionAttackEarth = Math.Round(SecondUnionAttackEarth / ostESE, 0);
        //        FirstUnionAttackWater = Math.Round(FirstUnionAttackWater / ostCCW, 0);
        //        SecondUnionAttackWater = Math.Round(SecondUnionAttackWater / ostESW, 0);
        //        Console.WriteLine("Наземное Сражение");
        //        if (ostCCE > ostESE)
        //        {
        //            Console.WriteLine("Победа за Союзом СССР и Китая");
        //        }
        //        else if (ostCCE < ostESE)
        //        {
        //            Console.WriteLine("Победа за Союзом Европы и Америки");
        //        }
        //        else Console.WriteLine("Паритет");
        //        Console.WriteLine("Оставшиеся наземные силы:");
        //        Console.WriteLine("СССР и Китай: " + FirstUnionAttackEarth);
        //        Console.WriteLine("Европа и Америка: " + SecondUnionAttackEarth);
        //        Console.WriteLine("Морское Сражение");
        //        if (ostCCW > ostESW)
        //        {
        //            Console.WriteLine("Победа за Союзом СССР и Китая");
        //        }
        //        else if (ostCCW < ostESW)
        //        {
        //            Console.WriteLine("Победа за Союзом Европы и Америки");
        //        }
        //        else Console.WriteLine("Паритет");
        //        Console.WriteLine("Оставшиеся морские силы:");
        //        Console.WriteLine("СССР и Китай: " + FirstUnionAttackWater);
        //        Console.WriteLine("Европа и Америка: " + SecondUnionAttackWater);
        //        Console.WriteLine();
        //        Thread.Sleep(2000);
        //    }
        //    Console.WriteLine("Финальная Стадия");
        //    Console.WriteLine("Генеральное наземное сражение");
        //    if (FirstUnionAttackEarth - SecondUnionAttackEarth > 0)
        //    {
        //        Console.WriteLine("Победа за СССР и Китаем");
        //        FirstUnionAttackEarth = FirstUnionAttackEarth - SecondUnionAttackEarth;
        //        SecondUnionAttackEarth = 0;
        //    }
        //    else if (FirstUnionAttackEarth - SecondUnionAttackEarth < 0)
        //    {
        //        Console.WriteLine("Победа за Европой И Америкой");
        //        FirstUnionAttackEarth = 0;
        //        SecondUnionAttackEarth = Math.Abs(FirstUnionAttackEarth - SecondUnionAttackEarth);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Все наземные войска обоих сторон мертвы");
        //        FirstUnionAttackEarth = 0;
        //        SecondUnionAttackEarth = 0;
        //    }
        //    Console.WriteLine("Генеральное морское сражение");
        //    if (FirstUnionAttackWater - SecondUnionAttackWater > 0)
        //    {
        //        Console.WriteLine("Победа за СССР и Китаем");
        //        FirstUnionAttackWater = FirstUnionAttackWater - SecondUnionAttackWater;
        //        SecondUnionAttackWater = 0;
        //    }
        //    else if (FirstUnionAttackWater - SecondUnionAttackWater < 0)
        //    {
        //        Console.WriteLine("Победа за Европой И Америкой");
        //        FirstUnionAttackWater = 0;
        //        SecondUnionAttackWater = Math.Abs(FirstUnionAttackWater - SecondUnionAttackWater);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Все морские войска обоих сторон мертвы");
        //        FirstUnionAttackWater = 0;
        //        SecondUnionAttackWater = 0;
        //    }
        //    Console.WriteLine();
        //    Thread.Sleep(3000);
        //    Console.WriteLine("??????????");
        //    Thread.Sleep(3000);
        //    Console.WriteLine();
        //    if (FirstUnionAttackEarth != 0 && FirstUnionAttackWater != 0)
        //    {
        //        Console.WriteLine("Безоговорочная Победа Объединённых Сил СССР и Китая");
        //    }
        //    else if (FirstUnionAttackEarth == 0 && FirstUnionAttackWater == 0)
        //    {
        //        Console.WriteLine("Безоговорочная Победа Объединённых Сил Европы и Америки");
        //    }
        //    else if (FirstUnionAttackEarth != 0 && FirstUnionAttackWater == 0 && FirstUnionAttackEarth >= SecondUnionAttackWater * 2)
        //    {
        //        Console.WriteLine("Победа Объединённых Сил СССР и Китая");
        //        Console.WriteLine("На грани фола: Победили за счет огромного превосходства наземных войск над кораблями противника");
        //    }
        //    else if (FirstUnionAttackEarth == 0 && FirstUnionAttackWater != 0 && FirstUnionAttackWater * 2 > SecondUnionAttackEarth)
        //    {
        //        Console.WriteLine("Победа Объединённых Сил СССР и Китая");
        //        Console.WriteLine("На грани фола: Победили за счет оставшихся кораблей");
        //    }
        //    else if (SecondUnionAttackEarth != 0 && SecondUnionAttackWater == 0 && SecondUnionAttackEarth >= FirstUnionAttackWater * 2)
        //    {
        //        Console.WriteLine("Победа Объединённых Сил Европы и Америки");
        //        Console.WriteLine("На грани фола: Победили за счет огромного превосходства наземных войск над кораблями противника");
        //    }
        //    else if (SecondUnionAttackEarth == 0 && SecondUnionAttackWater != 0 && SecondUnionAttackWater * 2 > FirstUnionAttackEarth)
        //    {
        //        Console.WriteLine("Победа Объединённых Сил Европы и Америки");
        //        Console.WriteLine("На грани фола: Победили за счет оставшихся кораблей");
        //    }
        //    else if (SecondUnionAttackEarth == 0 && SecondUnionAttackWater == 0 && FirstUnionAttackEarth == 0 && FirstUnionAttackWater == 0)
        //    {
        //        Console.WriteLine("Земля Вымерла");
        //    }
        //    else Console.WriteLine("Что-то не так");
        //}
    }
}
