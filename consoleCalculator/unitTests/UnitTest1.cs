using NUnit.Framework;
using consoleCalculator;

namespace consoleCalculator.UnitIest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(10, 2, 12)]
        [TestCase(-14, 8, -6)]
        [TestCase(-14, 14, 0)]
        [TestCase(1, 1, 2)]
        [TestCase(0, 0, 0)]
        public void SumTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calculator.Sum(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCase(10, 2, 8)]
        [TestCase(-14, 8, -22)]
        [TestCase(14, 14, 0)]
        [TestCase(1, -1, 2)]
        [TestCase(0, 0, 0)]
        public void SubstractTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calculator.Substract(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 20)]
        [TestCase(-14, -1,14 )]
        [TestCase(14, 0, 0)]
        [TestCase(1, -1, -1)]
        [TestCase(0, 0, 0)]
        public void MultiplyTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calculator.Multiply(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 5)]
        [TestCase(-14, -1, 14)]
        [TestCase(14, 7, 2)]
        [TestCase(1, -1, -1)]
        [TestCase(0, 5, 0)]
        public void DivisionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calculator.Division(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 0)]
        [TestCase(-14, -1, 0)]
        [TestCase(14, 7, 0)]
        [TestCase(9, 8, 1)]
        [TestCase(0, 5, 0)]
        public void DivideTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calculator.Divide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(25, 5)]
        [TestCase(0, 0)]
        [TestCase(9, 3)]
        [TestCase(1, 1)]
        [TestCase(100,10)]
        public void SqrtTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calculator.Sqrt(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(3, 6)]
        [TestCase(11, 39916800)]
        [TestCase(0, 0)]
        [TestCase(2, 2)]
        public void FactorialTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calculator.Factorial(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}