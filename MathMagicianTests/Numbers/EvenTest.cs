using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber even = new EvenNumber();

            Assert.IsNotNull(even);
        }

        // This is a sanity check test - ensures everything is hooking up correctly AND
        // that the permissions are correct. 
        // you should have 5 tests - each method and a descriptive name for this
        
        [TestMethod]
        public void EnsureTwoIsTheFirstNumber()
        {
        // Arrange (set it up - instatiate for this)
            EvenNumber even = new EvenNumber();

        // Act (call the method - ONE - you are testing; compare expected with actual result)
        int expectedResult = 2;
        int actualResult = even.GetFirst();

        // Assert (check the method's output)
        Assert.AreEqual(expectedResult, actualResult);
        }
    [TestMethod]
    public void EnsureICanGetNextEven()
    {
        // Arrange
        EvenNumber even = new EvenNumber();
        // Act
        int expectedResult = 8;
        //in myNum; this is zero 0

        // it doesn't matter what numbers you use; you are 
        int actualResult = even.GetNext(8);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
    [TestMethod]
    public void EnsureICanGetSequence()
    {
        //Arrange
        EvenNumber even = new EvenNumber();
        // Act
        int[] expectedResult = { 2, 4, 6, 8, 10 };
        //in myNum; this is zero 0

        // it doesn't matter what numbers you use; you are 
        int[] actualResult = even.GetSequence(5);

        // Assert
        Assert.AreEqual(expectedResult.Length, actualResult.Length);
    }
    [TestMethod]
    public void EnsureICanPrintSequence()
    {
        //Arrange
        EvenNumber even = new EvenNumber();

        // Act
        string expectedResult = "2 4 6 8 10";
        int[] inputArray = new[] { 2, 4, 6, 8, 10 };
        string actualResult = even.PrintNumbers(inputArray);
        //string actualResult = naturalNumber.PrintNumbers(new[] { 2, 4, 6, 8 });

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}
}
