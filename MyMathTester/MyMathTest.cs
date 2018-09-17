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
        public void addTestNegative()
        {
            testMathResult = testMath.Add(-2, -4);
            Assert.IsTrue(testMathResult==-6);
        }
    }
}
