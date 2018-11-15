using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicExtensions.Tests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void ToStringIso()
        {
            var date = new DateTime(2018, 9, 12, 12, 30, 30);
            var expected = date.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, date.ToStringIso());
        }

        [DataTestMethod]
        [DataRow("2018-08-18")]
        [DataRow("2018-08-19")]
        public void IsWeekend(string dateString) => 
            Assert.IsTrue(dateString.ToDateTime().IsWeekend());

        [DataTestMethod]
        [DataRow("2018-08-13")]
        [DataRow("2018-08-14")]
        [DataRow("2018-08-15")]
        [DataRow("2018-08-16")]
        [DataRow("2018-08-17")]
        public void INotsWeekend(string dateString) => 
            Assert.IsFalse(dateString.ToDateTime().IsWeekend());
    }
}