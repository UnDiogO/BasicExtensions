using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicExtensions.Tests
{
    [TestClass]
    public class ClassExtensionsTest
    {
        [DataTestMethod]
        [DataRow("[Foo: Bar=, Number=1, Text=Hello]")]
        public void ToHumanReadable(string expected)
        {
            var foo = new Foo(1, "Hello");
            var result = foo.ToHumanReadable();
            Assert.AreEqual(expected, result);
        }
    }
}