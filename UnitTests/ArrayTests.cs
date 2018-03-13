using Xunit;
using LeetCodeExercises;
using System.Linq;

namespace UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(new int[] { 2 }, 0)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 3, 2, 6, 5, 0, 3 }, 7)]
        public void MaxProfitTest(int[] prices, int maxProfit)
        {
            int result = ArrayExercises.MaxProfit(prices);

            Assert.Equal(maxProfit, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 6, new int[] { 2, 3, 4, 5, 6, 7, 1 })]
        [InlineData(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2 }, 3, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 11, new int[] { 2, 3, 4, 5, 6, 1 })]
        public void RotateTest(int[] nums, int k, int[] expected)
        {
            int[] actual = ArrayExercises.Rotate(nums, k);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 2, 3 })]
        public void FindDuplicatesTest(int[] nums, int[] expected)
        {
            int[] actual = ArrayExercises.FindDuplicates(nums).ToArray();

            Assert.Equal(expected, actual);
        }
    }
}
