using NUnit.Framework;
using UtilitiesGeneral.Extensions;

namespace UtilitiesGeneral.Tests.Extensions
{
    public class EnumExtensionsTests
    {
        public enum TestEnum
        {
            TestValue1 = 7000,
            TestValue2 = 8000,
            TestValue3 = 9000
        }

        [Test]
        [TestCase(TestEnum.TestValue1, TestEnum.TestValue2)]
        [TestCase(TestEnum.TestValue2, TestEnum.TestValue3)]
        [TestCase(TestEnum.TestValue3, TestEnum.TestValue3)]
        public void EnumExtensionsNext(TestEnum current, TestEnum expectedNext)
        {
            var next = current.Next();
            Assert.AreEqual(expectedNext, next);
        }

        [Test]
        [TestCase(TestEnum.TestValue1, TestEnum.TestValue1)]
        [TestCase(TestEnum.TestValue2, TestEnum.TestValue1)]
        [TestCase(TestEnum.TestValue3, TestEnum.TestValue2)]
        public void EnumExtensionsPrevious(TestEnum current, TestEnum expectedPrevious)
        {
            var previous = current.Previous();
            Assert.AreEqual(expectedPrevious, previous);
        }

        [Test]
        [TestCase(TestEnum.TestValue1, TestEnum.TestValue2)]
        [TestCase(TestEnum.TestValue2, TestEnum.TestValue3)]
        [TestCase(TestEnum.TestValue3, TestEnum.TestValue1)]
        public void EnumExtensionsNextWrap(TestEnum current, TestEnum expectedNext)
        {
            var next = current.NextWrap();
            Assert.AreEqual(expectedNext, next);
        }

        [Test]
        [TestCase(TestEnum.TestValue1, TestEnum.TestValue3)]
        [TestCase(TestEnum.TestValue2, TestEnum.TestValue1)]
        [TestCase(TestEnum.TestValue3, TestEnum.TestValue2)]
        public void EnumExtensionsPreviousWrap(TestEnum current, TestEnum expectedPrevious)
        {
            var previous = current.PreviousWrap();
            Assert.AreEqual(expectedPrevious, previous);
        }
    }
}
