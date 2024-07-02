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
        Assert.Equal(45.2, result.High, 1);
        Assert.Equal(20.3, result.Low, 1);
    }
}