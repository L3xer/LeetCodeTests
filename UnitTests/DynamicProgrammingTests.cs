using LeetCodeExercises;
using Xunit;

namespace UnitTests
{
    public class DynamicProgrammingTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
        [InlineData(new int[] { 2, 5, 0, 0}, true)]
        [InlineData(new int[] { 1, 0, 1, 1 }, false)]
        [InlineData(new int[] { 0 }, true)]
        [InlineData(new int[] {5, 4, 0, 2, 0, 1, 0, 1, 0 }, false)]
        public void CabJumpTest(int[] nums, bool expected)
        {
            bool actual = DynamicProgrammingExercises.CanJump(nums);

            Assert.Equal(expected, actual);
        }
    }
}
