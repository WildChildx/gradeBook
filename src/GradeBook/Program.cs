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

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The higest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
        }
    }
}
