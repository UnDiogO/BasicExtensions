using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicExtensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [DataTestMethod]
        [DataRow("Hello World", "Hello", " World")]
        [DataRow("Hello World", "World", "Hello ")]
        public void Delete(string value, string remove, string expected) =>
            Assert.AreEqual(expected, value.Delete(remove));

        [DataTestMethod]
        [DataRow("")]
        [DataRow("0")]
        [DataRow("1")]
        [DataRow("123")]
        public void IsDigits(string value) =>
            Assert.IsTrue(value.IsDigits());

        [DataTestMethod]
        [DataRow("-1")]
        [DataRow("1.0")]
        [DataRow("100.0000")]
        [DataRow("A")]
        [DataRow("1A")]
        public void IsNotDigits(string value) =>
            Assert.IsFalse(value.IsDigits());

        [DataTestMethod]
        [DataRow("")]
        [DataRow("abc")]
        [DataRow("123")]
        [DataRow("123ABC")]
        public void IsLettersOrDigits(string value) =>
            Assert.IsTrue(value.IsLettersOrDigits());

        [DataTestMethod]
        [DataRow("_")]
        [DataRow("%")]
        [DataRow("-1")]
        [DataRow("1.0")]
        [DataRow("100.0000")]
        public void IsNotLettersOrDigits(string value) =>
            Assert.IsFalse(value.IsLettersOrDigits());

        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("", null)]
        [DataRow(" ", null)]
        [DataRow("string", "string")]
        public void NotEmpty(string value, string expected) =>
            Assert.AreEqual(expected, value.NotEmpty());

        [DataTestMethod]
        [DataRow(null, null, null)]
        [DataRow("hello world", 1, "hello worl")]
        [DataRow("hello world", 2, "hello wor")]
        [DataRow("hello world", 3, "hello wo")]
        public void RemoveEnd(string value, int length, string expected) =>
            Assert.AreEqual(expected, value?.RemoveEnd(length));

        [DataTestMethod]
        [DataRow(null, null, null)]
        [DataRow("hello world", 1, "ello world")]
        [DataRow("hello world", 2, "llo world")]
        [DataRow("hello world", 3, "lo world")]
        public void RemoveStart(string value, int length, string expected) =>
            Assert.AreEqual(expected, value?.RemoveStart(length));

        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("Hello World", "hELLO wORLD")]
        [DataRow("hELLO wORLD", "Hello World")]
        public void SwapCase(string value, string expected) =>
            Assert.AreEqual(expected, value?.SwapCase());

        [DataTestMethod]
        [DataRow("hello world", new byte[] { 0x68, 0x65, 0x6C, 0x6C, 0x6F, 0x20, 0x77, 0x6F, 0x72, 0x6C, 0x64 })]
        public void ToBytes(string value, byte[] expected) =>
            Assert.IsTrue(value.ToBytes().SequenceEqual(expected));

        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("hello world", "Hello world")]
        [DataRow("Hello world", "Hello world")]
        public void ToCapitalize(string value, string expected) =>
            Assert.AreEqual(expected, value?.ToCapitalize());

        [DataTestMethod]
        [DataRow(null, 0, null)]
        [DataRow("hello world", 21, "     hello world     ")]
        public void ToCenter(string value, int length, string expected) =>
            Assert.AreEqual(expected, value?.ToCenter(length));

        [TestMethod]
        public void ToDateTime()
        {
            var value = "2018-08-18 12:00:00";
            var expected = new DateTime(2018, 8, 18, 12, 0, 0);
            Assert.AreEqual(expected, value.ToDateTime());
        }

        [TestMethod]
        public void ToGuid()
        {
            var value = "8cbcdfa1-a6fb-4abb-ae33-af9a241dfb1c";
            var expected = Guid.Parse(value);
            Assert.AreEqual(expected, value.ToGuid());
        }

        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("hello world", "5eb63bbbe01eeed093cb22bb8f5acdc3")]
        public void ToMd5(string value, string expected) =>
            Assert.AreEqual(expected, value?.ToMd5());

        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("", "\"\"")]
        [DataRow(" ", "\" \"")]
        [DataRow("string", "\"string\"")]
        public void ToQuote(string value, string expected) =>
            Assert.AreEqual(expected, value?.ToQuote());

        public void ToStringNull() =>
            throw new NotImplementedException();

        [DataTestMethod]
        [DataRow("string", "String")]
        [DataRow("hello world!", "Hello World!")]
        public void ToTitleCase(string value, string expected) =>
            Assert.AreEqual(expected, value?.ToTitleCase());

        [DataTestMethod]
        [DataRow("hello world!", 10, "hello worl")]
        [DataRow("hello world!", 2, "he")]
        [DataRow("hello world!", 8, "hello wo")]
        public void Truncate(string value, int maxLength, string expected) =>
            Assert.AreEqual(expected, value?.Truncate(maxLength));
    }
}