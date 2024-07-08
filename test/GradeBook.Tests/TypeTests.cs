namespace GradeBook.Tests;
using System;
using xUnit;

public class TypeTests
{
    [Fact]
    public void UnitTest1()
    {
        //arrange 
        var book1 = new GetBook("Book 1");
        var book2 = new GetBook("Book 2");

        Assert.Equal("Book 1", book1.name);
        //act   
        //assert
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}