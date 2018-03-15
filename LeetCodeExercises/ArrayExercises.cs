using System;
using System.Collections.Generic;

namespace LeetCodeExercises
{
    public static class ArrayExercises
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

        // Rotate Array 
        // time O(N)
        // space O(N)
        public static int[] Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length <= 0 || k <= 0)
                return nums;

            int[] tmp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) {
                tmp[(i + k) % nums.Length] = nums[i];
            }

            Array.Copy(tmp, nums, nums.Length);

            return nums;
        }

        // Find All Duplicates in an Array [Time Limit Exceeded]
        // time O(N2)
        // space O(1)
        public static IList<int> FindDuplicatesBruteForce(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length - 1; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] == nums[j])
                        result.Add(nums[i]);
                }
            }

            return result;
        }

        // Find All Duplicates in an Array
        // time O(N)
        // space O(N)
        public static IList<int> FindDuplicatesTimeOptimization(int[] nums)
        {
            var result = new List<int>();

            var hashSet = new HashSet<int>();
            foreach (int n in nums) {
                if (hashSet.Contains(n)) {
                    result.Add(n);
                } else {
                    hashSet.Add(n);
                }
            }

            return result;
        }

        // Find All Duplicates in an Array
        // time O(N)
        // space O(1)
        public static IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();
            foreach (int n in nums) {
                int index = Math.Abs(n) - 1;
                if (nums[index] > 0) {
                    nums[index] = -nums[index];
                } else {
                    result.Add(index + 1);
                }
            }
            return result;
        }
    }
}
