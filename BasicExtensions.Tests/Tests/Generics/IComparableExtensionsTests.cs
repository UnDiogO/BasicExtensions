using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicExtensions.Tests
{
    [TestClass]
    public class IComparableExtensionsTests
    {
        [DataTestMethod]
        [DataRow(0, -5, 5, 0)]
        [DataRow(10, -5, 5, 5)]
        [DataRow(-10, -5, 5, -5)]
        public void ClampInt(int value, int min, int max, int expected) =>
            Assert.AreEqual(expected, value.Clamp(min, max));

        [DataTestMethod]
        [DataRow(0f, -5f, 5f, 0f)]
        [DataRow(10f, -5f, 5f, 5f)]
        [DataRow(-10f, -5f, 5f, -5f)]
        public void ClampFloat(float value, float min, float max, float expected) =>
            Assert.AreEqual(expected, value.Clamp(min, max));

        [DataTestMethod]
        [DataRow("2018-08-18", "2018-08-17", "2018-08-19", "2018-08-18")]
        [DataRow("2018-08-20", "2018-08-17", "2018-08-19", "2018-08-19")]
        [DataRow("2018-08-16", "2018-08-17", "2018-08-19", "2018-08-17")]
        public void ClampDateTime(string value, string min, string max, string expected) =>
            Assert.AreEqual(expected.ToDateTime(), value.ToDateTime().Clamp(min.ToDateTime(), max.ToDateTime()));

        [DataTestMethod]
        [DataRow(0, -5, 5)]
        [DataRow(-5, -5, 5)]
        [DataRow(5, -5, 5)]
        public void IsBetwheenInt(int value, int lower, int upper) =>
            Assert.IsTrue(value.IsBetween(lower, upper));

        [DataTestMethod]
        [DataRow(0f, -5f, 5f)]
        [DataRow(-5f, -5f, 5f)]
        [DataRow(5f, -5f, 5f)]
        public void IsBetwheenFloat(float value, float lower, float upper) =>
            Assert.IsTrue(value.IsBetween(lower, upper));

        [DataTestMethod]
        [DataRow("2018-08-18", "2018-08-17", "2018-08-19")]
        [DataRow("2018-08-17", "2018-08-17", "2018-08-19")]
        [DataRow("2018-08-19", "2018-08-17", "2018-08-19")]
        public void IsBetwheenDateTime(string value, string lower, string upper) =>
            Assert.IsTrue(value.ToDateTime().IsBetween(lower.ToDateTime(), upper.ToDateTime()));
    }
}