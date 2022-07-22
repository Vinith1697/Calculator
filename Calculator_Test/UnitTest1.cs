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


        //Below given are 10 test methods for addition 
        [TestMethod]
        //Values are supplied as inputs through datarow
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


        //10 test methods for subtraction
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

        //10 methods for division
        [TestMethod]
        public void CalculatorThrowsExceptionWhenDividingByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { calc.Divide(9, 0); });
        }

        [TestMethod]
        [DataRow(2, 8, 4)]
        public void CalculatorDividesTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(2, -8, -4)]
        public void CalculatorDividesTwoNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-2, 8, -4)]
        public void CalculatorDividesPositiveNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-2, -8, 4)]
        public void CalculatorDividesNegativePositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(0, 0, 4)]
        public void CalculatorDividesZeroInNumeratorPositiveDenominatorNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(0, 0, -4)]
        public void CalculatorDividesZeroInNumeratorNegativeDenominatorNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(2.0, 8.4, 4.2)]
        public void CalculatorDividesTwoPositiveDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(2.0, -8.4, -4.2)]
        public void CalculatorDividesTwoNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-2.0, 8.4, -4.2)]
        public void CalculatorDividesPositiveNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        //10 test methods for multiplication
        [TestMethod]
        [DataRow(4, 2, 2)]
        public void CalculatorMultipliesTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(4, -2, -2)]
        public void CalculatorMultipliesTwoNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-4, 2, -2)]
        public void CalculatorMultipliesPositiveNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, 2, 0)]
        public void CalculatorMultipliesPositiveNumberAndZero(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, -2, 0)]
        public void CalculatorMultipliesNegativeNumberAndZero(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(6.3, 4.2, 1.5)]
        public void CalculatorMultipliesTwoPositiveDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Math.Round(calc.Multiply(left, right)), 1);
        }

        [TestMethod]
        [DataRow(6.3, -4.2, -1.5)]
        public void CalculatorMultipliesTwoNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Math.Round(calc.Multiply(left, right)), 1);
        }

        [TestMethod]
        [DataRow(-6.3, 4.2, -1.5)]
        public void CalculatorMultipliesPositiveAndNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, Math.Round(calc.Multiply(left, right)), 1);
        }

        [TestMethod]
        [DataRow(0, 4.2, 0)]
        public void CalculatorMultipliesPositiveDecimalAndZero(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, -4.2, 0)]
        public void CalculatorMultipliesNegativeDecimalAndZero(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }


    }
}
