using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenStringAnalyzer_WhenInputIsAFoobar_ThenReturnTrue()
        {
            // Arrange
            var s = "ThisIsAFoobarString";
            var sut = new StringAnalyzer();

            // Act
            var result = sut.IsStringFooBar(s);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenStringAnalyzer_WhenInputIsNotAFoobar_ThenReturnFalse()
        {
            // Arrange
            var s = "ThisIsAString";
            var sut = new StringAnalyzer();

            // Act
            var result = sut.IsStringFooBar(s);

            // Assert
            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void GivenStringAnalyzer_WhenStringIsPalindrome_ThenReturnTrue()
        {
            // Arrange
            var s = "murmellemrum";
            var sut = new StringAnalyzer();

            // Act
            var result = sut.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenStringAnalyzer_WhenStringIsNotPalindrome_ThenReturnFalse()
        {
            // Arrange
            var s = "OhNo";
            var sut = new StringAnalyzer();

            // Act
            var result = sut.IsPalindrome(s);

            // Assert
            Assert.IsFalse(result);
        }

    }
}
