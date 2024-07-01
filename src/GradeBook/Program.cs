namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gradebook");
            book.AddGrade(20.3);
            book.AddGrade(45.2);
            book.AddGrade(24.5);

            book.AddGrade(34.2);

            var grades = new List<double>() { 1.1, 1.2, 1.3, 1.4, 1.5 };

            var result = 0.0;

            foreach (var grade in grades)
                result += grade;

            Console.WriteLine("Average is :" + result / grades.Count);
        }
    }
}
