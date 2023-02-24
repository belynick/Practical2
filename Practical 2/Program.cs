using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFilt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentA = new Student("Рома", 12, 11.3);
            Student studentB = new Student("Мiша", 11, 10.5);
            Student studentC = new Student("Iван", 10, 7.2);
            Student studentD = new Student("Дiма", 9, 8.8);
            Student studentE = new Student("Вася", 8, 7.4);

            List<Student> students = new List<Student>()
            {
                studentA, studentB, studentC, studentD , studentE
            };

            Console.WriteLine("Невiдфiльтрованi студенти:");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, Найвищий бал: {student.HighestMark}, Cереднiй бал: {student.AvgMark}");
            }

            Console.WriteLine();
            Console.WriteLine("Cтуденти вiдфiльтрованi за найвищим балом:");

            var selectedByHighestMark = students.Where(x => x.HighestMark >= 10);
            foreach (var student in selectedByHighestMark)
            {
                Console.WriteLine($"{student.Name}, Найвищий бал: {student.HighestMark}, Cереднiй бал: {student.AvgMark}");
            }

            Console.WriteLine();
            Console.WriteLine("Cтуденти вiдфiльтрованi за cереднiм балом:");

            var selectedByAvgMark = students.Where(x => x.AvgMark >= 10);
            foreach (var student in selectedByAvgMark)
            {
                Console.WriteLine($"{student.Name}, Найвищий бал: {student.HighestMark}, Cереднiй бал: {student.AvgMark}");
            }
        }
    }
}
