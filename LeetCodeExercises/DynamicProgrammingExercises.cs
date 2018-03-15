using System;

namespace LeetCodeExercises
{
    public static class DynamicProgrammingExercises
    {
        public static bool CanJump(int[] nums)
        {
            int distance = 0;
            int lastIndex = nums.Length - 1;

            for (int i = 0; i <= distance; i++) {
                distance = Math.Max(distance, nums[i] + i);
                if (distance >= lastIndex)
                    return true;
            }

            return false;
        }
    }
}
