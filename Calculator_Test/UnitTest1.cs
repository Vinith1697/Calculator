using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;

        [TestInitialize]
        public void Instantiate()
        {
            calc = new Calculator();
        }

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }

        [TestMethod]
        public void CalculatorClassIsInstantiable()
        {
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-2, -1, -1)]
        public void CalculatorCanAddTwoNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-4, 1, -5)]
        public void CalculatorCanAddPositiveNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(4, -1, 5)]
        public void CalculatorCanAddNegativePositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(4, 4, 0)]
        public void CalculatorCanAddZeroAndPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-4, -4, 0)]
        public void CalculatorCanAddZeroAndNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(4.5, 2.3, 2.2)]
        public void CalculatorCanAddDecimalPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-4.5, -2.3, -2.2)]
        public void CalculatorCanAddDecimalNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-2.10, 0, -2.10)]
        public void CalculatorCanAddDecimalZeroAndNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(2.3, 2.3, 0)]
        public void CalculatorCanAddDecimalAndZeroNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(2, 3, 1)]
        public void CalculatorCanSubtractTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(0, -1, -1)]
        public void CalculatorCanSubtractTwoNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(6, 1, -5)]
        public void CalculatorCanSubtractPositiveNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-6, -1, 5)]
        public void CalculatorCanSubtractNegativePositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(4, 4, 0)]
        public void CalculatorCanSubtractZeroAndPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-4, -4, 0)]
        public void CalculatorCanSubtractZeroAndNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(1, 3.5, 2.5)]
        public void CalculatorCanSubtractDecimalPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-1, -3.2, -2.2)]
        public void CalculatorCanSubtractDecimalNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(2.10, 0, -2.10)]
        public void CalculatorCanSubtractDecimalZeroAndNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(2.3, 2.3, 0)]
        public void CalculatorCanSubtractDecimalAndZeroNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }





    }
}
