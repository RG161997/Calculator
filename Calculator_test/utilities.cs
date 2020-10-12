using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
namespace Calculator_test
{
    [TestClass]
    public class utilities
    {
        [TestMethod]
        public void TestMethodAddPositiveNumbers()
        {
            int iFIrstNumber = 1;
            int iSecondNumber = 2;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "a"), 3);
        }

        private int DoOperation(int iFIrstNumber, int iSecondNumber, string v)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestMethodAddNegativeNumbers()
        {
            int iFIrstNumber = -1;
            int iSecondNumber = -5;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "a"), -6);
        }

        [TestMethod]
        public void TestMethodAddPositiveNegativeNumbers()
        {
            int iFIrstNumber = 1;
            int iSecondNumber = -5;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "a"), -4);
        }

        [TestMethod]
        public void TestMethodSubPositiveNumbers()
        {
            int iFIrstNumber = 3;
            int iSecondNumber = 2;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "s"), 1);
        }

        [TestMethod]
        public void TestMethodSubNegativeNumbers()
        {
            int iFIrstNumber = -3;
            int iSecondNumber = -25;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "s"), 22);
        }

        [TestMethod]
        public void TestMethodSubPositiveNegativeNumbers()
        {
            int iFIrstNumber = -3;
            int iSecondNumber = 25;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "s"), -28);
        }

        [TestMethod]
        public void TestMethodMulPositiveNumbers()
        {
            int iFIrstNumber = 3;
            int iSecondNumber = 2;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "m"), 6);
        }

        [TestMethod]
        public void TestMethodMulNegativeNumbers()
        {
            int iFIrstNumber = -3;
            int iSecondNumber = -2;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "m"), 6);
        }

        [TestMethod]
        public void TestMethodDivPositiveNumbers()
        {
            int iFIrstNumber = 3;
            int iSecondNumber = 3;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "d"), 1);
        }

        [TestMethod]
        public void TestMethodDivNegativeNumbers()
        {
            int iFIrstNumber = -3;
            int iSecondNumber = -3;

            utilities objCalculator = new utilities();
            Assert.AreEqual(objCalculator.DoOperation(iFIrstNumber, iSecondNumber, "d"), 1);
        }
    }
}

