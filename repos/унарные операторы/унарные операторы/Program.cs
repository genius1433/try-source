using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace унарные_операторы
{
    class Program
    {
        class MyArr
        {
            // Координаты точки в трехмерном пространстве
            public int x, y, z;

            public MyArr(int x = 0, int y = 0, int z = 0)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            // Перегружаем бинарный оператор +
            public static MyArr operator +(MyArr obj1, MyArr obj2)
            {
                MyArr arr = new MyArr();
                arr.x = obj1.x + obj2.x;
                arr.y = obj1.y + obj2.y;
                arr.z = obj1.z + obj2.z;
                return arr;
            }

            // Перегружаем бинарный оператор - 
            public static MyArr operator -(MyArr obj1, MyArr obj2)
            {
                MyArr arr = new MyArr();
                arr.x = obj1.x - obj2.x;
                arr.y = obj1.y - obj2.y;
                arr.z = obj1.z - obj2.z;
                return arr;
            }

            // Перегружаем унарный оператор -
            public static MyArr operator -(MyArr obj1)
            {
                MyArr arr = new MyArr();
                arr.x = -obj1.x;
                arr.y = -obj1.y;
                arr.z = -obj1.z;
                return arr;
            }

            // Перегружаем унарный оператор ++
            public static MyArr operator ++(MyArr obj1)
            {
                obj1.x += 1;
                obj1.y += 1;
                obj1.z += 1;
                return obj1;
            }

            // Перегружаем унарный оператор --
            public static MyArr operator --(MyArr obj1)
            {
                obj1.x -= 1;
                obj1.y -= 1;
                obj1.z -= 1;
                return obj1;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyArr Point1 = new MyArr(1, 12, -4);
                MyArr Point2 = new MyArr(0, -3, 18);
                Console.WriteLine("Координаты первой точки: " +
                    Point1.x + " " + Point1.y + " " + Point1.z);
                Console.WriteLine("Координаты второй точки: " +
                    Point2.x + " " + Point2.y + " " + Point2.z + "\n");

                MyArr Point3 = Point1 + Point2;
                Console.WriteLine("\nPoint1 + Point2 = "
                    + Point3.x + " " + Point3.y + " " + Point3.z);
                Point3 = Point1 - Point2;
                Console.WriteLine("Point1 - Point2 = "
                    + Point3.x + " " + Point3.y + " " + Point3.z);
                Point3 = -Point1;
                Console.WriteLine("-Point1 = "
                    + Point3.x + " " + Point3.y + " " + Point3.z);
                Point2++;
                Console.WriteLine("Point2++ = "
                    + Point2.x + " " + Point2.y + " " + Point2.z);
                Point2--;
                Console.WriteLine("Point2-- = "
                    + Point2.x + " " + Point2.y + " " + Point2.z);

                Console.ReadLine();
            }
        }
    }
}
