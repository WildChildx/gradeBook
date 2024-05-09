using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathLibraryTest
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_TwoPositives_ReturnsSum()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;
            int expectedSum = 8;

            // Act
            //int actualSum = MathLibrary.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
