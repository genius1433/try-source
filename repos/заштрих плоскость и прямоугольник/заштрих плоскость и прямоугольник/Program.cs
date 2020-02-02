using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace заштрих_плоскость_и_прямоугольник
{
    struct S
    {
        public int x;
        public int y;
        public S(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static bool F(int[,] mass, S up, S down)
        {
            for (int i = up.x; i < down.x; i++)
            {
                for (int j = up.y; j < down.y; j++)
                {
                    if (mass[i,j] == 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] mass = new int[8, 8] { 
                                         {0,0,1,0,1,0,0,0 },
                                         {0,1,1,0,1,1,0,0 },
                                         {1,1,1,0,0,0,0,1 },
                                         {1,1,0,0,0,0,1,1 },
                                         {0,0,0,1,0,0,0,1 },
                                         {0,0,0,0,0,0,1,1 },
                                         {0,0,1,0,0,0,0,0 },
                                         {0,1,0,1,0,1,0,1 }
                                        };
            int n = 8;
            int result = 0;
            S up = new S(0, 0);
            S down = new S(0, 0);
            for (int x1 = 0; x1 < n; x1++)
            {
                for (int y1 = 0; y1 < n; y1++)
                {
                    for (int x2 = x1; x2 < n; x2++)
                    {
                        for (int y2 = y1; y2 < n; y2++)
                        {

                            if (F(mass, new S(x1,y1), new S(x2 + 1,y2 + 1)) == true && (x2 - x1 + 1) * (y2 - y1 + 1) > result )
                            {
                                result = (x2 - x1 + 1) * (y2 - y1 + 1);
                                up.x = x1;
                                up.y = y1;
                                down.x = x2;
                                down.y = y2;
                            }
                        }

                    }
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(up.x + " " + up.y);
            Console.WriteLine(down.x + " " + down.y);
            Console.ReadLine();
        }
    }
}
