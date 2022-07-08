using CalculatorTDD;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CalculatorUnitTest
{

    [TestFixture]
    public class UnitTest1
    {
        private Calculator _calculator;
        private CalculatorFormatter _calculatorFormatter;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
            _calculatorFormatter = new CalculatorFormatter();

        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(20000)]
        [TestCase(1000000)]
        [TestCase(20000)]
        public void Add_SingleNumber_ReturnSameNumber(float val1)
        {
            var sot = _calculator.Add(val1);
            Assert.That(sot, Is.EqualTo(val1));
        }
        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(5, 6)]
        [TestCase(10, 50)]

        public void Add_TwoNumber_ReturnSumOfTwoNumber(float val1, float val2)
        {
            var sot = _calculator.Add(val1 + val2);
            Assert.That(sot, Is.EqualTo(val1 + val2));
        }   
        [Test]
        public void Add_MoreThanTwoNumber_ReturnSumOfAllNumberPassed()
        {
            var sot = _calculator.Add(new int[] {1,2,3,4,5});
            Assert.That(sot, Is.EqualTo(15));
        }
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void Substract_SingleNumber_ReturnSameNumber(float val1)
        {
            var sot = _calculator.Subtract(val1);
            Assert.That(sot, Is.EqualTo(val1));
        }
        [Test]
        [TestCase(0,1)]
        [TestCase(1,2)]
        [TestCase(2,3)]
        [TestCase(3,4)]
        [TestCase(4,5)]
        public void Subtract_TwoNumber_ReturnSingleSubtractedNumber(float val1,float val2)
        {
            var sot= _calculator.Subtract(val1, val2);
            Assert.That(sot, Is.EqualTo(val1 - val2)); 
        }

        [Test]
        public void GetNumberFromExpression_WhenValidExpressionPassed_ReturnListOfFloat()
        {
            var sot = _calculatorFormatter.GetNumberFromExpression("1 + 2 + 3 + 4");
            Assert.That(sot, Is.EqualTo(new List<float>() { 1, 2, 3, 4 }));
        }
        [Test]
        public void GetOperatorFromExpression_WhenValidExpressionPassed_ReturnListOfChar()
        {
            var sot = _calculatorFormatter.GetOperatorFromExpression("1 + 2 + 3 + 4");
            Assert.That(sot, Is.EqualTo(new List<char>() { '+', '+', '+' }));
        }
        [Test]
        public void Calculate_WhenValidListFloatAndListCharPassed_ReturnCorrectResult()
        {
            var sot = _calculator.Calculate("1 + 2 + 3 - 4");
            Assert.That(sot, Is.EqualTo(2));
        }


    }
}
