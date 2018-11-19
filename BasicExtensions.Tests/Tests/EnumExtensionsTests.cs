using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicExtensions.Tests
{
    [TestClass]
    public class EnumExtensionsTests
    {
        [DataTestMethod]
        [DataRow(EnumFoo.A, 0)]
        [DataRow(EnumFoo.B, 1)]
        [DataRow(EnumFoo.C, 2)]
        public void ToInt(EnumFoo value, int expected) =>
            Assert.AreEqual(expected, value.ToInt());
    }
}
