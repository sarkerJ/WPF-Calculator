using NUnit.Framework;
using Calculator;
using System;

namespace CalculatorTests
{
    public class Tests
    {
        
        [TestCase(4,2,6)]
        [TestCase(5, 7, 12)]
        [TestCase(-3, -5, -8)]
        [TestCase(12, -3, 9)]
        public void CorrectAdditionResult(int a, int b, int expected)
        {
            var result = Calculators.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(5, 3, 2)]
        [TestCase(50, 15, 35)]
        [TestCase(7, 4, 3)]
        [TestCase(10, 15, -5)]
        public void CorrectSubtractResult(int a, int b, int expected)
        {
            var result = Calculators.Subtract(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(6, 6, 36)]
        [TestCase(7, 7, 49)]
        [TestCase(2, 8, 16)]
        public void CorrectMultiplyResult(int a, int b, int expected)
        {
            var result = Calculators.Multiply(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(15, 3, 5)]
        [TestCase(49, 7, 7)]
        [TestCase(25, 5, 5)]
        [TestCase(16, 8, 2)]

        public void CorrectDivideResult(int a, int b, int expected)
        {
            var result = Calculators.Divide(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 0, 0)]
        public void TestDivideException(int a, int b, int expected)
        {
            string thrown = "";
            try
            {
                var result = Calculators.Divide(a, b);
            } catch (Exception e )
            {
                thrown = e.Message;
            }

            Assert.AreEqual("cannot divide by 0",thrown);

            //Assert.Throws<DivideByZeroException>(() => Calculators.Divide(a, b)); //don't think it works
        }

        [TestCase(50, 7, 1)]
        [TestCase(33, 5, 3)]
        [TestCase(3, 3, 0)]
        [TestCase(60, 8, 4)]
        public void CorrectModulusResult(int a, int b, int expected)
        {
            var result = Calculators.Modulus(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(4, 16)]
        [TestCase(8, 64)]
        [TestCase(12, 144)]
        [TestCase(60, 3600)]
        public void CorrectPowerOfTwoResult(int a, int expected)
        {
            var result = Calculators.PowerOfTwo(a);
            Assert.AreEqual(expected, result);
        }

        [TestCase(4, 2, 16)]
        [TestCase(8, 4, 4096)]
        [TestCase(3, 5,243)]
        [TestCase(5, 6,15625)]
        public void CorrectPowerOfResult(int a, int b, int expected)
        {
            var result = Calculators.PowerOf(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(60, 7)]
        [TestCase(6, 2)]
        [TestCase(121,11)]
        [TestCase(30, 5)]
        public void CorrectROOTResult(int a, int expected)
        {
            var result = Calculators.Root(a);
            Assert.AreEqual(expected, result);
        }

    }
}