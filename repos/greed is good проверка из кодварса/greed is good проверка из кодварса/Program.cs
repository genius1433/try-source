using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greed_is_good_проверка_из_кодварса
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работает нормально = пофикшено!
            int result = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int fou = 0;
            int five = 0;
            int six = 0;
            int n = int.Parse(Console.ReadLine());
            int[] dice = new int[n];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 1) { one++; }
                if (dice[i] == 2) { two++; }
                if (dice[i] == 3) { three++; }
                if (dice[i] == 4) { fou++; }
                if (dice[i] == 5) { five++; }
                if (dice[i] == 6) { six++; }
            }
            if (one > 2) { while (one > 2) { result = result + 1000; one = one - 3; } }
            if (one > 0) { result = result + 100 * one; }
            if (two > 2) { while (two > 2) { result = result + 200; two = two - 3; } }
            if (three > 2) { while (three > 2) { result = result + 300; three = three - 3; } }
            if (fou > 2) { while (fou > 2) { result = result + 400; fou = fou - 3; } }
            if (five > 2) { while (five > 2) { result = result + 500; five = five - 3; } }
            if (five > 0) { result = result + five * 50; }
            if (six > 2) { while (six > 2) { result = result + 600; six = six - 3; } }
            for (int i = 0; i < dice.Length; i++)
            {
                Console.Write(dice[i] + " ");
            }
            Console.WriteLine(" = " + result);
            Console.ReadLine();
        }
    }
}
