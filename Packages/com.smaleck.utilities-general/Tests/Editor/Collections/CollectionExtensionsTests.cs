using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UtilitiesGeneral.Extensions;

namespace UtilitiesGeneral.Tests.Collections
{
    public class CollectionExtensionsTests
    {
        private class TestDataClass
        {
            public int Value;
        }

        [Test]
        public void AddOrReplace()
        {
            var data = new Dictionary<int, int>
            {
                {0, 100}
            };

            data.AddOrReplace(1, 200);

            Assert.AreEqual(data[0], 100);
            Assert.True(data.ContainsKey(1));
            Assert.AreEqual(data[1], 200);

            data.AddOrReplace(1, 300);

            Assert.AreEqual(data[0], 100);
            Assert.True(data.ContainsKey(1));
            Assert.AreEqual(data[1], 300);
        }

        [Test]
        public void ForEach_Array()
        {
            var data = CreateTestData();

            data.ForEach(e => e.Value += 1);

            Assert.AreEqual(1, data[0].Value);
            Assert.AreEqual(2, data[1].Value);
            Assert.AreEqual(3, data[2].Value);
        }

        [Test]
        public void ForEach_Enumerable()
        {
            var data = CreateTestData();

            data
                .Select(e => e)
                .ForEach(e => e.Value += 1);

            Assert.AreEqual(1, data[0].Value);
            Assert.AreEqual(2, data[1].Value);
            Assert.AreEqual(3, data[2].Value);
        }

        [Test]
        public void ForPassesCorrectIndex()
        {
            var data = CreateTestData();

            data.For((e, i) =>
            {
                Assert.AreEqual(e, data[i]);
            });
        }

        private TestDataClass[] CreateTestData()
        {
            return Enumerable
                .Range(0, 3)
                .Select(e => new TestDataClass() { Value = e })
                .ToArray();
        }
    }
}
