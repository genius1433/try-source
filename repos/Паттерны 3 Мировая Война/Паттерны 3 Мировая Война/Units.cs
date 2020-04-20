using System;
using System.Collections.Generic;
using System.Text;

namespace Паттерны_3_Мировая_Война
{
    interface ISoldier
    {
        abstract public int Attack();
    }
    interface IPlane
    {
        abstract public int Attack();
    }
    interface IShip
    {
        abstract public int Attack();
    }
    interface ITank
    {
        abstract public int Attack();
    }
    class ChinaSoldier : ISoldier
    {
        public int attack = 10;
        public int splash = 1;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class ChinaPlane : IPlane
    {
        public int attack = 100;
        public int splash = 3;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class ChinaShip : IShip
    {
        public int attack = 200;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class ChinaTank : ITank
    {
        public int attack = 120;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class CCCRSoldier : ISoldier
    {
        public int attack = 10;
        public int splash = 1;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class CCCRPlane : IPlane
    {
        public int attack = 100;
        public int splash = 3;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class CCCRShip : IShip
    {
        public int attack = 200;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class CCCRTank : ITank
    {
        public int attack = 120;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class EUSoldier : ISoldier
    {
        public int attack = 10;
        public int splash = 1;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class EUPlane : IPlane
    {
        public int attack = 100;
        public int splash = 3;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class EUShip : IShip
    {
        public int attack = 200;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class EUTank : ITank
    {
        public int attack = 120;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class USASoldier : ISoldier
    {
        public int attack = 10;
        public int splash = 1;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class USAPlane : IPlane
    {
        public int attack = 100;
        public int splash = 3;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class USAShip : IShip
    {
        public int attack = 200;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class USATank : ITank
    {
        public int attack = 120;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }

    class AustraliaSoldier : ISoldier
    {
        public int attack = 10;
        public int splash = 1;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class AustraliaPlane : IPlane
    {
        public int attack = 100;
        public int splash = 3;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class AustraliaShip : IShip
    {
        public int attack = 200;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
    class AustraliaTank : ITank
    {
        public int attack = 120;
        public int splash = 2;
        public int Attack()
        {
            return attack * splash;
        }
    }
}
