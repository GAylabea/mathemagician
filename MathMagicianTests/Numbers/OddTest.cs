using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            OddNumber odd = new OddNumber();

            Assert.IsNotNull(odd);
        }

        // This is a sanity check test - ensures everything is hooking up correctly AND
        // that the permissions are correct. 
        // you should have 5 tests - each method and a descriptive name for this

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (set it up - instatiate for this)
            OddNumber odd = new OddNumber();

            // Act (call the method - ONE - you are testing; compare expected with actual result)
            int expectedResult = 1;
            int actualResult = odd.GetFirst();

            // Assert (check the method's output)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureICanGetNextOdd()
        {
            // Arrange
            OddNumber odd = new OddNumber();
            // Act
            int expectedResult = 5;
            //in myNum; this is zero 0

            // it doesn't matter what numbers you use; you are 
            int actualResult = odd.GetNext(5);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureICanGetSequence()
        {
            //Arrange
            OddNumber odd = new OddNumber();
            // Act
            int[] expectedResult = { 1, 3, 5, 7, 9 };
            //in myNum; this is zero 0

            // it doesn't matter what numbers you use; you are 
            int[] actualResult = odd.GetSequence(5);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
        }
        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange
            OddNumber odd = new OddNumber();

            // Act
            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = odd.PrintNumbers(inputArray);
            //string actualResult = naturalNumber.PrintNumbers(new[] { 1, 3, 5, 7, 9 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

