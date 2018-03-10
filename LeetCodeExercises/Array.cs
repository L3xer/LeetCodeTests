namespace LeetCodeExercises
{
    public static class Array
    {
        // Remove Duplicates from Sorted Array
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;
            for (int j = 1; j < nums.Length; j++) {
                if (nums[j] != nums[i]) {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }

        // Best Time to Buy and Sell Stock II
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 1)
                return 0;

            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++) {
                if (prices[i] > prices[i - 1]) {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }

            return maxProfit;
        }
    }
}
