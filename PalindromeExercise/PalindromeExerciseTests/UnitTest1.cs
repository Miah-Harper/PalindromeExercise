using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("level", true)]
        [InlineData("miah", false)]
        [InlineData("bye", false)]
        [InlineData("Racecar", true)]

        public void PalindromeTester(string word, bool expected)
        {

            //arrange
            WordSmith reverseWords = new WordSmith();

            //act

            var actual = reverseWords.IsAPalindrome(word);


            //assert
            Assert.Equal(expected, actual);
        }
    }
}
