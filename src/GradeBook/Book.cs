namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics
            {
                Average = 0.0,
                High = double.MinValue,
                Low = double.MaxValue,
            };

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }


        private List<double> grades;
        private string name;
        private double lowGrade;
        private double highGrade;
    }
}