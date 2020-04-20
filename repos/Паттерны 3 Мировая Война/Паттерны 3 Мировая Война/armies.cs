using System;
using System.Collections.Generic;
using System.Text;

namespace Паттерны_3_Мировая_Война
{
    class Army
    {
        public  ISoldier[] Soldiers;
        public  IPlane[] Planes;
        public  IShip[] Ships;
        public  ITank[] Tanks;
        public double attackEarth;
        public double attackWater;
        public string countryName;
        public Army(IFabricUnit fabricUnits, string countryName)
        {
            this.countryName = countryName;
            Random random = new Random();
            Soldiers = new ISoldier[random.Next(100, 200)];
            Planes = new IPlane[random.Next(10, 20)];
            Ships = new IShip[random.Next(10, 20)];
            Tanks = new ITank[random.Next(5, 10)];
            for (int i = 0; i < Soldiers.Length; i++)
            {
                Soldiers[i] = fabricUnits.GetSoldier();
            }
            for (int i = 0; i < Planes.Length; i++)
            {
                Planes[i] = fabricUnits.GetPlane();
            }
            for (int i = 0; i < Ships.Length; i++)
            {
                Ships[i] = fabricUnits.GetShip();
            }
            for (int i = 0; i < Tanks.Length; i++)
            {
                Tanks[i] = fabricUnits.GetTank();
            }
            attackEarth = Soldiers.Length * Soldiers[0].Attack() +
                               Planes.Length * Planes[0].Attack() +
                               Tanks.Length * Tanks[0].Attack();
            attackWater = Ships.Length * Ships[0].Attack();
        }
    }               
}
