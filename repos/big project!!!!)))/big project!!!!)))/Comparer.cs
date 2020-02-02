using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_project_______
{
    class DateComparer : IComparer<Car>
    {
        public int Compare(Car o1, Car o2)
        {
            if (o1.DateSell.CompareTo(o2.DateSell) < 0)
            {
                return -1;
            }
            else if (o1.DateSell.CompareTo(o2.DateSell) == 0)
            {
                if (o1.DateArrival.CompareTo(o2.DateArrival) < 0)
                {
                    return -1;
                }
                else if (o1.DateArrival.CompareTo(o2.DateArrival) == 0)
                {
                    return 0;
                }
                else return 1;
            }
            else return 1;
        }
    }
}
