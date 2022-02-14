using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TinyCalculator;

namespace TinyCaluclatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            Calculator calc = new Calculator();
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            Calculator calc = new Calculator();
            try
            {
                int result = calc.Calculate("abcd");
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }


        [TestMethod]
        public void OnePlusOne()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("1+1");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FiveMinusTwo()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("5-2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FourPlusEleven()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("4+11");
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TwoMinusOne()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("2-1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TwoPlusTwo()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("2+2");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void EightDividedByTwo()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("8/2");
            Assert.AreEqual(4, result);
        }
        
        [TestMethod]
        public void FiveTimesTwo()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("5*2");
            Assert.AreEqual(10, result);
        }



    }
}
