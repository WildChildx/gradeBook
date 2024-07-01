namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {
        //arrange
        var book = new Book("");
        book.AddGrade(20.3);
        book.AddGrade(45.2);
        book.AddGrade(24.5);
        book.AddGrade(34.2);

        //act
        var result = book.GetStatistics();

        //assert
        Assert.Equal(31.05, result.Average, 1);
        Assert.Equal(Math.Round(1.79, 2), Math.Round(result.High, 2));
        Assert.Equal(-1.8, result.Low, 1);
    }
}