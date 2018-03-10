using Xunit;
using LeetCodeExercises;

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
            int result = Array.MaxProfit(prices);

            Assert.Equal(maxProfit, result);
        }
    }
}
