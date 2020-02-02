using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university;

namespace вариант_4_большое_задание
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] mass = new Student[n];
            Random random = new Random();
            string[] names = { "Jon", "Nikita", "Alica", "Bob", "Kirill" };
            string[] surnames = {"L","Z","I","P","D"};
            string[] hairstyles = { "Bald", "UnderCut", "Chubby" };
            string[] glasses = { "None", "Round", "SquareHint" };
            Student lastStudent = new BadStudent("","",2,2,"Bald");
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int r = random.Next(0, 2);
                    if (r == 0)
                    {
                        mass[i] = new BadStudent(names[random.Next(0, names.Length)], surnames[random.Next(0, surnames.Length)], random.Next(1, 7), random.NextDouble() * 100, hairstyles[random.Next(0, hairstyles.Length)]);
                    }
                    else if (r == 1)
                    {
                        mass[i] = new GoodStudent(names[random.Next(0, names.Length)], surnames[random.Next(0, surnames.Length)], random.Next(1, 7), random.NextDouble() * 100, hairstyles[random.Next(0, hairstyles.Length)]);
                    }
                }
                int z = random.Next(0, 2);

                if (z == 0)
                {
                    lastStudent = new BadStudent(names[random.Next(0, names.Length)], surnames[random.Next(0, surnames.Length)], random.Next(1, 7), random.NextDouble() * 10, glasses[random.Next(0, hairstyles.Length)]);
                }
                else { lastStudent = new GoodStudent(names[random.Next(0, names.Length)], surnames[random.Next(0, surnames.Length)], random.Next(1, 7), random.NextDouble() * 10, hairstyles[random.Next(0, hairstyles.Length)]); }

                Console.WriteLine("Последний студент генерированый: " + lastStudent.ToString());
                int countStudentComm = 0;
                for (int i = 0; i < n; i++)
                {
                    if (mass[i].Communication < lastStudent.Communication)
                    {
                        Console.WriteLine(mass[i].ToString());
                        countStudentComm++;
                    }

                }
                Console.WriteLine($"Кол-во студентов с меньшей коммуникацией чем у последнего:" + countStudentComm);
                double maxRate = 0;
                int index = 0;
                for (int i = 0; i < n; i++)
                {
                    if (mass[i] is GoodStudent && mass[i].Rating > maxRate)
                    {
                        maxRate = mass[i].Rating;
                        index = i;
                    }
                }
                Console.WriteLine($"Самый популярный паинька{mass[index].ToString()}");
                int countBadStudents = 0;
                for (int i = 0; i < n; i++)
                {
                    if (mass[i] is BadStudent && mass[i].Course == 1)
                    {
                        countBadStudents++;
                        Console.WriteLine($"Плохой студент пришел:{mass[i].ToString()}");
                    }

                }
                Console.WriteLine($"Кол-во бездельников:{countBadStudents}");
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Недопустимое значение курса");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Недопустимое значение mean");
            }
            Console.ReadLine();
        }
    }
}
