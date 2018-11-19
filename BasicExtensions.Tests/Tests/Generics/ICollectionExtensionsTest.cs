using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicExtensions.Tests
{
    [TestClass]
    public class ICollectionExtensionsTest
    {
        [TestMethod]
        public void AddIfNotContainsFalse()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            Assert.IsFalse(list.AddIfNotContains(1));
        }   

        [TestMethod]
        public void AddIfNotContainsTrue()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            Assert.IsTrue(list.AddIfNotContains(6));
        }

        [TestMethod]
        public void IsNullOrEmptyFalse()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            Assert.IsFalse(list.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrEmptyTrue()
        {
            var list = new List<int>();
            Assert.IsTrue(list.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrEmptyNull()
        {
            List<int> list = null;
            Assert.IsTrue(list.IsNullOrEmpty());
        }
    }
}