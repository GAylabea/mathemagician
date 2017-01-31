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
            FibonacciNumber fiboNumber = new FibonacciNumber();
            
            Assert.IsNotNull(fiboNumber);
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
        public void EnsureICanGetSequence()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            int[] expectedResult = { 1, 1, 2, 3, 5 };
            int[] actualResult = fiboNumber.GetSequence(5);
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
        }
        [TestMethod]
        public void EnsureICanGetPrintSequence()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            string expectedResult = "1 1 2 3 5 ";
            int[] inputArray = new [] { 1, 1, 2, 3, 5 };
            string actualResult = fiboNumber.PrintNumbers(inputArray);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
