using Xunit;
using LeetCodeExercises;


namespace UnitTests
{
    public class StringTests
    {
        [Theory]
        [InlineData("hello", "olleh")]
        public void ReverseStringTest(string s, string expected)
        {
            string actual = StringExercises.ReverseString(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("cc", -1)]
        [InlineData("z", 0)]
        [InlineData("aadadaad", -1)]        
        public void FirstUniqCharTest(string s, int expected)
        {
            int actual = StringExercises.FirstUniqChar(s);
            Assert.Equal(expected, actual);
        }
    }
}
