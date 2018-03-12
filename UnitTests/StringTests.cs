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
    }
}
