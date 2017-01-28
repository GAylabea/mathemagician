using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        // This is a sanity check test - ensures everything is hooking up correctly AND
        // that the permissions are correct. 
        // you should have 5 tests - each method and a descriptive name for this
        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (set it up - instatiate for this)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (call the method - ONE - you are testing; compare expected with actual result)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (check the method's output)
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void EnsureICanGetNext()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
            // Act
            int expectedResult = 4;
            //in myNum; this is zero 0

            // it doesn't matter what numbers you use; you are 
            int actualResult = naturalNumber.GetNext(3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureICanGetSequence()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
            // Act
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //in myNum; this is zero 0

            // it doesn't matter what numbers you use; you are 
            int[] actualResult = naturalNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
        }
        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            string expectedResult = "1 2 3 4 5";
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            string actualResult = naturalNumber.PrintNumbers(inputArray);
            //string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
