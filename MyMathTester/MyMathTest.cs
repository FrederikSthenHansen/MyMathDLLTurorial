using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathDLLTurorial;

namespace MyMathTester
{
    [TestClass]
    public class MyMathTest
    {
        MathMachine testMath = new MathMachine();
        private int testMathResult;
        [TestMethod]
        public void AddTest()
        {
            
           testMathResult = testMath.Add(1, 2);
            Assert.IsTrue(testMathResult==3);
        }

        [TestMethod]
        public void ÁddTestNegative()
        {
            testMathResult = testMath.Add(-2, -4);
            Assert.IsTrue(testMathResult==-6);
        }

        [TestMethod]
        public void AddTestPositiveAndNegative()
        {
            testMathResult = testMath.Add(5, -7);
            Assert.IsTrue(testMathResult == -2);
        }

        [TestMethod]
        public void AddTestThreeIntegers()
        {
            testMathResult = testMath.Add(8, 19, 6);
            Assert.IsTrue(testMathResult == 33);
        }

        [TestMethod]
        public void AddTestThreeLargeIntegers()
        {
            testMathResult = testMath.Add(10147, -1991, 2018);
            Assert.IsTrue(testMathResult == 10174);
        }

        [TestMethod]
        public void SubstractTest()
        {
            testMathResult = testMath.subract(7, 9);
            Assert.IsTrue(testMathResult == -2);
        }
    }
}
