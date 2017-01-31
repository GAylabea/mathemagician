using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        // F3 = F2 + F1
        // F7 = 
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }
        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            //Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();
            //Act

            //Assert
        }
        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            //Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();
            //Act

            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EnsureICanGetNextFibonacciNumber()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();
            //Act
            int expectedResult = 1;
            int actualResult = fiboNumber.GetNext();
            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
