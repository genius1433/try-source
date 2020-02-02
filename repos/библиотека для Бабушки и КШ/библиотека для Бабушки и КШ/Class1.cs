using System;
using System.Collections.Generic;

namespace библиотека_для_Бабушки_и_КШ
{
    [Serializable]public class Road
    {
        public string name;
        public int[] houses;
        public static int operator !(Road obj)
        {
            return obj.houses.Length;
        }
        public static bool operator +(Road obj)
        {
            int counter = 0;
            for (int i = 0; i < obj.houses.Length; i++)
            {
                for (int j = 0; j < obj.houses.Length; i++)
                {
                    if (obj.houses[i] == obj.houses[j] + 1 || obj.houses[i] == obj.houses[j] - 1)
                    {
                        counter = 1;
                    }
                }
            }
            if (counter == 1)
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            List<int> list1 = new List<int>();
            for (int i = 0; i < houses.Length; i++)
            {
                list1.Add(houses[i]);
            }
            return name ;
        }
    }
}
