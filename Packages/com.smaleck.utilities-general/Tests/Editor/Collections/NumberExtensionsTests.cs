using NUnit.Framework;
using UtilitiesGeneral.Extensions;

namespace UtilitiesGeneral.Tests.Collections
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
    }
}
