using NUnit.Framework;
using UtilitiesGeneral.Extensions;

namespace UtilitiesGeneral.Tests.Extensions
{
    public class NumberExtensionsTests
    {
        [Test]
        [TestCase(4, 0, 5, 4)]
        [TestCase(5, 0, 5, 5)]
        [TestCase(6, 0, 5, 5)]
        [TestCase(1, 0, 5, 1)]
        [TestCase(0, 0, 5, 0)]
        [TestCase(-1, 0, 5, 0)]
        public void Clamp_Int(int value, int min, int max, int expected)
        {
            var result = value.Clamp(min, max);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(4d, 0d, 5d, 4d)]
        [TestCase(5d, 0d, 5d, 5d)]
        [TestCase(6d, 0d, 5d, 5d)]
        [TestCase(1d, 0d, 5d, 1d)]
        [TestCase(0d, 0d, 5d, 0d)]
        [TestCase(-1d, 0d, 5d, 0d)]
        public void Clamp_Double(double value, double min, double max, double expected)
        {
            var result = value.Clamp(min, max);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-3, false)]
        [TestCase(-2, true)]
        [TestCase(-1, false)]
        [TestCase(0, true)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, false)]
        public void IsEven(int value, bool expected)
        {
            Assert.AreEqual(expected, value.IsEven());
        }

        [Test]
        [TestCase(-3, true)]
        [TestCase(-2, false)]
        [TestCase(-1, true)]
        [TestCase(0, false)]
        [TestCase(1, true)]
        [TestCase(2, false)]
        [TestCase(3, true)]
        public void IsOdd(int value, bool expected)
        {
            Assert.AreEqual(expected, value.IsOdd());
        }
        
        [Test]
        [TestCase(5, 100, 5)]
        [TestCase(100, 200, 50)]
        [TestCase(0, 1337, 0)]
        [TestCase(60, 30, 200)]
        public void ToPercentageOf(double value, double max, double expected)
        {
            Assert.AreEqual(expected, value.ToPercentageOf(max));
        }

        [Test]
        [TestCase(1.0d, 100)]
        [TestCase(0.0d, 0)]
        [TestCase(0.2d, 20)]
        public void ToPercentage(double value, double expected)
        {
            Assert.AreEqual(expected, value.ToPercentage());
        }
    }
}
