using System;
using System.Collections.Generic;
using System.Text;

namespace Паттерны_3_Мировая_Война
{
    interface IFabricUnit
    {
        ISoldier GetSoldier();
        IPlane GetPlane();
        IShip GetShip();
        ITank GetTank();
    }

    class ChinaFactory : IFabricUnit
    {
        public ISoldier GetSoldier()
        {
            return new ChinaSoldier();
        }
        public IPlane GetPlane()
        {
            return new ChinaPlane();
        }
        public IShip GetShip()
        {
            return new ChinaShip();
        }
        public ITank GetTank()
        {
            return new ChinaTank();
        }
    }
    class CCCRFactory : IFabricUnit
    {
        public ISoldier GetSoldier()
        {
            return new CCCRSoldier();
        }
        public IPlane GetPlane()
        {
            return new CCCRPlane();
        }
        public IShip GetShip()
        {
            return new CCCRShip();
        }
        public ITank GetTank()
        {
            return new CCCRTank();
        }
    }
    class EUFactory : IFabricUnit
    {
        public ISoldier GetSoldier()
        {
            return new EUSoldier();
        }
        public IPlane GetPlane()
        {
            return new EUPlane();
        }
        public IShip GetShip()
        {
            return new EUShip();
        }
        public ITank GetTank()
        {
            return new EUTank();
        }
    }
    class USAFactory : IFabricUnit
    {
        public ISoldier GetSoldier()
        {
            return new USASoldier();
        }
        public IPlane GetPlane()
        {
            return new USAPlane();
        }
        public IShip GetShip()
        {
            return new USAShip();
        }
        public ITank GetTank()
        {
            return new USATank();
        }
    }
    class AustraliaFactory : IFabricUnit
    {
        public ISoldier GetSoldier()
        {
            return new AustraliaSoldier();
        }
        public IPlane GetPlane()
        {
            return new AustraliaPlane();
        }
        public IShip GetShip()
        {
            return new AustraliaShip();
        }
        public ITank GetTank()
        {
            return new AustraliaTank();
        }
    }
}
