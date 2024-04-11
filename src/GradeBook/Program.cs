using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 1.1, 1.2, 1.3, 1.4, 1.5 };

            var sum = 0.0;

            foreach (var grade in grades)
                sum += grade;

            Console.WriteLine("Average is :" + sum / grades.Count);
        }
    }
}
