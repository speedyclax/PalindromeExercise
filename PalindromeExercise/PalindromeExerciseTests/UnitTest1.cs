using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("bulldog", false)]
        [InlineData("mom", true)]

        public void PalindromeTest(string word, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }

    }
}
