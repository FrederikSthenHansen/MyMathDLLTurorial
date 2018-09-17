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
            testMathResult = testMath.Subract(7, 9);
            Assert.IsTrue(testMathResult == -2);
        }

        [TestMethod]
        public void SubstractTestNegative()
        {
            testMathResult = testMath.Subract(-13, -7);
            Assert.IsTrue(testMathResult == -6);
        }

        [TestMethod]
        public void SubstractTestSameNegative()
        {
            testMathResult = testMath.Subract(-6, -6);
            Assert.IsTrue(testMathResult == 0);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            testMathResult = testMath.Multiply(8, 5);
            Assert.IsTrue(testMathResult == 40);
        }

        [TestMethod]
        public void MultiplyTestTwoNegative()
        {
            testMathResult = testMath.Multiply(-7, -9);
            Assert.IsTrue(testMathResult == 63);
        }

        [TestMethod]
        public void MultiplyTestOnePositiveOneNegative()
        {
            testMathResult = testMath.Multiply(4, -10);
            Assert.AreEqual(testMathResult,-40);
        }

        [TestMethod]
        public void MultiplyTestTwoPositiveAndANegative()
        {
            testMathResult = testMath.Multiply(5, 6, -3);
            Assert.IsTrue(testMathResult == -90);
        }
        

        [TestMethod]
        public void Dividetest()
        {
            double testMathResultdouble = testMath.Divide(3, 2);
            Assert.AreEqual(testMathResultdouble,1.5);
                
        }

        [TestMethod]
        public void DivideTestTwoNegativeAndAPositive()
        {
            double testMathResultdouble = testMath.Divide(-8, -4, 2);
            Assert.AreEqual(testMathResultdouble, 1);

        }
    }
}
